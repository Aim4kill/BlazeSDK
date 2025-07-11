using EATDF;

namespace Blaze.Core;

public interface IRpcCommandFunc
{
    ushort Id { get; }
    string Name { get; }
    bool IsSupported { get; }
    Tdf CreateRequestTdf();
    Tdf CreateResponseTdf();
    Tdf CreateErrorResponseTdf();
    Task<Tdf> InvokeAsync(Tdf request, BlazeRpcContext context);
}