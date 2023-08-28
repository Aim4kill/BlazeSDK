using NLog;
using System.Collections.Concurrent;
using System.Reflection;

namespace BlazeCommon
{
    public class BlazeServer : ProtoFireServer
    {
        public BlazeServerConfiguration Configuration { get; }


        ConcurrentDictionary<ProtoFireConnection, BlazeServerConnection> _connections;
        private static Logger _logger = LogManager.GetCurrentClassLogger();
        public BlazeServer(BlazeServerConfiguration settings) : base(settings.Name, settings.LocalEP, settings.Certificate)
        {
            Configuration = settings;

            _connections = new ConcurrentDictionary<ProtoFireConnection, BlazeServerConnection>();
        }

        public bool AddComponent<TComponent>() where TComponent : IBlazeComponent, new()
        {
            return Configuration.AddComponent<TComponent>();
        }

        public bool RemoveComponent(ushort componentId, out IBlazeComponent? component)
        {
            return Configuration.RemoveComponent(componentId, out component);
        }

        public IBlazeComponent? GetComponent(ushort componentId)
        {
            return Configuration.GetComponent(componentId);
        }

        BlazeServerConnection GetBlazeConnection(ProtoFireConnection connection)
        {
            return _connections.GetOrAdd(connection, (c) =>
            {
                return new BlazeServerConnection(c, Configuration);
            });
        }

        public override void OnProtoFireConnect(ProtoFireConnection connection)
        {
            Configuration.OnNewConnection?.Invoke(GetBlazeConnection(connection));
        }

        public override void OnProtoFireDisconnect(ProtoFireConnection connection)
        {
            if (_connections.TryRemove(connection, out BlazeServerConnection? connectionInfo))
                Configuration.OnDisconnected?.Invoke(connectionInfo);
        }

        public override void OnProtoFireError(ProtoFireConnection connection, Exception exception)
        {
            _logger.Error(exception, "ProtoFireError occured");
        }


        IBlazePacket DecodePacket(ProtoFirePacket packet)
        {
            FireFrame frame = packet.Frame;
            IBlazeComponent? component = Configuration.GetComponent(frame.Component);
            if (component == null)
                return packet.Decode(typeof(NullStruct), Configuration.Decoder);

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
            return packet.Decode(type, Configuration.Decoder);
        }

        Task SendBlazePacket(ProtoFireConnection connection, IBlazeComponent? component, IBlazePacket packet)
        {
            Utils.LogPacket(component, packet, false);
            return connection.SendAsync(packet.ToProtoFirePacket(Configuration.Encoder));
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
            IBlazeComponent? component = Configuration.GetComponent(frame.Component);
            Utils.LogPacket(component, blazePacket, true);

            if (frame.MsgType != FireFrame.MessageType.MESSAGE)
            {
                _logger.Error("Connection({ClientId}) message with type {MsgType} not handled!", connection.ID, frame.MsgType);
                return;
            }

            IBlazePacket response;
            if (component == null)
            {
                response = blazePacket.CreateResponsePacket(new NullStruct(), Configuration.ComponentNotFoundErrorCode);
                await SendBlazePacket(connection, component, response).ConfigureAwait(false);
                return;
            }

            BlazeCommandInfo? commandInfo = component.GetBlazeCommandInfo(frame.Command);
            if (commandInfo == null)
            {
                response = blazePacket.CreateResponsePacket(new NullStruct(), Configuration.CommandNotFoundErrorCode);
                await SendBlazePacket(connection, component, response).ConfigureAwait(false);
                return;
            }

            BlazeServerConnection blazeConnection = GetBlazeConnection(connection);
            //marking that blaze connection is busy with some kind of request
            await blazeConnection.IsBusyLock.WaitAsync().ConfigureAwait(false);
            try
            {
                BlazeRpcContext? context = new BlazeRpcContext(blazeConnection, frame.FullErrorCode, frame.MsgNum, frame.UserIndex, frame.Context);
                object responseObj = await commandInfo.InvokeAsync(blazePacket.DataObj, context).ConfigureAwait(false);
                response = blazePacket.CreateResponsePacket(responseObj);
                context = null;
            }
            catch (Exception exception)
            {
                if (exception is BlazeRpcException rpcException)
                {
                    if (rpcException.InnerException != null)
                        OnProtoFireError(connection, rpcException.InnerException);
                    response = GetErrorResponse(blazePacket, rpcException);
                }
                else if (exception is TargetInvocationException targException && targException.InnerException is BlazeRpcException rpcException2)
                {
                    if (rpcException2.InnerException != null)
                        OnProtoFireError(connection, rpcException2.InnerException);
                    response = GetErrorResponse(blazePacket, rpcException2);
                }
                else
                {
                    response = blazePacket.CreateResponsePacket(new NullStruct(), Configuration.ErrSystemErrorCode);
                    OnProtoFireError(connection, exception);
                }
            }


            await SendBlazePacket(connection, component, response).ConfigureAwait(false);
            blazeConnection.IsBusyLock.Release();
        }
    }
}
