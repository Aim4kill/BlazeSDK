using Tdf;

namespace Blaze3SDK.Blaze.GameManager
{
    [TdfStruct]
    public struct GameNameRuleCriteria
    {
        /*
        Blaze::GameManager::GameNameRuleCriteria {
	        TdfString SUBS = (const char*)37007354
        }

        struct __cppobj Blaze::GameManager::GameNameRuleCriteria : Blaze::Tdf
        {
          Blaze::TdfString mSearchString;
        };

         */

        [TdfMember("SUBS")]
        public string mSearchString;
        
    }
}