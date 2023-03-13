namespace Blaze3SDK.Extensions
{
    internal static class StreamExtensions
    {

        public static void WriteBool(this Stream stream, bool value)
        {
            stream.WriteByte((byte)(value ? 1 : 0));
        }

        public static void WriteInt(this Stream stream, long value)
        {
            if (value != 0)
            {
                byte curByte;

                //calculate the first byte
                if (value >= 0)
                    curByte = (byte)(value & 0x3F | 0x80); //set first six bits + pos sign bit (0) + and next bit (1)
                else
                {
                    value = -value;
                    curByte = (byte)(value & 0x3F | 0xC0); //set first six bits + neg sign bit (1) + and next bit (1)
                }

                for (long i = value >> 6; i > 0; i >>= 7)
                {
                    stream.WriteByte(curByte);
                    curByte = (byte)(i | 0x80);
                }

                stream.WriteByte((byte)(curByte & 0x7F)); //change next bit to 0

            }
            else
                stream.WriteByte(0x00);
        }

        public static long ReadInt(this Stream stream)
        {
            long b, value = (byte)stream.ReadByte();
            byte i = 6;

            bool negative = (value & 0x40) != 0;
            bool readNext = (value & 0x80) != 0;
            value &= 0x3F;

            while (readNext)
            {
                b = (byte)stream.ReadByte();
                value |= (b & 0x7F) << i;
                i += 7;

                readNext = b >> 7 != 0;
            }

            if (negative)
                return -value;
            return value;
        }

    }
}

