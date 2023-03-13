using Tdf;

namespace Blaze3SDK.Blaze.GameManager
{
    [TdfStruct]
    public struct HostInfo
    {
        /*
        struct __declspec(align(8)) Blaze::GameManager::HostInfo::TdfMemberInfoDefinition
        {
          Blaze::TdfMemberInfoInt64 mPlayerIdDef;
          Blaze::TdfMemberInfoInt mSlotIdDef;
        };
        Blaze::GameManager::HostInfo {
	        TdfInt(__int64) HPID = 0
	        TdfInt(unsigned __int8) HSLT = 0
        }
        
        struct __cppobj __declspec(align(8)) Blaze::GameManager::HostInfo : Blaze::Tdf
        {
          __int64 mPlayerId;
          unsigned __int8 mSlotId;
        };


         */

        [TdfMember("HPID")]
        public long mPlayerId;

        [TdfMember("HSLT")]
        public byte mSlotId;
    }
}
