using EATDF;

namespace Blaze.Core;

public class BlazeRpcException : Exception
{
    public ushort ErrorCode { get; }
    public Tdf? ErrorResponse { get; }

    public BlazeRpcException(ushort errorCode, Tdf? errorResponse)
    {
        ErrorCode = errorCode;
        ErrorResponse = errorResponse;
    }

    public BlazeRpcException(ushort errorCode, Tdf? errorResponse, string? message)
        : base(message)
    {
        ErrorCode = errorCode;
        ErrorResponse = errorResponse;
    }

    public BlazeRpcException(ushort errorCode, Tdf? errorResponse, string? message, Exception? innerException)
        : base(message, innerException)
    {
        ErrorCode = errorCode;
        ErrorResponse = errorResponse;
    }
}
