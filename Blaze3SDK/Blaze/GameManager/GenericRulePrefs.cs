using Tdf;

namespace Blaze3SDK.Blaze.GameManager
{
    [TdfStruct]
    public struct GenericRulePrefs
    {
        /*
        
        Blaze::GameManager::GenericRulePrefs {
	        TdfString NAME = (const char*)37007354
	        TdfString THLD = (const char*)37007354
	        TdfList VALU
        }

        struct Blaze::GameManager::GenericRulePrefs::TdfMemberInfoDefinition
        {
          Blaze::TdfMemberInfoString mRuleNameDef;
          Blaze::TdfMemberInfoString mMinFitThresholdNameDef;
          Blaze::TdfMemberInfo mDesiredValuesDef;
        };

        struct __cppobj Blaze::GameManager::GenericRulePrefs : Blaze::Tdf
        {
          Blaze::TdfString mRuleName;
          Blaze::TdfString mMinFitThresholdName;
          Blaze::TdfPrimitiveVector<Blaze::TdfString,1,0> mDesiredValues;
        };

         */

        [TdfMember("NAME")]
        public string mRuleName;
        
        [TdfMember("THLD")]
        public string mMinFitThresholdName;

        [TdfMember("VALU")]
        public List<string> mDesiredValues;
        
    }
}