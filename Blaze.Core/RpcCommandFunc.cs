using EATDF;

namespace Blaze.Core;

public class RpcCommandFunc<TRequest, TResponse, TErrorResponse> : IRpcCommandFunc where TRequest : Tdf, new() where TResponse : Tdf, new() where TErrorResponse : Tdf, new()
{
    public required ushort Id { get; init; }
    public required string Name { get; init; }
    public required bool IsSupported { get; init; }
    public required Func<TRequest, BlazeRpcContext, Task<Tdf>> Func { get; init; }
    public TRequest CreateRequestStruct() => new TRequest();
    Tdf IRpcCommandFunc.CreateRequestTdf() => CreateRequestStruct();
    public TResponse CreateResponseStruct() => new TResponse();
    Tdf IRpcCommandFunc.CreateResponseTdf() => CreateResponseStruct();
    public TErrorResponse CreateErrorResponseStruct() => new TErrorResponse();
    Tdf IRpcCommandFunc.CreateErrorResponseTdf() => CreateErrorResponseStruct();
    public Task<Tdf> InvokeAsync(TRequest request, BlazeRpcContext context) => Func(request, context);
    public Task<Tdf> InvokeAsync(Tdf request, BlazeRpcContext context)
    {
        return InvokeAsync((TRequest)request, context);
    }
}