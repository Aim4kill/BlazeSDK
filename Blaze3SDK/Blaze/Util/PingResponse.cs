using Tdf;

namespace Blaze3SDK.Blaze.Util
{
    [TdfStruct]
    public struct PingResponse
    {
        //[tag="stim"] uint32_t mServerTime;

        [TdfMember("STIM")]
        public uint mServerTime;
    }
}
