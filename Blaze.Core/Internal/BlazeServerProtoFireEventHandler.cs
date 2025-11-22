using EATDF;
using EATDF.Serialization;
using EATDF.Types;
using Microsoft.Extensions.Logging;
using Org.BouncyCastle.Bcpg;
using ProtoFire;
using ProtoFire.Frames;
using ProtoFire.Tls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blaze.Core.Internal
{
    internal class BlazeServerProtoFireEventHandler(BlazeServerConfig config, ILogger logger) : IProtoFireHandler
    {
        private IBlazeServerCallbacks _handler = config.CallbackHandler;
        private IBlazeRouter _router = config.Router;
        private ITdfSerializer _serializer = config.Serializer;

        public Task<bool> OnConnectedAsync(ProtoFireConnection connection)
        {
            BlazeRpcConnection rpcConnection = getBlazeRpcConnection(connection);

            if (logger.IsEnabled(LogLevel.Debug))
                logger.LogDebug("New connection[{0}] connected from {1}.", rpcConnection.Id, rpcConnection.RemoteEndPoint);

            return _handler.OnConnectedAsync(rpcConnection);
        }
        public ProtoSSLCertificate? SelectCertificate(ProtoFireConnection connection)
        {
            BlazeRpcConnection rpcConnection = getBlazeRpcConnection(connection);

            if (logger.IsEnabled(LogLevel.Debug))
                logger.LogDebug("Connection[{0}] requested a certificate.", rpcConnection.Id);

            return _handler.SelectCertificate(rpcConnection);
        }

        public Task OnAuthenticatedAsync(ProtoFireConnection connection, bool secure)
        {
            BlazeRpcConnection rpcConnection = getBlazeRpcConnection(connection);

            if (logger.IsEnabled(LogLevel.Debug))
                logger.LogDebug("Connection[{0}] authenticated.", rpcConnection.Id);

            return _handler.OnAuthenticatedAsync(rpcConnection, secure);
        }

        public Task OnDisconnectedAsync(ProtoFireConnection connection)
        {
            BlazeRpcConnection rpcConnection = getBlazeRpcConnection(connection);

            if (logger.IsEnabled(LogLevel.Debug))
                logger.LogDebug("Connection[{0}] disconnected.", rpcConnection.Id);

            return _handler.OnDisconnectedAsync(rpcConnection);
        }

        public Task OnErrorAsync(ProtoFireConnection connection, Exception exception)
        {
            BlazeRpcConnection rpcConnection = getBlazeRpcConnection(connection);
            return OnErrorAsync(rpcConnection, exception);
        }

        public Task OnErrorAsync(BlazeRpcConnection rpcConnection, Exception exception)
        {
            if (logger.IsEnabled(LogLevel.Error))
                logger.LogError(exception, "Connection[{0}] error.", rpcConnection.Id);

            return _handler.OnErrorAsync(rpcConnection, exception);
        }

        public async Task OnPacketReceivedAsync(ProtoFireConnection connection, ProtoFirePacket packet)
        {
            BlazeRpcConnection rpcConnection = getBlazeRpcConnection(connection);
            rpcConnection.LastActivityTime = DateTime.UtcNow;

            await rpcConnection.BusyLock.EnterAsync();

            try
            {
                Task task = packet.Frame.MessageType switch
                {
                    MessageType.Message => onMessagePacketAsync(rpcConnection, packet),
                    _ => _handler.OnUnhandledAsync(rpcConnection, packet, false)
                };

                await task.ConfigureAwait(false);
            }
            finally
            {
                rpcConnection.BusyLock.Exit();
            }

        }

        public Task OnPacketSentAsync(ProtoFireConnection connection, ProtoFirePacket packet)
        {
            return Task.CompletedTask;
        }

        BlazeRpcConnection getBlazeRpcConnection(ProtoFireConnection fireConnection)
        {
            if (fireConnection.State is BlazeRpcConnection rpcConnection)
                return rpcConnection;

            rpcConnection = new BlazeRpcConnection(fireConnection, _serializer);
            fireConnection.State = rpcConnection;
            return rpcConnection;
        }

        async Task onMessagePacketAsync(BlazeRpcConnection rpcConnection, ProtoFirePacket packet)
        {
            IBlazeComponent? component = _router.GetComponent(packet.Frame.Component);
            if (component == null)
            {
                await _handler.OnUnhandledAsync(rpcConnection, packet, false).ConfigureAwait(false);
                return;
            }

            IRpcCommandFunc? commandFunc = component.GetCommandFunc(packet.Frame.Command);
            if (commandFunc == null)
            {
                await _handler.OnUnhandledAsync(rpcConnection, packet, false).ConfigureAwait(false);
                return;
            }

            Tdf requestTdf = commandFunc.CreateRequestTdf();
            if (!_serializer.Deserialize(packet.GetDataStream(), requestTdf))
            {
                Task t1 = _handler.OnUnhandledAsync(rpcConnection, packet, true);
                Task t2 = OnErrorAsync(rpcConnection, new Exception("Failed to deserialize request TDF"));
                await Task.WhenAll(t1, t2).ConfigureAwait(false);
                return;
            }

            logPacket(rpcConnection, packet, requestTdf, true);

            BlazeRpcContext context = new BlazeRpcContext()
            {
                Connection = rpcConnection,
                Context = packet.Frame.Context,
                ErrorCode = packet.Frame.ErrorCode,
                MessageNum = packet.Frame.MessageNum,
                UserIndex = packet.Frame.UserIndex
            };

            Tdf? rpcResult;
            ushort errorCode = 0;
            try
            {
                rpcResult = await commandFunc.InvokeAsync(requestTdf, context).ConfigureAwait(false);
            }
            catch (BlazeRpcException blazeException)
            {
                rpcResult = blazeException.ErrorResponse;
                errorCode = blazeException.ErrorCode;
            }
            catch (Exception ex)
            {
                Task t1 = OnErrorAsync(rpcConnection, ex);
                Task t2 = _handler.OnRpcCommandErrorAsync(rpcConnection, packet, requestTdf, ex);
                await Task.WhenAll(t1, t2).ConfigureAwait(false);
                return;
            }
            
            IFireFrame responseFrame = packet.Frame.CreateResponseFrame(errorCode);

            byte[] responseData;
            if (rpcResult == null)
                responseData = Array.Empty<byte>();
            else
            {
                MemoryStream responseStream = new MemoryStream();
                _serializer.Serialize(responseStream, rpcResult);
                responseData = responseStream.ToArray();
                responseStream.Dispose();
            }

            ProtoFirePacket responsePacket = new ProtoFirePacket(responseFrame, responseData);

            logPacket(rpcConnection, responsePacket, rpcResult, false);
            await rpcConnection.SendAsync(responsePacket).ConfigureAwait(false);
        }

        // Clients never send notifications to blaze server, only server to clients
        //Task onNotificationPacketAsync(BlazeRpcConnection connection, ProtoFirePacket packet)
        //{
        //    IBlazeComponent? component = _router.GetComponent(packet.Frame.Component);
        //    if (component == null)
        //        return _handler.OnUnhandledAsync(connection, packet, false);

        //    IRpcNotificationFunc? notificationFunc = component.GetNotificationFunc(packet.Frame.Command);
        //    if (notificationFunc == null)
        //        return _handler.OnUnhandledAsync(connection, packet, false);

        //    Tdf notificationTdf = notificationFunc.CreateNotificationTdf();
        //    if (!_serializer.Deserialize(packet.GetDataStream(), notificationTdf))
        //    {
        //        Task t1 = _handler.OnUnhandledAsync(connection, packet, true);
        //        Task t2 = _handler.OnErrorAsync(connection, new Exception("Failed to deserialize notification TDF"));
        //        return Task.WhenAll(t1, t2);
        //    }

        //    logPacket(connection, packet, notificationTdf, true);

        //    BlazeRpcContext context = new BlazeRpcContext()
        //    {
        //        Connection = connection,
        //        Context = packet.Frame.Context,
        //        ErrorCode = packet.Frame.ErrorCode,
        //        MessageNum = packet.Frame.MessageNum,
        //        UserIndex = packet.Frame.UserIndex
        //    };

        //    return notificationFunc.InvokeAsync(notificationTdf, context);

        //}

        void logPacket(BlazeRpcConnection connection, ProtoFirePacket packet, Tdf? deserializedContent, bool inbound)
        {
            if(!logger.IsEnabled(LogLevel.Debug))
                return;

            string dir = Environment.NewLine + (inbound ? "<-" : "->");

            string format = "Connection[{connId}]{dir} {type}: ID[{msgId}], UI[{userIdx}], {component}::{command} [0x{component:X4}::0x{command:X4}]{error}{tdf}";

            IBlazeComponent? component = _router.GetComponent(packet.Frame.Component);
            string componentName;
            string commandName;
            if(component != null)
            {
                componentName = component.Name;
                commandName = packet.Frame.MessageType switch
                {
                    MessageType.Message => component.GetCommandFunc(packet.Frame.Command)?.Name ?? packet.Frame.Command.ToString(),
                    MessageType.Reply => component.GetCommandFunc(packet.Frame.Command)?.Name ?? packet.Frame.Command.ToString(),
                    MessageType.Notification => component.GetNotificationFunc(packet.Frame.Command)?.Name ?? packet.Frame.Command.ToString(),
                    MessageType.ErrorReply => component.GetCommandFunc(packet.Frame.Command)?.Name ?? packet.Frame.Command.ToString(),
                    _ => packet.Frame.Command.ToString()
                };
            }

            else
            {
                componentName = packet.Frame.Component.ToString();
                commandName = packet.Frame.Command.ToString();
            }

            int errorCode = Utilities.ToFullErrorCode(packet.Frame.ErrorCode, packet.Frame.Component);
            string errorStr;

            if (errorCode != 0)
                errorStr = $", ERR[{_router.GetErrorName(errorCode)} (0x{errorCode:X8})]";
            else
                errorStr = "";

            if (!logger.IsEnabled(LogLevel.Trace))
            {
                logger.LogDebug(format,
                    connection.Id, dir, 
                    getMsgTypeString(packet.Frame.MessageType), packet.Frame.MessageNum,
                    packet.Frame.UserIndex, componentName, commandName,
                    packet.Frame.Component, packet.Frame.Command,
                    errorStr, string.Empty);
                return;
            }

            string tdfStr;

            if(deserializedContent == null || deserializedContent is EmptyMessage)
                tdfStr = string.Empty;
            else
                tdfStr = $"{Environment.NewLine}{deserializedContent}";

            logger.LogTrace(format,
                connection.Id, dir,
                getMsgTypeString(packet.Frame.MessageType), packet.Frame.MessageNum,
                packet.Frame.UserIndex, componentName, commandName,
                packet.Frame.Component, packet.Frame.Command,
                errorStr, tdfStr);
        }

        private string getMsgTypeString(MessageType msgType)
        {
            return msgType switch
            {
                MessageType.Message => "req",
                MessageType.Reply => "resp",
                MessageType.Notification => "async",
                MessageType.ErrorReply => "err",
                MessageType.Ping => "ping",
                MessageType.PingReply => "prep",
                _ => "unk"
            };
        }
    }
}
