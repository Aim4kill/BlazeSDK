using Tdf;
using System.Net;

namespace Blaze3SDK.Blaze
{
    [TdfStruct]
    public struct IpAddress
    {
        [TdfMember("IP")]
        public uint mIp;

        [TdfMember("PORT")]
        public ushort mPort;

        public IpAddress()
        {
            mIp = 0;
            mPort = 0;
        }
        public IpAddress(uint ipAddress, ushort port)
        {
            mIp = ipAddress;
            mPort = port;
        }

        public IpAddress(string ipAddress, ushort port)
        {
            mIp = GetIPAddressAsUInt(ipAddress);
            mPort = port;
        }

        public static uint GetIPAddressAsUInt(string ipAddress)
        {
            if (ipAddress == null)
                throw new ArgumentNullException(nameof(ipAddress));

            IPAddress address = IPAddress.Parse(ipAddress);
            byte[] bytes = address.GetAddressBytes();
            if (BitConverter.IsLittleEndian)
                Array.Reverse(bytes);
            return BitConverter.ToUInt32(bytes, 0);
        }

        public static string GetIPAddressAsString(uint ipAddress)
        {
            byte[] bytes = BitConverter.GetBytes(ipAddress);
            if (BitConverter.IsLittleEndian)
                Array.Reverse(bytes);
            return new IPAddress(bytes).ToString();
        }
    }
}
