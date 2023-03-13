using Tdf;

namespace Blaze3SDK.Blaze.GameManager
{
    [TdfStruct]
    public struct SetPlayerCapacityRequest
    {
        /*
        struct __cppobj __declspec(align(4)) Blaze::GameManager::SetPlayerCapacityRequest : Blaze::Tdf
        {
          unsigned int mGameId;
          Blaze::TdfPrimitiveVector<unsigned short,0,0> mSlotCapacities;
          unsigned __int16 mTeamCapacity;
        };
        struct Blaze::GameManager::SetPlayerCapacityRequest::TdfMemberInfoDefinition
        {
          Blaze::TdfMemberInfoInt mGameIdDef;
          Blaze::TdfMemberInfo mSlotCapacitiesDef;
          Blaze::TdfMemberInfoInt mTeamCapacityDef;
        };

        Blaze::GameManager::SetPlayerCapacityRequest {
	        TdfInt(unsigned int) GID = 0
	        TdfList PCAP
	        TdfInt(unsigned __int16) TCAP = 0
        }

         */


        [TdfMember("GID")]
        public uint mGameId;

        [TdfMember("PCAP")]
        public List<ushort> mSlotCapacities;

        [TdfMember("TCAP")]
        public ushort mTeamCapacity;
    }
}
