using Tdf;

namespace Blaze3SDK.Blaze.GameManager
{
    [TdfStruct]
    public struct PlayerConnectionStatus
    {
        /*
        Blaze::GameManager::PlayerConnectionStatus {
	        TdfBitSet FLGS
	        TdfInt(__int64) PID = 0
	        TdfEnum STAT = 0 from (Blaze::TdfEnumMap*)44650604
        }

        struct Blaze::GameManager::PlayerConnectionStatus::TdfMemberInfoDefinition
        {
          Blaze::TdfMemberInfo mPlayerNetConnectionFlagsDef;
          Blaze::TdfMemberInfoInt64 mTargetPlayerDef;
          Blaze::TdfMemberInfoEnum mPlayerNetConnectionStatusDef;
        };

        struct __cppobj __declspec(align(8)) Blaze::GameManager::PlayerConnectionStatus : Blaze::Tdf
        {
          __int64 mTargetPlayer;
          Blaze::GameManager::PlayerNetConnectionStatus mPlayerNetConnectionStatus;
          Blaze::GameManager::PlayerNetConnectionFlags mPlayerNetConnectionFlags;
        };

         */

        [TdfMember("FLGS")]
        public PlayerNetConnectionFlags mPlayerNetConnectionFlags;

        [TdfMember("PID")]
        public long mTargetPlayer;

        [TdfMember("STAT")]
        public PlayerNetConnectionStatus mPlayerNetConnectionStatus;
    }
}
