using Tdf;

namespace Blaze3SDK.Blaze.GameManager
{
    [TdfStruct]
    public struct NotifyPlayerJoinCompleted
    {
        /*
        Blaze::GameManager::NotifyPlayerJoinCompleted {
	        TdfInt(unsigned int) GID = 0
	        TdfInt(__int64) PID = 0
        }

        struct __cppobj Blaze::GameManager::NotifyPlayerJoinCompleted : Blaze::Tdf
        {
          unsigned int mGameId;
          __int64 mPlayerId;
        };

         */

        [TdfMember("GID")]
        public uint mGameId;

        [TdfMember("PID")]
        public long mPlayerId;
    }
}
