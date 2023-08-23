using NLog;
using System.Collections.Concurrent;
using System.Reflection;

namespace BlazeCommon
{
    public class BlazeServer : ProtoFireServer
    {
        public BlazeServerSettings Settings { get; }

        Dictionary<ushort, IBlazeComponent> _components;
        ConcurrentDictionary<ProtoFireConnection, BlazeRpcContext> _connectionContexts;
        private static Logger _logger = LogManager.GetCurrentClassLogger();
        public BlazeServer(BlazeServerSettings settings) : base(settings.Name, settings.LocalEP, settings.Certificate)
        {
            Settings = settings;
            _components = new Dictionary<ushort, IBlazeComponent>();
            _connectionContexts = new ConcurrentDictionary<ProtoFireConnection, BlazeRpcContext>();
        }

        public bool AddComponent<TComponent>() where TComponent : IBlazeComponent, new()
        {
            TComponent component = new TComponent();
            return _components.TryAdd(component.Id, component);
        }

        public bool RemoveComponent(ushort componentId, out IBlazeComponent? component)
        {
            return _components.Remove(componentId, out component);
        }

        public IBlazeComponent? GetComponent(ushort componentId)
        {
            _components.TryGetValue(componentId, out IBlazeComponent? component);
            return component;
        }


        BlazeRpcContext GetRpcContext(ProtoFireConnection connection)
        {
            return _connectionContexts.GetOrAdd(connection, (c) =>
            {
                return new BlazeRpcContext(c);
            });
        }

        BlazeRpcContext? RemoveRpcContext(ProtoFireConnection connection)
        {
            _connectionContexts.TryRemove(connection, out BlazeRpcContext? context);
            return context;
        }

        public override void OnProtoFireConnect(ProtoFireConnection connection)
        {

        }

        public override void OnProtoFireDisconnect(ProtoFireConnection connection)
        {
            RemoveRpcContext(connection);
        }

        public override void OnProtoFireError(ProtoFireConnection connection, Exception exception)
        {
            _logger.Error(exception, "ProtoFireError occured");
        }


        IBlazePacket DecodePacket(ProtoFirePacket packet)
        {
            FireFrame frame = packet.Frame;
            IBlazeComponent? component = GetComponent(frame.Component);
            if (component == null)
                return packet.Decode(typeof(NullStruct), Settings.Decoder);

            Type? type;

            switch (frame.MsgType)
            {
                case FireFrame.MessageType.MESSAGE:
                    type = component.GetCommandRequestType(frame.Command);
                    break;
                case FireFrame.MessageType.REPLY:
                    type = component.GetCommandResponseType(frame.Command);
                    break;
                case FireFrame.MessageType.NOTIFICATION:
                    type = component.GetNotificationType(frame.Command);
                    break;
                case FireFrame.MessageType.ERROR_REPLY:
                    type = component.GetCommandErrorResponseType(frame.Command);
                    break;
                default:
                    type = typeof(NullStruct);
                    break;
            }

            type ??= typeof(NullStruct);
            return packet.Decode(type, Settings.Decoder);
        }

        Task SendBlazePacket(ProtoFireConnection connection, IBlazeComponent? component, IBlazePacket packet)
        {
            LogPacket(component, packet, false);
            return connection.SendAsync(packet.ToProtoFirePacket(Settings.Encoder));
        }

        void LogPacket(IBlazeComponent? component, IBlazePacket packet, bool inbound)
        {
            if (component == null)
            {
                _logger.Warn(packet.Frame.ToString(inbound));
                return;
            }

            if (_logger.IsDebugEnabled)
                _logger.Debug(packet.ToString(component, inbound));
            else
                _logger.Info(packet.Frame.ToString(component, inbound));
        }

        IBlazePacket GetErrorResponse(IBlazePacket requestPacket, BlazeRpcException exception)
        {
            if (exception.ErrorResponse != null)
                return requestPacket.CreateResponsePacket(exception.ErrorResponse, exception.ErrorCode);
            else
                return requestPacket.CreateResponsePacket(exception.ErrorCode);
        }

        public override async void OnProtoFirePacketReceived(ProtoFireConnection connection, ProtoFirePacket packet)
        {
            FireFrame frame = packet.Frame;
            IBlazePacket blazePacket = DecodePacket(packet);
            IBlazeComponent? component = GetComponent(frame.Component);
            LogPacket(component, blazePacket, true);

            if (frame.MsgType != FireFrame.MessageType.MESSAGE)
            {
                _logger.Error("Connection({ClientId}) message with type {MsgType} not handled!", connection.ID, frame.MsgType);
                return;
            }

            IBlazePacket response;
            if (component == null)
            {
                response = blazePacket.CreateResponsePacket(new NullStruct(), Settings.ComponentNotFoundErrorCode);
                await SendBlazePacket(connection, component, response).ConfigureAwait(false);
                return;
            }

            BlazeCommandInfo? commandInfo = component.GetBlazeCommandInfo(frame.Command);
            if (commandInfo == null)
            {
                response = blazePacket.CreateResponsePacket(new NullStruct(), Settings.CommandNotFoundErrorCode);
                await SendBlazePacket(connection, component, response).ConfigureAwait(false);
                return;
            }

            try
            {
                object responseObj = await commandInfo.InvokeAsync(blazePacket.DataObj, GetRpcContext(connection)).ConfigureAwait(false);
                response = blazePacket.CreateResponsePacket(responseObj);
            }
            catch (Exception exception)
            {
                if (exception is BlazeRpcException rpcException)
                    response = GetErrorResponse(blazePacket, rpcException);
                else if (exception is TargetInvocationException targException && targException.InnerException is BlazeRpcException rpcException2)
                    response = GetErrorResponse(blazePacket, rpcException2);
                else
                {
                    response = blazePacket.CreateResponsePacket(new NullStruct(), Settings.ErrSystemErrorCode);
                    OnProtoFireError(connection, exception);
                }
            }

            await SendBlazePacket(connection, component, response).ConfigureAwait(false);
        }
    }
}
