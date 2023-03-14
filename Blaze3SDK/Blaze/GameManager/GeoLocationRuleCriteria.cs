using Tdf;

namespace Blaze3SDK.Blaze.GameManager
{
    [TdfStruct]
    public struct GeoLocationRuleCriteria
    {
        /*
        Blaze::GameManager::GeoLocationRuleCriteria {
	        TdfString THLD = (const char*)37007354
        }

        struct __cppobj Blaze::GameManager::GeoLocationRuleCriteria : Blaze::Tdf
        {
          Blaze::TdfString mMinFitThresholdName;
        };


         */

        [TdfMember("THLD")]
        public string mMinFitThresholdName;
        
    }
}