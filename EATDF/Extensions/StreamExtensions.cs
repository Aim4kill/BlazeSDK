namespace EATDF.Extensions;

internal static class StreamExtensions
{
    public static bool ReadAll(this Stream stream, Span<byte> buffer)
    {
        int read;
        while (buffer.Length > 0)
        {
            read = stream.Read(buffer);
            if (read == 0)
                return false;
            buffer = buffer.Slice(read);
        }
        return true;
    }


}
