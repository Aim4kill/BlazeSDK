
using ProtoFire.Tls;

namespace ProtoFire.Internal;

internal class ProtoFireServerEventDisconnectHelper(ProtoFireServer server, IProtoFireHandler baseHandler) : IProtoFireHandler
{
    public Task OnAuthenticatedAsync(ProtoFireConnection connection, bool secure) => baseHandler.OnAuthenticatedAsync(connection, secure);
    public Task<bool> OnConnectedAsync(ProtoFireConnection connection) => baseHandler.OnConnectedAsync(connection);
    public Task OnDisconnectedAsync(ProtoFireConnection connection)
    {
        server.OnDisconnected(connection);
        return baseHandler.OnDisconnectedAsync(connection);
    }
    public Task OnErrorAsync(ProtoFireConnection connection, Exception exception) => baseHandler.OnErrorAsync(connection, exception);
    public Task OnPacketReceivedAsync(ProtoFireConnection connection, ProtoFirePacket packet) => baseHandler.OnPacketReceivedAsync(connection, packet);
    public Task OnPacketSentAsync(ProtoFireConnection connection, ProtoFirePacket packet) => baseHandler.OnPacketSentAsync(connection, packet);
    public ProtoSSLCertificate? SelectCertificate(ProtoFireConnection connection) => baseHandler.SelectCertificate(connection);
}
