using Tdf;

namespace Blaze3SDK.Blaze.GameManager
{
    [TdfStruct]
    public struct DNFRulePrefs
    {
        /*
        
        Blaze::GameManager::DNFRulePrefs {
	        TdfInt(__int64) DNF = 7277816997830721536
        }

        struct __cppobj Blaze::GameManager::DNFRulePrefs : Blaze::Tdf
        {
          __int64 mMaxDNFValue;
        };


         */

        [TdfMember("DNF")]
        public long mMaxDNFValue;
        
    }
}