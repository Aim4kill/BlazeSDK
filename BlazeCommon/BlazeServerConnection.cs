namespace BlazeCommon
{
    public class BlazeServerConnection
    {
        /// <summary>
        ///    Lock to see if the blaze server is busy with answering the request, useful when you want to send a notification after the request is answered (not during it)
        /// </summary>
        public SemaphoreSlim IsBusyLock { get; }

        public ProtoFireConnection ProtoFireConnection { get; }
        public BlazeServerConfiguration ServerConfiguration { get; }
        public object State { get; set; }

        public BlazeServerConnection(ProtoFireConnection connection, BlazeServerConfiguration serverConfiguration)
        {
            ProtoFireConnection = connection;
            State = new object();
            ServerConfiguration = serverConfiguration;
            IsBusyLock = new SemaphoreSlim(1, 1);
        }

        public Task NotifyAsync(ushort componentId, ushort notificationId, object notification)
        {
            IBlazeComponent? component = ServerConfiguration.GetComponent(componentId);
            FireFrame frame = new FireFrame()
            {
                Component = componentId,
                Command = notificationId,
                ErrorCode = 0,
                MsgNum = 0,
                MsgType = FireFrame.MessageType.NOTIFICATION
            };

            Type fullType = typeof(BlazePacket<>).MakeGenericType(notification.GetType());
            IBlazePacket packet = (IBlazePacket)Activator.CreateInstance(fullType, frame, notification)!;
            Utils.LogPacket(component, packet, false);
            ProtoFirePacket protoFirePacket = packet.ToProtoFirePacket(ServerConfiguration.Encoder);
            return ProtoFireConnection.SendAsync(protoFirePacket);
        }
    }
}
