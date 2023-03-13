using Tdf;

namespace Blaze3SDK.Blaze.GameManager
{
    [TdfStruct]
    public struct IndirectMatchmakingSetupContext
    {
        /*
        
        Blaze::GameManager::IndirectMatchmakingSetupContext {
	        TdfInt(unsigned int) FIT = 0
	        TdfVector3 GRID
	        TdfInt(unsigned int) MAXF = 0
	        TdfInt(unsigned int) MSID = 0
	        TdfBool RPVC = 0
	        TdfEnum RSLT = 0 from (Blaze::TdfEnumMap*)44651432
	        TdfInt(unsigned int) USID = -1
        }

        struct Blaze::GameManager::IndirectMatchmakingSetupContext::TdfMemberInfoDefinition
        {
          Blaze::TdfMemberInfoInt mFitScoreDef;
          Blaze::TdfMemberInfo mUserGroupIdDef;
          Blaze::TdfMemberInfoInt mMaxPossibleFitScoreDef;
          Blaze::TdfMemberInfoInt mSessionIdDef;
          Blaze::TdfMemberInfoInt mRequiresClientVersionCheckDef;
          Blaze::TdfMemberInfoEnum mMatchmakingResultDef;
          Blaze::TdfMemberInfoInt mUserSessionIdDef;
        };

        struct __cppobj __declspec(align(4)) Blaze::GameManager::IndirectMatchmakingSetupContext : Blaze::Tdf
        {
          Blaze::BlazeObjectId mUserGroupId;
          unsigned int mUserSessionId;
          unsigned int mSessionId;
          Blaze::GameManager::MatchmakingResult mMatchmakingResult;
          unsigned int mFitScore;
          unsigned int mMaxPossibleFitScore;
          bool mRequiresClientVersionCheck;
        };


         */

        [TdfMember("FIT")]
        public uint mFitScore;

        [TdfMember("GRID")]
        public BlazeObjectId mUserGroupId;

        [TdfMember("MAXF")]
        public uint mMaxPossibleFitScore;

        [TdfMember("MSID")]
        public uint mSessionId;

        [TdfMember("RPVC")]
        public bool mRequiresClientVersionCheck;

        [TdfMember("RSLT")]
        public MatchmakingResult mMatchmakingResult;

        [TdfMember("USID")]
        public uint mUserSessionId;

    }
}