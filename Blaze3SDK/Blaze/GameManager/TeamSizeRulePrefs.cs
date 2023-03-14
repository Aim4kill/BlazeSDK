using Tdf;

namespace Blaze3SDK.Blaze.GameManager
{
    [TdfStruct]
    public struct TeamSizeRulePrefs
    {
        /*
        
        Blaze::GameManager::TeamSizeRulePrefs {
	        TdfInt(unsigned __int16) PCAP = 0
	        TdfInt(unsigned __int16) PCNT = 0
	        TdfInt(unsigned __int16) PMIN = 0
	        TdfInt(unsigned __int16) SDIF = 0
	        TdfString THLD = (const char*)37007354
	        TdfInt(unsigned __int16) TID = -65536
	        TdfList TLST
        }

        struct Blaze::GameManager::TeamSizeRulePrefs::TdfMemberInfoDefinition
        {
          Blaze::TdfMemberInfoInt mMaxPlayerCapacityDef;
          Blaze::TdfMemberInfoInt mDesiredPlayerCountDef;
          Blaze::TdfMemberInfoInt mMinPlayerCountDef;
          Blaze::TdfMemberInfoInt mMaxTeamSizeDifferenceAllowedDef;
          Blaze::TdfMemberInfoString mRangeOffsetListNameDef;
          Blaze::TdfMemberInfoInt mTeamIdDef;
          Blaze::TdfMemberInfo mTeamIdVectorDef;
        };

        struct __cppobj Blaze::GameManager::TeamSizeRulePrefs : Blaze::Tdf
        {
          Blaze::TdfString mRangeOffsetListName;
          unsigned __int16 mTeamId;
          Blaze::TdfPrimitiveVector<unsigned short,0,0> mTeamIdVector;
          unsigned __int16 mDesiredPlayerCount;
          unsigned __int16 mMaxPlayerCapacity;
          unsigned __int16 mMinPlayerCount;
          unsigned __int16 mMaxTeamSizeDifferenceAllowed;
        };

         */

        [TdfMember("PCAP")]
        public ushort mMaxPlayerCapacity;

        [TdfMember("PCNT")]
        public ushort mDesiredPlayerCount;

        [TdfMember("PMIN")]
        public ushort mMinPlayerCount;

        [TdfMember("SDIF")]
        public ushort mMaxTeamSizeDifferenceAllowed;

        [TdfMember("THLD")]
        public string mRangeOffsetListName;

        [TdfMember("TID")]
        public ushort mTeamId;

        [TdfMember("TLST")]
        public List<ushort> mTeamIdVector;
    }
}