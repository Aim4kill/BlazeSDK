using NLog;
using System.Net;
using System.Text;

namespace BlazeCommon
{
    public static class BlazeUtils
    {
        private static Logger _logger = LogManager.GetCurrentClassLogger();

        internal static void LogPacket(IBlazeComponent? component, IBlazePacket packet, bool inbound)
        {
            if (component == null)
            {
                _logger.Warn(packet.Frame.ToString(inbound));
                return;
            }

            if (_logger.IsDebugEnabled)
                _logger.Debug(packet.ToString(component, inbound));
            else
                _logger.Info(packet.Frame.ToString(component, inbound));
        }

        public static IPAddress ToIpAddress(uint ip)
        {
            byte[] bytes = BitConverter.GetBytes(ip);
            if (BitConverter.IsLittleEndian)
                Array.Reverse(bytes);
            return new IPAddress(bytes);
        }

        public static string ToLocaleString(uint locale)
        {
            byte[] bytes = BitConverter.GetBytes(locale);
            if (BitConverter.IsLittleEndian)
                Array.Reverse(bytes);
            return Encoding.ASCII.GetString(bytes);
        }

        public static DateTime DateTimeFromUnixSeconds(long seconds)
        {
            DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(seconds);
            return dateTimeOffset.UtcDateTime;
        }

        public static long DateTimeToUnixSeconds(DateTime dateTime)
        {
            DateTimeOffset dateTimeOffset = new DateTimeOffset(dateTime);
            return dateTimeOffset.ToUnixTimeSeconds();
        }

        public static DateTime DateTimeFromUnixMilliseconds(long milliseconds)
        {
            DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeMilliseconds(milliseconds);
            return dateTimeOffset.UtcDateTime;
        }

        public static long DateTimeToUnixMilliseconds(DateTime dateTime)
        {
            DateTimeOffset dateTimeOffset = new DateTimeOffset(dateTime);
            return dateTimeOffset.ToUnixTimeMilliseconds();
        }

        public static DateTime DateTimeFromUnixMicroseconds(long microseconds)
        {
            DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeMilliseconds(microseconds / 1000);
            return dateTimeOffset.UtcDateTime;
        }
        public static long DateTimeToUnixMicroseconds(DateTime dateTime)
        {
            DateTimeOffset dateTimeOffset = new DateTimeOffset(dateTime);
            return dateTimeOffset.ToUnixTimeMilliseconds() * 1000;
        }

    }
}
