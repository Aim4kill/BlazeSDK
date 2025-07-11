using ProtoFire.Tls;

namespace ProtoFire.Internal;

internal class ProtoFireEventHandlerTryWrapper(IProtoFireHandler baseHandler) : IProtoFireHandler
{
    public async Task<bool> OnConnectedAsync(ProtoFireConnection connection)
    {
        try { return await baseHandler.OnConnectedAsync(connection); }
        catch (Exception ex) { await OnErrorAsync(connection, ex); return false; }
    }

    public async Task OnAuthenticatedAsync(ProtoFireConnection connection, bool secure)
    {
        try { await baseHandler.OnAuthenticatedAsync(connection, secure); }
        catch (Exception ex) { await OnErrorAsync(connection, ex); }
    }

    public async Task OnDisconnectedAsync(ProtoFireConnection connection)
    {
        try { await baseHandler.OnDisconnectedAsync(connection); }
        catch (Exception ex) { await OnErrorAsync(connection, ex); }
    }

    public async Task OnErrorAsync(ProtoFireConnection connection, Exception ex)
    {
        try { await baseHandler.OnErrorAsync(connection, ex); }
        catch
        {
            // Ignoring this, because this might cause a stack overflow if the error handler throws an error
        }
    }

    public async Task OnPacketReceivedAsync(ProtoFireConnection connection, ProtoFirePacket packet)
    {
        try { await baseHandler.OnPacketReceivedAsync(connection, packet); }
        catch (Exception ex) { await OnErrorAsync(connection, ex); }
    }

    public async Task OnPacketSentAsync(ProtoFireConnection connection, ProtoFirePacket packet)
    {
        try { await baseHandler.OnPacketSentAsync(connection, packet); }
        catch (Exception ex) { await OnErrorAsync(connection, ex); }
    }

    public ProtoSSLCertificate? SelectCertificate(ProtoFireConnection connection)
    {
        try { return baseHandler.SelectCertificate(connection); }
        catch (Exception ex) { _ = OnErrorAsync(connection, ex); return null; }
    }
}
