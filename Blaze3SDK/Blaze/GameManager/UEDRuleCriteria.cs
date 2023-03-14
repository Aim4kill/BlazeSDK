using Tdf;

namespace Blaze3SDK.Blaze.GameManager
{
    [TdfStruct]
    public struct UEDRuleCriteria
    {
        /*
        
        Blaze::GameManager::UEDRuleCriteria {
	        TdfInt(__int64) CVAL = 128
	        TdfString NAME = (const char*)37007354
	        TdfInt(__int64) OVAL = 128
	        TdfString THLD = (const char*)37007354
        }

        struct Blaze::GameManager::UEDRuleCriteria::TdfMemberInfoDefinition
        {
          Blaze::TdfMemberInfoInt64 mClientUEDSearchValueDef;
          Blaze::TdfMemberInfoString mRuleNameDef;
          Blaze::TdfMemberInfoInt64 mOverrideUEDValueDef;
          Blaze::TdfMemberInfoString mThresholdNameDef;
        };

        struct __cppobj Blaze::GameManager::UEDRuleCriteria : Blaze::Tdf
        {
          Blaze::TdfString mRuleName;
          Blaze::TdfString mThresholdName;
          __int64 mClientUEDSearchValue;
          __int64 mOverrideUEDValue;
        };

         */

        [TdfMember("CVAL")]
        public long mClientUEDSearchValue;

        [TdfMember("NAME")]
        public string mRuleName;

        [TdfMember("OVAL")]
        public long mOverrideUEDValue;

        [TdfMember("THLD")]
        public string mThresholdName;
    }
}