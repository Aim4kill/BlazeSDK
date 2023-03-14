using Tdf;

namespace Blaze3SDK.Blaze.GameManager
{
    [TdfStruct]
    public struct RosterSizeRulePrefs
    {
        /*
        
        Blaze::GameManager::RosterSizeRulePrefs {
	        TdfInt(unsigned __int16) PCAP = -65536
	        TdfInt(unsigned __int16) PMIN = 0
        }

        struct Blaze::GameManager::RosterSizeRulePrefs::TdfMemberInfoDefinition
        {
          Blaze::TdfMemberInfoInt mMaxPlayerCountDef;
          Blaze::TdfMemberInfoInt mMinPlayerCountDef;
        };


        struct __cppobj Blaze::GameManager::RosterSizeRulePrefs : Blaze::Tdf
        {
          unsigned __int16 mMinPlayerCount;
          unsigned __int16 mMaxPlayerCount;
        };

         */

        [TdfMember("PCAP")]
        public ushort mMaxPlayerCount;

        [TdfMember("PMIN")]
        public ushort mMinPlayerCount;
    }
}