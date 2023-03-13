using Tdf;

namespace Blaze3SDK.Blaze.GameManager
{
    [TdfStruct]
    public struct NotifyPlayerJoining
    {
        /*
        Blaze::GameManager::NotifyPlayerJoining {
	        TdfInt(unsigned int) GID = 0
	        TdfClass PDAT
        }

        struct __cppobj __declspec(align(8)) Blaze::GameManager::NotifyPlayerJoining : Blaze::Tdf
        {
          unsigned int mGameId;
          Blaze::GameManager::ReplicatedGamePlayer mJoiningPlayer;
          Blaze::GameManager::ReplicatedGamePlayer *mJoiningPlayerPtr;
        };


         */

        [TdfMember("GID")]
        public uint mGameId;

        [TdfMember("PDAT")]
        public ReplicatedGamePlayer mJoiningPlayer;
    }
}
