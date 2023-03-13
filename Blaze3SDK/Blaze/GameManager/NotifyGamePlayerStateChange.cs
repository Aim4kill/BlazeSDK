using Tdf;

namespace Blaze3SDK.Blaze.GameManager
{
    [TdfStruct]
    public struct NotifyGamePlayerStateChange
    {
        /*
        Blaze::GameManager::NotifyGamePlayerStateChange {
	        TdfInt(unsigned int) GID = 0
	        TdfInt(__int64) PID = 0
	        TdfEnum STAT = 0 from (Blaze::TdfEnumMap*)44650420
        }

        struct __cppobj __declspec(align(8)) Blaze::GameManager::NotifyGamePlayerStateChange : Blaze::Tdf
        {
          unsigned int mGameId;
          __int64 mPlayerId;
          Blaze::GameManager::PlayerState mPlayerState;
        };
        
         */

        [TdfMember("GID")]
        public uint mGameId;

        [TdfMember("PID")]
        public long mPlayerId;

        [TdfMember("STAT")]
        public PlayerState mPlayerState;
    }
}
