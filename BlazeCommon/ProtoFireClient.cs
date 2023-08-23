using System.Collections.Concurrent;

namespace BlazeCommon
{
    public abstract class ProtoFireClient
    {
        public ProtoFireConnection Connection { get; }
        ConcurrentDictionary<uint, TaskCompletionSource<ProtoFirePacket>> awaitableReplies;

        public int RequestTimeout { get; set; }
        public PacketReceivedFilter Filter { get; set; }
        public ProtoFireClient(ProtoFireConnection connection, PacketReceivedFilter filter = PacketReceivedFilter.All)
        {

            if (connection.Disconnected)
                throw new ArgumentException("The connection is disconnected.");

            awaitableReplies = new ConcurrentDictionary<uint, TaskCompletionSource<ProtoFirePacket>>();
            RequestTimeout = 15000;
            Filter = filter;
            Connection = connection;
            _ = ReadPacket();
        }

        async Task ReadPacket()
        {
            while (!Connection.Disconnected)
            {
                ProtoFirePacket? packet = await Connection.ReadPacketAsync().ConfigureAwait(false);

                if (packet == null)
                {
                    OnClientDisconnected();
                    break;
                }

                switch (packet.Frame.MsgType)
                {
                    case FireFrame.MessageType.REPLY:
                        if (Filter.HasFlag(PacketReceivedFilter.Reply))
                            OnPacketReceived(packet);
                        HandleReplyPacket(packet);
                        break;
                    case FireFrame.MessageType.ERROR_REPLY:
                        if (Filter.HasFlag(PacketReceivedFilter.ErrorReply))
                            OnPacketReceived(packet);
                        HandleReplyPacket(packet);
                        break;
                    case FireFrame.MessageType.MESSAGE:
                        if (Filter.HasFlag(PacketReceivedFilter.Message))
                            OnPacketReceived(packet);
                        break;
                    case FireFrame.MessageType.NOTIFICATION:
                        if (Filter.HasFlag(PacketReceivedFilter.Notification))
                            OnPacketReceived(packet);
                        break;
                    default:
                        if (Filter.HasFlag(PacketReceivedFilter.Unknown))
                            OnPacketReceived(packet);
                        break;
                }
            }
        }

        void HandleReplyPacket(ProtoFirePacket reply)
        {
            if (awaitableReplies.TryRemove(reply.Frame.MsgNum, out TaskCompletionSource<ProtoFirePacket>? tcs))
                tcs.SetResult(reply);
        }


        public ProtoFirePacket SendRequest(ProtoFirePacket packet)
        {
            TaskCompletionSource<ProtoFirePacket> tcs = new TaskCompletionSource<ProtoFirePacket>();
            awaitableReplies.TryAdd(packet.Frame.MsgNum, tcs);
            Connection.Send(packet);
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
            awaitableReplies.TryAdd(packet.Frame.MsgNum, tcs);
            await Connection.SendAsync(packet).ConfigureAwait(false);
            CancellationTokenSource cts = new CancellationTokenSource(RequestTimeout);
            cts.Token.Register(() => tcs.TrySetCanceled(), useSynchronizationContext: false);
            try { return await tcs.Task.ConfigureAwait(false); }
            catch (TaskCanceledException)
            {
                throw new TimeoutException("The request timed out.");
            }

        }

        public abstract void OnClientDisconnected();
        public abstract void OnPacketReceived(ProtoFirePacket request);

    }

    [Flags]
    public enum PacketReceivedFilter
    {
        None = 0,
        Message = 1,
        Reply = 2,
        ErrorReply = 4,
        Notification = 8,
        Unknown = 16,
        All = Message | Reply | ErrorReply | Notification | Unknown
    }

}
