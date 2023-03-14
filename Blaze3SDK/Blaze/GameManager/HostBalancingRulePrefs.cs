using Tdf;

namespace Blaze3SDK.Blaze.GameManager
{
    [TdfStruct]
    public struct HostBalancingRulePrefs
    {
        /*
        
        Blaze::GameManager::HostBalancingRulePrefs {
	        TdfString THLD = (const char*)37007354
        }
        
        struct __cppobj Blaze::GameManager::HostBalancingRulePrefs : Blaze::Tdf
        {
          Blaze::TdfString mMinFitThresholdName;
        };

         */

        [TdfMember("THLD")]
        public string mMinFitThresholdName;
        
    }
}