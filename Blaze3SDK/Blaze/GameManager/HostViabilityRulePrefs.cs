using Tdf;

namespace Blaze3SDK.Blaze.GameManager
{
    [TdfStruct]
    public struct HostViabilityRulePrefs
    {
        /*
        
        Blaze::GameManager::HostViabilityRulePrefs {
	        TdfString THLD = (const char*)37007354
        }

        struct __cppobj Blaze::GameManager::HostViabilityRulePrefs : Blaze::Tdf
        {
          Blaze::TdfString mMinFitThresholdName;
        };

         */

        [TdfMember("THLD")]
        public string mMinFitThresholdName;
    }
}