using EATDF;
using ProtoFire;
using ProtoFire.Tls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blaze.Core.Internal;

internal class DefaultServerCallbacks : IBlazeServerCallbacks
{
    public Task OnAuthenticatedAsync(BlazeRpcConnection connection, bool secure)
    {
        return Task.CompletedTask;
    }

    public Task<bool> OnConnectedAsync(BlazeRpcConnection connection)
    {
        return Task.FromResult(true);
    }

    public Task OnDisconnectedAsync(BlazeRpcConnection connection)
    {
        return Task.CompletedTask;
    }

    public Task OnErrorAsync(BlazeRpcConnection connection, Exception exception)
    {
        return Task.CompletedTask;
    }

    public Task OnRpcCommandErrorAsync(BlazeRpcConnection connection, ProtoFirePacket packet, Tdf request, Exception exception)
    {
        return Task.CompletedTask;
    }

    public Task OnUnhandledAsync(BlazeRpcConnection connection, ProtoFirePacket packet, bool corrupted)
    {
        return Task.CompletedTask;
    }

    public ProtoSSLCertificate? SelectCertificate(BlazeRpcConnection connection)
    {
        return null;
    }
}
