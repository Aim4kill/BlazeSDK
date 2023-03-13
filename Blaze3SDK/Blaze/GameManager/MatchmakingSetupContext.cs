using Tdf;

namespace Blaze3SDK.Blaze.GameManager
{
    [TdfStruct]
    public struct MatchmakingSetupContext
    {
        /*
        
        Blaze::GameManager::MatchmakingSetupContext {
	        TdfInt(unsigned int) FIT = 0
	        TdfInt(unsigned int) MAXF = 0
	        TdfInt(unsigned int) MSID = 0
	        TdfEnum RSLT = 0 from (Blaze::TdfEnumMap*)44651432
	        TdfInt(unsigned int) USID = -1
        }

        struct Blaze::GameManager::MatchmakingSetupContext::TdfMemberInfoDefinition
        {
          Blaze::TdfMemberInfoInt mFitScoreDef;
          Blaze::TdfMemberInfoInt mMaxPossibleFitScoreDef;
          Blaze::TdfMemberInfoInt mSessionIdDef;
          Blaze::TdfMemberInfoEnum mMatchmakingResultDef;
          Blaze::TdfMemberInfoInt mUserSessionIdDef;
        };


        struct __cppobj Blaze::GameManager::MatchmakingSetupContext : Blaze::Tdf
        {
          unsigned int mUserSessionId;
          unsigned int mSessionId;
          Blaze::GameManager::MatchmakingResult mMatchmakingResult;
          unsigned int mFitScore;
          unsigned int mMaxPossibleFitScore;
        };

         */

        [TdfMember("FIT")]
        public uint mFitScore;

        [TdfMember("MAXF")]
        public uint mMaxPossibleFitScore;

        [TdfMember("MSID")]
        public uint mSessionId;

        [TdfMember("RSLT")]
        public MatchmakingResult mMatchmakingResult;

        [TdfMember("USID")]
        public uint mUserSessionId;
    }
}