using ProtoFire.Frames;
using ProtoFire.Tls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoFire.Internal;

internal class ProtoFireClientEventHandler(ProtoFireClient client, IProtoFireHandler userHandler) : IProtoFireHandler
{
    public Task OnAuthenticatedAsync(ProtoFireConnection connection, bool secure) => userHandler.OnAuthenticatedAsync(connection, secure);
    public Task<bool> OnConnectedAsync(ProtoFireConnection connection) => userHandler.OnConnectedAsync(connection);
    public Task OnDisconnectedAsync(ProtoFireConnection connection) => userHandler.OnDisconnectedAsync(connection);
    public Task OnErrorAsync(ProtoFireConnection connection, Exception exception) => userHandler.OnErrorAsync(connection, exception);
    public Task OnPacketSentAsync(ProtoFireConnection connection, ProtoFirePacket packet) => userHandler.OnPacketSentAsync(connection, packet);
    public Task OnPacketReceivedAsync(ProtoFireConnection connection, ProtoFirePacket packet)
    {
        IFireFrame frame = packet.Frame;

        if (frame.MessageType == MessageType.Reply || frame.MessageType == MessageType.ErrorReply)
        {
            if (client.replyTasks.TryRemove(packet.Frame.MessageNum, out TaskCompletionSource<ProtoFirePacket>? tcs))
                tcs.SetResult(packet);
        }

        return userHandler.OnPacketReceivedAsync(connection, packet);
    }

    public ProtoSSLCertificate? SelectCertificate(ProtoFireConnection connection) => userHandler.SelectCertificate(connection);
}
