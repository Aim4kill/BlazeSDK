using System.Collections.Concurrent;

namespace BlazeCommon
{
    public abstract class ProtoFireBasicClient
    {
        ProtoFireConnection Connection { get; }
        ConcurrentDictionary<uint, TaskCompletionSource<ProtoFirePacket>> awaitableReplies;

        public int RequestTimeout { get; set; }

        public ProtoFireBasicClient(ProtoFireConnection connection)
        {

            if (connection.Disconnected)
                throw new ArgumentException("The connection is disconnected.");

            awaitableReplies = new ConcurrentDictionary<uint, TaskCompletionSource<ProtoFirePacket>>();
            RequestTimeout = 15000;

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
                    case FireFrame.MessageType.ERROR_REPLY:
                        HandleReplyPacket(packet);
                        break;
                    default:
                        OnNonReplyPacketReceived(packet);
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
            return tcs.Task.GetAwaiter().GetResult();
        }

        public async Task<ProtoFirePacket> SendRequestAsync(ProtoFirePacket packet)
        {
            TaskCompletionSource<ProtoFirePacket> tcs = new TaskCompletionSource<ProtoFirePacket>();
            awaitableReplies.TryAdd(packet.Frame.MsgNum, tcs);
            await Connection.SendAsync(packet).ConfigureAwait(false);
            CancellationTokenSource cts = new CancellationTokenSource(RequestTimeout);
            cts.Token.Register(() => tcs.TrySetCanceled(), useSynchronizationContext: false);
            return await tcs.Task.ConfigureAwait(false);
        }

        public abstract void OnClientDisconnected();
        public abstract void OnNonReplyPacketReceived(ProtoFirePacket request);
    }
}
