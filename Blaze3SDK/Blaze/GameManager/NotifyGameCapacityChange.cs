using Tdf;

namespace Blaze3SDK.Blaze.GameManager
{
    [TdfStruct]
    public struct NotifyGameCapacityChange
    {
        /*
        Blaze::GameManager::NotifyGameCapacityChange {
	        TdfList CAP
	        TdfInt(unsigned int) GID = 0
	        TdfInt(unsigned __int16) TCAP = 0
        }

        struct Blaze::GameManager::NotifyGameCapacityChange::TdfMemberInfoDefinition
        {
          Blaze::TdfMemberInfo mSlotCapacitiesDef;
          Blaze::TdfMemberInfoInt mGameIdDef;
          Blaze::TdfMemberInfoInt mTeamCapacityDef;
        };

        struct __cppobj __declspec(align(4)) Blaze::GameManager::NotifyGameCapacityChange : Blaze::Tdf
        {
          unsigned int mGameId;
          Blaze::TdfPrimitiveVector<unsigned short,0,0> mSlotCapacities;
          unsigned __int16 mTeamCapacity;
        };

         */

        [TdfMember("CAP")]
        public List<ushort> mSlotCapacities;

        [TdfMember("GID")]
        public uint mGameId;

        [TdfMember("TCAP")]
        public ushort mTeamCapacity;
    }
}
