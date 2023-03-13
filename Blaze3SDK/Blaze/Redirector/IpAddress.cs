using Tdf;
using System.Net;

namespace Blaze3SDK.Blaze.Redirector
{
    [TdfStruct]
    public struct IpAddress
    {
        [TdfMember("HOST")]
        public string mHostname;

        [TdfMember("IP")]
        public uint mIp;

        [TdfMember("PORT")]
        public ushort mPort;

        public IpAddress()
        {
            mHostname = string.Empty;
            mIp = 0;
            mPort = 0;
        }

        public static implicit operator IpAddress?(ServerAddress serverAddress)
        {
            return serverAddress.IpAddress;
        }

        public IpAddress(string hostname, uint ipAddress, ushort port)
        {
            mHostname = hostname;
            mIp = ipAddress;
            mPort = port;
        }

        public IpAddress(string hostname, string ipAddress, ushort port)
        {
            mHostname = hostname;
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
    }
}
