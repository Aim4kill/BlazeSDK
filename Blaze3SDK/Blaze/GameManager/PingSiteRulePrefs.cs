using Tdf;

namespace Blaze3SDK.Blaze.GameManager
{
    [TdfStruct]
    public struct PingSiteRulePrefs
    {
        /*
        
        Blaze::GameManager::PingSiteRulePrefs {
	        TdfString THLD = (const char*)37007354
        }

        struct __cppobj Blaze::GameManager::PingSiteRulePrefs : Blaze::Tdf
        {
          Blaze::TdfString mMinFitThresholdName;
        };


         */

        [TdfMember("THLD")]
        public string mMinFitThresholdName;
        
    }
}