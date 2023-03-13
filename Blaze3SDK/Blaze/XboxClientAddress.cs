using Tdf;

namespace Blaze3SDK.Blaze
{
    [TdfStruct]
    public struct XboxClientAddress
    {
        /*
            unsigned __int64 mXuid;
            Blaze::TdfBlob mXnAddr;

            Blaze::TdfMemberInfo mXnAddrDef;
            Blaze::TdfMemberInfoInt64 mXuidDef;

        	TdfBlob XDDR
	        TdfInt(unsigned __int64) XUID = 0
         */

        [TdfMember("XDDR")]
        public byte[] mXnAddr;

        [TdfMember("XUID")]
        public ulong mXuid;
    }
}
