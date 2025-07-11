using ProtoFire.Internal;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ProtoFire;

public class ProtoFireClient
{
    private uint _nextReqNum;
    internal ConcurrentDictionary<uint, TaskCompletionSource<ProtoFirePacket>> replyTasks;
    public ProtoFireConnection Connection { get; private set; }
    public int RequestTimeout { get; set; }

    private ProtoFireClient(Socket socket, FrameType frameType, bool secure) : this(socket, new NullProtoFireEventHandler(), frameType, secure)
    {

    }

    private ProtoFireClient(Socket socket, IProtoFireHandler eventHandler, FrameType frameType, bool secure)
    {
        _nextReqNum = 0;
        replyTasks = new ConcurrentDictionary<uint, TaskCompletionSource<ProtoFirePacket>>();
        RequestTimeout = 15000;
        eventHandler = new ProtoFireClientEventHandler(this, eventHandler);
        Connection = new ProtoFireConnection(socket, eventHandler, frameType);
        _ = Connection.ProcessAsync(false, secure);
    }


    public uint GetNextMsgNum()
    {
        return Interlocked.Increment(ref _nextReqNum);
    }

    public ProtoFirePacket SendRequest(ProtoFirePacket packet)
    {
        TaskCompletionSource<ProtoFirePacket> tcs = new TaskCompletionSource<ProtoFirePacket>();
        replyTasks.TryAdd(packet.Frame.MessageNum, tcs);

        if (!Connection.Send(packet))
        {
            replyTasks.TryRemove(packet.Frame.MessageNum, out _);
            throw new IOException("Failed to send ProtoFire packet.");
        }

        CancellationTokenSource cts = new CancellationTokenSource(RequestTimeout);
        cts.Token.Register(() => tcs.TrySetCanceled(), useSynchronizationContext: false);
        try { return tcs.Task.GetAwaiter().GetResult(); }
        catch (TaskCanceledException)
        {
            throw new TimeoutException("The request timed out.");
        }

    }

    public async Task<ProtoFirePacket> SendRequestAsync(ProtoFirePacket packet)
    {
        TaskCompletionSource<ProtoFirePacket> tcs = new TaskCompletionSource<ProtoFirePacket>();
        replyTasks.TryAdd(packet.Frame.MessageNum, tcs);

        if (!await Connection.SendAsync(packet).ConfigureAwait(false))
        {
            replyTasks.TryRemove(packet.Frame.MessageNum, out _);
            throw new IOException("Failed to send ProtoFire packet.");
        }

        CancellationTokenSource cts = new CancellationTokenSource(RequestTimeout);
        cts.Token.Register(() => tcs.TrySetCanceled(), useSynchronizationContext: false);
        try { return await tcs.Task.ConfigureAwait(false); }
        catch (TaskCanceledException)
        {
            throw new TimeoutException("The request timed out.");
        }
    }

    public static ProtoFireClient Connect(string host, int port, bool secure, IProtoFireHandler eventHandler, FrameType frameType)
    {
        Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        socket.Connect(host, port);
        return new ProtoFireClient(socket, eventHandler, frameType, secure);
    }

    public static async Task<ProtoFireClient> ConnectAsync(string host, int port, bool secure, IProtoFireHandler eventHandler, FrameType frameType)
    {
        Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        await socket.ConnectAsync(host, port).ConfigureAwait(false);
        return new ProtoFireClient(socket, eventHandler, frameType, secure);
    }

    public static ProtoFireClient Connect(string host, int port, bool secure, FrameType frameType)
    {
        Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        socket.Connect(host, port);
        return new ProtoFireClient(socket, frameType, secure);
    }

    public static async Task<ProtoFireClient> ConnectAsync(string host, int port, bool secure, FrameType frameType)
    {
        Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        await socket.ConnectAsync(host, port).ConfigureAwait(false);
        return new ProtoFireClient(socket, frameType, secure);
    }

}
