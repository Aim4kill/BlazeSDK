using Tdf;

namespace Blaze3SDK.Blaze
{
    [TdfStruct]
    public struct UpdateHardwareFlagsRequest
    {
        //TdfBitSet HWFG
        //Blaze::HardwareFlags mHardwareFlags;

        [TdfMember("HWFG")]
        public HardwareFlags mHardwareFlags;
    }
}
