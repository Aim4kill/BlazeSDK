using EATDF;

namespace Blaze.Core;

public interface IRpcNotificationFunc
{
    ushort Id { get; }
    string Name { get; }
    bool IsSupported { get; }
    Tdf CreateNotificationTdf();
    Task InvokeAsync(Tdf notification, BlazeRpcContext context);
}
