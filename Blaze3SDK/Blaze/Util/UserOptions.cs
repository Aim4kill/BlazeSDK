using Tdf;

namespace Blaze3SDK.Blaze.Util
{
    [TdfStruct]
    public struct UserOptions
    {
        /*
        	TdfEnum TMOP = 0 from (Blaze::TdfEnumMap*)44651864
	        TdfInt(__int64) UID = 0
        
            Blaze::Util::TelemetryOpt mTelemetryOpt;
            __int64 mUserId;

            Blaze::TdfMemberInfoEnum mTelemetryOptDef;
            Blaze::TdfMemberInfoInt64 mUserIdDef;
        
         */

        [TdfMember("TMOP")]
        public TelemetryOpt mTelemetryOpt;

        [TdfMember("UID")]
        public long mUserId;

    }
}
