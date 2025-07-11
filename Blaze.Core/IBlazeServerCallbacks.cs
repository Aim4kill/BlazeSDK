using EATDF;
using EATDF.Visitors;
using ProtoFire;
using ProtoFire.Tls;

namespace Blaze.Core;

public interface IBlazeServerCallbacks
{
    Task<bool> OnConnectedAsync(BlazeRpcConnection connection);
    ProtoSSLCertificate? SelectCertificate(BlazeRpcConnection connection);
    Task OnAuthenticatedAsync(BlazeRpcConnection connection, bool secure);
    Task OnDisconnectedAsync(BlazeRpcConnection connection);
    Task OnErrorAsync(BlazeRpcConnection connection, Exception exception);
    Task OnRpcCommandErrorAsync(BlazeRpcConnection connection, ProtoFirePacket packet, Tdf request, Exception exception);
    Task OnUnhandledAsync(BlazeRpcConnection connection, ProtoFirePacket packet, bool corrupted);
}
