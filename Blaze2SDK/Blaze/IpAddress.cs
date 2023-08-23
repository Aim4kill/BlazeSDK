using Tdf;

namespace Blaze2SDK.Blaze
{
    [TdfStruct]
    public struct IpAddress
    {

        [TdfMember("IP")]
        public uint Ip;

        [TdfMember("PORT")]
        public ushort Port;

    }
}
