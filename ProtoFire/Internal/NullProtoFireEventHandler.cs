using ProtoFire.Tls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoFire.Internal;

internal class NullProtoFireEventHandler : IProtoFireHandler
{
    public Task OnAuthenticatedAsync(ProtoFireConnection connection, bool secure)
    {
        return Task.CompletedTask;
    }

    public Task<bool> OnConnectedAsync(ProtoFireConnection connection)
    {
        return Task.FromResult(true);
    }

    public Task OnDisconnectedAsync(ProtoFireConnection connection)
    {
        return Task.CompletedTask;
    }

    public Task OnErrorAsync(ProtoFireConnection connection, Exception exception)
    {
        Console.WriteLine(exception);
        return Task.CompletedTask;
    }

    public Task OnPacketReceivedAsync(ProtoFireConnection connection, ProtoFirePacket packet)
    {
        return Task.CompletedTask;
    }

    public Task OnPacketSentAsync(ProtoFireConnection connection, ProtoFirePacket packet)
    {
        return Task.CompletedTask;
    }

    public ProtoSSLCertificate? SelectCertificate(ProtoFireConnection connection)
    {
        return null;
    }
}
