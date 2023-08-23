using Tdf;

namespace Blaze2SDK.Blaze.Util
{
    [TdfStruct]
    public struct PingResponse
    {
        
        [TdfMember("STIM")]
        public uint mServerTime;
        
    }
}
