using Tdf;

namespace Blaze3SDK.Blaze.GameManager
{
    [TdfStruct]
    public struct ResetDedicatedServerSetupContext
    {
        //  unsigned int mJoinErr;
        //  TdfInt(unsigned int) ERR = 0

        [TdfMember("ERR")]
        public uint mJoinErr;
    }
}