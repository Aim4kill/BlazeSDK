using Tdf;

namespace Blaze3SDK.Blaze.GameManager
{
    [TdfStruct]
    public struct GameSizeRulePrefs
    {
        /*
        
        Blaze::GameManager::GameSizeRulePrefs {
	        TdfInt(unsigned __int8) ISSG = 0
	        TdfInt(unsigned __int16) PCAP = 16777216
	        TdfInt(unsigned __int16) PCNT = 16777216
	        TdfInt(unsigned __int16) PMIN = 16777216
	        TdfString THLD = (const char*)37007354
        }
        
        struct Blaze::GameManager::GameSizeRulePrefs::TdfMemberInfoDefinition
        {
          Blaze::TdfMemberInfoInt mIsSingleGroupMatchDef;
          Blaze::TdfMemberInfoInt mMaxPlayerCapacityDef;
          Blaze::TdfMemberInfoInt mDesiredPlayerCountDef;
          Blaze::TdfMemberInfoInt mMinPlayerCountDef;
          Blaze::TdfMemberInfoString mMinFitThresholdNameDef;
        };

        struct __cppobj __declspec(align(4)) Blaze::GameManager::GameSizeRulePrefs : Blaze::Tdf
        {
          unsigned __int8 mIsSingleGroupMatch;
          Blaze::TdfString mMinFitThresholdName;
          unsigned __int16 mDesiredPlayerCount;
          unsigned __int16 mMaxPlayerCapacity;
          unsigned __int16 mMinPlayerCount;
        };

         */

        [TdfMember("ISSG")]
        public byte mIsSingleGroupMatch;

        [TdfMember("PCAP")]
        public ushort mMaxPlayerCapacity;

        [TdfMember("PCNT")]
        public ushort mDesiredPlayerCount;

        [TdfMember("PMIN")]
        public ushort mMinPlayerCount;

        [TdfMember("THLD")]
        public string mMinFitThresholdName;
    }
}