using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace BlazeCommon
{
    public abstract class BlazeComponent<CommandEnum, NotificationEnum, ErrorEnum> : IBlazeComponent where CommandEnum : Enum where NotificationEnum : Enum where ErrorEnum : Enum
    {
        Dictionary<ushort, BlazeCommandInfo> _commands;

        public ushort Id { get; }
        public string Name { get; }
        public BlazeComponent(ushort componentId, string componentName)
        {
            Id = componentId;
            Name = componentName;
            InitializeComponent();
        }

        [MemberNotNull(nameof(_commands))]
        void InitializeComponent()
        {
            _commands = new Dictionary<ushort, BlazeCommandInfo>();

            Type componentType = GetType();

            MethodInfo[] methods = componentType.GetMethods();

            foreach (MethodInfo method in methods)
            {
                BlazeCommand? commandAttr = method.GetCustomAttribute<BlazeCommand>();
                if (commandAttr == null)
                    continue;

                ushort commandId = commandAttr.Id;
                if (_commands.ContainsKey(commandId))
                    throw new InvalidOperationException($"Blaze command {commandId} seen more than once for component {Id}");

                Type fullReturnType = method.ReturnType;
                //we need to check if it is Task<Response>
                if (!fullReturnType.IsGenericType)
                    continue;
                if (fullReturnType.GetGenericTypeDefinition() != typeof(Task<>))
                    continue;

                Type responseType = fullReturnType.GetGenericArguments()[0];

                Type[] parameterTypes = method.GetParameters().Select(x => x.ParameterType).ToArray();
                if (parameterTypes.Length != 2)
                    continue;

                if (parameterTypes[1] != typeof(BlazeRpcContext))
                    continue;

                Type requestType = parameterTypes[0];


                BlazeCommandInfo commandInfo = new BlazeCommandInfo(this, commandId, requestType, responseType, method);
                _commands.Add(commandId, commandInfo);
            }
        }

        public BlazeCommandInfo? GetBlazeCommandInfo(ushort commandId)
        {
            _commands.TryGetValue(commandId, out BlazeCommandInfo? commandInfo);
            return commandInfo;
        }


        public string GetCommandName(CommandEnum command) => command.ToString();
        public string GetCommandName(ushort commandId) => GetCommandName((CommandEnum)Enum.ToObject(typeof(CommandEnum), commandId));
        public string GetNotificationName(NotificationEnum notification) => notification.ToString();
        public string GetNotificationName(ushort notificationId) => GetNotificationName((NotificationEnum)Enum.ToObject(typeof(NotificationEnum), notificationId));
        public string GetErrorName(ErrorEnum error) => error.ToString();
        public string GetErrorName(int fullErrorCode) => GetErrorName((ErrorEnum)Enum.ToObject(typeof(ErrorEnum), fullErrorCode));
        public string GetErrorName(ushort shortErrorCode) => throw new NotImplementedException();

        public abstract Type GetCommandRequestType(CommandEnum command);
        public abstract Type GetCommandResponseType(CommandEnum command);
        public abstract Type GetCommandErrorResponseType(CommandEnum command);
        public abstract Type GetNotificationType(NotificationEnum notification);

        public Type GetCommandRequestType(ushort commandId) => GetCommandRequestType((CommandEnum)Enum.ToObject(typeof(CommandEnum), commandId));
        public Type GetCommandResponseType(ushort commandId) => GetCommandResponseType((CommandEnum)Enum.ToObject(typeof(CommandEnum), commandId));
        public Type GetCommandErrorResponseType(ushort commandId) => GetCommandErrorResponseType((CommandEnum)Enum.ToObject(typeof(CommandEnum), commandId));
        public Type GetNotificationType(ushort notificationId) => GetNotificationType((NotificationEnum)Enum.ToObject(typeof(NotificationEnum), notificationId));

        public string GetFullName(FireFrame frame)
        {
            if (frame.Component != Id)
                throw new ArgumentException($"Frame component {frame.Component} does not match this component {Id}");

            string commandOrNotificationName;
            switch (frame.MsgType)
            {
                case FireFrame.MessageType.MESSAGE:
                case FireFrame.MessageType.REPLY:
                case FireFrame.MessageType.ERROR_REPLY:
                    commandOrNotificationName = GetCommandName(frame.Command);
                    break;
                case FireFrame.MessageType.NOTIFICATION:
                    commandOrNotificationName = GetNotificationName(frame.Command);
                    break;
                default:
                    commandOrNotificationName = frame.Command.ToString();
                    break;
            }

            return $"{Name}::{commandOrNotificationName}";
        }

    }
}
