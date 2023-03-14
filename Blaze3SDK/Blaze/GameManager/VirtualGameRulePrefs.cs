using Tdf;

namespace Blaze3SDK.Blaze.GameManager
{
    [TdfStruct]
    public struct VirtualGameRulePrefs
    {
        /*
        
        Blaze::GameManager::VirtualGameRulePrefs {
	        TdfString THLD = (const char*)37007354
	        TdfEnum VALU = 16777216 from (Blaze::TdfEnumMap*)44651408
        }

        struct Blaze::GameManager::VirtualGameRulePrefs::TdfMemberInfoDefinition
        {
          Blaze::TdfMemberInfoString mMinFitThresholdNameDef;
          Blaze::TdfMemberInfoEnum mDesiredVirtualGameValueDef;
        };

        struct __cppobj Blaze::GameManager::VirtualGameRulePrefs : Blaze::Tdf
        {
          Blaze::TdfString mMinFitThresholdName;
          Blaze::GameManager::VirtualGameRulePrefs::VirtualGameDesiredValue mDesiredVirtualGameValue;
        };

         */

        [TdfMember("THLD")]
        public string mMinFitThresholdName;

        [TdfMember("VALU")]
        public VirtualGameDesiredValue mDesiredVirtualGameValue;

        [Flags]
        public enum VirtualGameDesiredValue
        {
            STANDARD = 0x1,
            VIRTUALIZED = 0x2,
            ABSTAIN = 0x8,
        }
    }
}