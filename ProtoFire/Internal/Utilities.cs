namespace ProtoFire.Internal;

internal static class Utilities
{
    public static void ValidateFrameType(FrameType frameType)
    {
        if (frameType == FrameType.FireFrame)
            return;

        if (frameType == FrameType.Fire2Frame)
            throw new NotSupportedException("Fire2Frame is not yet supported");

        throw new NotSupportedException("Unknown frame type");

    }


}
