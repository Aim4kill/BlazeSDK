namespace Blaze.Core;

public class BlazeRpcContext
{
    public required BlazeRpcConnection Connection { get; init; }
    public object? State => Connection.State;
    public required ushort ErrorCode { get; init; }
    public required uint MessageNum { get; init; }
    public required byte UserIndex { get; init; }
    public required ulong Context { get; init; }
}
