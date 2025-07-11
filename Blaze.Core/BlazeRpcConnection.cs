using Blaze.Core.Internal;
using EATDF;
using EATDF.Serialization;
using ProtoFire;
using ProtoFire.Frames;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Blaze.Core;

public class BlazeRpcConnection(ProtoFireConnection baseConnection, ITdfSerializer serializer)
{
    private ProtoFireConnection _baseConnection { get; } = baseConnection;
    private ITdfSerializer _serializer { get; } = serializer;
    internal QueuedLock BusyLock { get; } = new QueuedLock();

    public EndPoint? RemoteEndPoint => _baseConnection.Socket.RemoteEndPoint;
    public EndPoint? LocalEndPoint => _baseConnection.Socket.LocalEndPoint;
    public bool Connected => _baseConnection.Connected;
    public Guid Id => _baseConnection.Id;
    public object? State { get; set; }


    public void EnqequeSend(Action<BlazePacket> configure)
    {
        ProtoFirePacket firePacket = createProtoFirePacket(configure);
        EnqequeSend(firePacket);
    }

    public bool Send(Action<BlazePacket> configure)
    {
        ProtoFirePacket firePacket = createProtoFirePacket(configure);
        return Send(firePacket);
    }

    public Task<bool> SendAsync(Action<BlazePacket> configure)
    {
        ProtoFirePacket firePacket = createProtoFirePacket(configure);
        return SendAsync(firePacket);
    }

    public void EnqequeSend(ProtoFirePacket packet)
    {
        // fire and forget
        _ = enqequeSend(packet);
    }

    public bool Send(ProtoFirePacket packet) => _baseConnection.Send(packet);
    public Task<bool> SendAsync(ProtoFirePacket packet) => _baseConnection.SendAsync(packet);
    public void Disconnect() => _baseConnection.Disconnect();

    private async Task enqequeSend(ProtoFirePacket packet)
    {
        await BusyLock.EnterAsync().ConfigureAwait(false);
        await SendAsync(packet).ConfigureAwait(false);
        BusyLock.Exit();
    }

    private ProtoFirePacket createProtoFirePacket(Action<BlazePacket> configure)
    {
        IFireFrame frame = _baseConnection.FrameType switch
        {
            FrameType.FireFrame => new FireFrame(),
            FrameType.Fire2Frame => throw new NotImplementedException("Fire2Frame not implemented"),
            _ => throw new InvalidOperationException("Invalid frame type")
        };

        BlazePacket packet = new BlazePacket()
        {
            Frame = frame
        };
        
        configure(packet);

        byte[] bytes;

        if (packet.Data == null)
            bytes = Array.Empty<byte>();
        else
            bytes = _serializer.Serialize(packet.Data);

        return new ProtoFirePacket(frame, bytes);
    }

    public override string ToString()
    {
        if (RemoteEndPoint != null)
            return $"[Remote Ip: {RemoteEndPoint}]";

        return $"[Conn Id: {Id}]";
    }
}
