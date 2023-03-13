namespace BlazeCommon
{
    public abstract class ComponentData<CommandEnum, NotificationEnum, ErrorEnum> : IComponentData where CommandEnum : Enum where NotificationEnum : Enum where ErrorEnum : Enum
    {
        ushort _componentId;
        public ComponentData(ushort componentId)
        {
            _componentId = componentId;
        }

        public string GetCommandName(CommandEnum command) => command.ToString();
        public string GetCommandName(ushort commandId) => GetCommandName((CommandEnum)Enum.ToObject(typeof(CommandEnum), commandId));
        public abstract Type GetCommandRequestType(CommandEnum command);
        public Type GetCommandRequestType(ushort commandId) => GetCommandRequestType((CommandEnum)Enum.ToObject(typeof(CommandEnum), commandId));
        public abstract Type GetCommandResponseType(CommandEnum command);
        public Type GetCommandResponseType(ushort commandId) => GetCommandResponseType((CommandEnum)Enum.ToObject(typeof(CommandEnum), commandId));
        public abstract Type GetCommandErrorResponseType(CommandEnum command);
        public Type GetCommandErrorResponseType(ushort commandId) => GetCommandErrorResponseType((CommandEnum)Enum.ToObject(typeof(CommandEnum), commandId));



        public string GetNotificationName(NotificationEnum notification) => notification.ToString();
        public string GetNotificationName(ushort notificationId) => GetNotificationName((NotificationEnum)Enum.ToObject(typeof(NotificationEnum), notificationId));
        public abstract Type GetNotificationType(NotificationEnum notification);
        public Type GetNotificationType(ushort notificationId) => GetNotificationType((NotificationEnum)Enum.ToObject(typeof(NotificationEnum), notificationId));

        public string GetErrorName(ErrorEnum error) => error.ToString();
        public string GetErrorName(int error) => GetErrorName((ErrorEnum)Enum.ToObject(typeof(ErrorEnum), error));
        public string GetErrorName(ushort error) => GetErrorName(error << 16 | _componentId);

    }
}
