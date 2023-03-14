using Tdf;

namespace Blaze3SDK.Blaze.GameManager
{
    [TdfStruct]
    public struct SkillRulePrefs
    {
        /*
        
        Blaze::GameManager::SkillRulePrefs {
	        TdfInt(__int64) SKDS = 0
	        TdfString SKRN = (const char*)37007354
	        TdfEnum SVOR = 0 from (Blaze::TdfEnumMap*)44651424
	        TdfString THLD = (const char*)37007354
        }

        struct Blaze::GameManager::SkillRulePrefs::TdfMemberInfoDefinition
        {
          Blaze::TdfMemberInfoInt64 mSkillValueOverrideDef;
          Blaze::TdfMemberInfoString mRuleNameDef;
          Blaze::TdfMemberInfoEnum mUseSkillValueOverrideDef;
          Blaze::TdfMemberInfoString mMinFitThresholdNameDef;
        };

        struct __cppobj Blaze::GameManager::SkillRulePrefs : Blaze::Tdf
        {
          Blaze::TdfString mRuleName;
          Blaze::TdfString mMinFitThresholdName;
          Blaze::GameManager::SkillValueOverride mUseSkillValueOverride;
          __int64 mSkillValueOverride;
        };

         */

        [TdfMember("SKDS")]
        public long mSkillValueOverride;

        [TdfMember("SKRN")]
        public string mRuleName;

        [TdfMember("SVOR")]
        public SkillValueOverride mUseSkillValueOverride;

        [TdfMember("THLD")]
        public string mMinFitThresholdName;
    }
}