using Tdf;

namespace Blaze3SDK.Blaze.GameManager
{
    [TdfStruct]
    public struct RankedGameRulePrefs
    {
        /*
         
        Blaze::GameManager::RankedGameRulePrefs {
	        TdfString THLD = (const char*)37007354
	        TdfEnum VALU = 16777216 from (Blaze::TdfEnumMap*)44651596
        }

        struct __cppobj Blaze::GameManager::RankedGameRulePrefs : Blaze::Tdf
        {
          Blaze::TdfString mMinFitThresholdName;
          Blaze::GameManager::RankedGameRulePrefs::RankedGameDesiredValue mDesiredRankedGameValue;
        };

         */

        [TdfMember("THLD")]
        public string mMinFitThresholdName;

        [TdfMember("VALU")]
        public RankedGameDesiredValue mDesiredRankedGameValue;

        [Flags]
        public enum RankedGameDesiredValue
        {
            UNKNOWN = 0,
            UNRANKED = 1,
            RANKED = 2,
            RANDOM = 4,
            ABSTAIN = 8,
        }
    }
}