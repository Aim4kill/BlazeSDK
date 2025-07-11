using EATDF;

namespace Blaze.Core;

public class RpcNotificationFunc<TNotification> : IRpcNotificationFunc where TNotification : Tdf, new()
{
    public required ushort Id { get; init; }
    public required string Name { get; init; }
    public required bool IsSupported { get; init; }
    public required Func<TNotification, BlazeRpcContext, Task> Func { get; init; }
    public TNotification CreateNotificationStruct() => new TNotification();
    Tdf IRpcNotificationFunc.CreateNotificationTdf() => CreateNotificationStruct();
    public Task InvokeAsync(TNotification notification, BlazeRpcContext context) => Func(notification, context);
    public Task InvokeAsync(Tdf notification, BlazeRpcContext context)
    {
        return InvokeAsync((TNotification)notification, context);
    }

}
