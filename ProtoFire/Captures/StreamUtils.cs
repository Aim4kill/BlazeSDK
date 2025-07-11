using Org.BouncyCastle.Bcpg;
using ProtoFire.Frames;
using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ProtoFire.Captures;

internal static class StreamUtils
{
    //public static bool WritePresent(Stream stream, object? obj)
    //{
    //    if (obj != null)
    //    {
    //        stream.WriteByte(1);
    //        return true;
    //    }

    //    stream.WriteByte(0);
    //    return false;
    //}

    //public static bool ReadPresent(Stream stream)
    //{
    //    int b = stream.ReadByte();
    //    if (b == -1)
    //        throw new EndOfStreamException();
    //    return b != 0;
    //}


    public static void WriteTimestamp(Stream stream, DateTime timestamp)
    {
        //convert time to utc if not already
        DateTime utcTime = timestamp.Kind == DateTimeKind.Utc ? timestamp : timestamp.ToUniversalTime();
        long unixTimestamp = new DateTimeOffset(utcTime).ToUnixTimeMilliseconds();

        Span<byte> bytes = stackalloc byte[8];
        BinaryPrimitives.WriteInt64BigEndian(bytes, unixTimestamp);
        stream.Write(bytes);
    }
    public static DateTime ReadTimestamp(Stream stream)
    {
        Span<byte> bytes = stackalloc byte[8];
        stream.ReadExactly(bytes);
        long unixTimestamp = BinaryPrimitives.ReadInt64BigEndian(bytes);
        return DateTimeOffset.FromUnixTimeMilliseconds(unixTimestamp).UtcDateTime;
    }

    public static void WriteString(Stream stream, string value)
    {
        byte[] bytes = Encoding.UTF8.GetBytes(value);
        WriteInt(stream, bytes.Length);
        stream.Write(bytes);
    }

    public static void WriteInt(Stream stream, int value)
    {
        Span<byte> bytes = stackalloc byte[4];
        BinaryPrimitives.WriteInt32BigEndian(bytes, value);
        stream.Write(bytes);
    }

    public static void WriteBytes(Stream stream, byte[] bytes)
    {
        WriteInt(stream, bytes.Length);
        stream.Write(bytes);
    }

    public static void WriteIPEndPoint(Stream stream, IPEndPoint endPoint)
    {
        WriteString(stream, endPoint.Address.ToString());
        WriteInt(stream, endPoint.Port);
    }

    public static IPEndPoint ReadIPEndPoint(Stream stream)
    {
        string address = ReadString(stream);
        int port = ReadInt(stream);
        return new IPEndPoint(IPAddress.Parse(address), port);
    }



    public static string ReadString(Stream stream)
    {
        int length = ReadInt(stream);
        byte[] bytes = new byte[length];
        stream.ReadExactly(bytes, 0, length);
        return Encoding.UTF8.GetString(bytes);
    }

    public static int ReadInt(Stream stream)
    {
        Span<byte> bytes = stackalloc byte[4];
        stream.ReadExactly(bytes);
        return BinaryPrimitives.ReadInt32BigEndian(bytes);
    }

    public static byte[] ReadBytes(Stream stream)
    {
        int length = ReadInt(stream);
        byte[] bytes = new byte[length];
        stream.ReadExactly(bytes, 0, length);
        return bytes;
    }

    internal static void WriteBool(Stream stream, bool inbound)
    {
        if (inbound)
            stream.WriteByte(1);
        else
            stream.WriteByte(0);
    }

    internal static bool ReadBool(Stream stream)
    {
        int b = stream.ReadByte();
        if (b == -1)
            throw new EndOfStreamException();
        return b != 0;
    }

    internal static void WritePacket(Stream stream, ProtoFirePacket packet)
    {
        WriteInt(stream, (int)packet.Frame.Type);

        MemoryStream ms = new MemoryStream();
        packet.WriteTo(ms);
        byte[] bytes = ms.ToArray();
        WriteBytes(stream, bytes);
    }

    internal static ProtoFirePacket ReadPacket(Stream stream)
    {
        FrameType frameType = (FrameType)ReadInt(stream);
        byte[] bytes = ReadBytes(stream);
        MemoryStream ms = new MemoryStream(bytes);

        switch (frameType)
        {
            case FrameType.FireFrame:
                return ProtoFirePacket.ReadFrom<FireFrame>(ms)!;
            default:
                throw new NotSupportedException($"Unknown or unsupported frame type: {frameType}");
        }

    }
}
