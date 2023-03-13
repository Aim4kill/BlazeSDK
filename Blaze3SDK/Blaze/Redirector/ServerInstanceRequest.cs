using Tdf;

namespace Blaze3SDK.Blaze.Redirector
{
    [TdfStruct]
    public struct ServerInstanceRequest
    {
        [TdfMember("BSDK")]
        public string mBlazeSDKVersion;

        [TdfMember("BTIM")]
        public string mBlazeSDKBuildDate;

        [TdfMember("CLNT")]
        public string mClientName;

        [TdfMember("CLTP")]
        public ClientType mClientType;

        [TdfMember("CSKU")]
        public string mClientSkuId;

        [TdfMember("CVER")]
        public string mClientVersion;

        [TdfMember("DSDK")]
        public string mDirtySDKVersion;

        [TdfMember("ENV")]
        public string mEnvironment;

        [TdfMember("FPID")]
        public FirstPartyId mFirstPartyId;

        [TdfMember("LOC")]
        public uint mClientLocale;

        [TdfMember("NAME")]
        public string mName;

        [TdfMember("PLAT")]
        public string mPlatform;

        [TdfMember("PROF")]
        public string mConnectionProfile;

    }
}
