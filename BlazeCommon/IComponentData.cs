namespace BlazeCommon
{
    public interface IComponentData
    {
        public string GetCommandName(ushort commandId);
        public string GetNotificationName(ushort notificationId);
        public Type GetCommandRequestType(ushort commandId);
        public Type GetCommandResponseType(ushort commandId);
        public Type GetCommandErrorResponseType(ushort commandId);
        public Type GetNotificationType(ushort notificationId);
        public string GetErrorName(int error);
    }
}