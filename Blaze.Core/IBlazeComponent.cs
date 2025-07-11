namespace Blaze.Core;

public interface IBlazeComponent
{
    ushort Id { get; }
    string Name { get; }
    string GetErrorName(ushort errorCode);
    IRpcCommandFunc? GetCommandFunc(ushort commandId);
    IRpcNotificationFunc? GetNotificationFunc(ushort notificationId);
}
