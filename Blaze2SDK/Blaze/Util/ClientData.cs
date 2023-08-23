using Tdf;

namespace Blaze2SDK.Blaze.Util
{
    [TdfStruct]
    public struct ClientData
    {
        
        [TdfMember("LANG")]
        public uint mLocale;
        
        [TdfMember("TYPE")]
        public ClientType mClientType;
        
    }
}
