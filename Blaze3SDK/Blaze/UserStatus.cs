using Tdf;

namespace Blaze3SDK.Blaze
{
    [TdfStruct]
    public struct UserStatus
    {
        /*
        	TdfBitSet FLGS
	        TdfInt(__int64) ID = 0

            __int64 mBlazeId;
            Blaze::UserDataFlags mStatusFlags;
        
        */

        [TdfMember("FLGS")]
        public UserDataFlags mStatusFlags;

        [TdfMember("ID")]
        public long mBlazeId;

    }
}
