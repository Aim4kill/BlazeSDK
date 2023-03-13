using Tdf;

namespace Blaze3SDK.Blaze
{
    [TdfStruct]
    public struct ClientInfo
    {
        [TdfMember("BSDK")]
        public string mBlazeSDKVersion;

        [TdfMember("BTIM")]
        public string mBlazeSDKBuildDate;

        [TdfMember("CLNT")]
        public string mClientName;

        [TdfMember("CSKU")]
        public string mClientSkuId;

        [TdfMember("CVER")]
        public string mClientVersion;

        [TdfMember("DSDK")]
        public string mDirtySDKVersion;

        [TdfMember("ENV")]
        public string mEnvironment;

        [TdfMember("LOC")]
        public uint mClientLocale;

        [TdfMember("MAC")]
        public string mMacAddress;

        [TdfMember("PLAT")]
        public string mPlatform;
    }
}
