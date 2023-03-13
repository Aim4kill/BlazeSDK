using Tdf;

namespace Blaze3SDK.Blaze.GameManager
{
    [TdfStruct]
    public struct NotifyGameStateChange
    {
        /*
        struct __cppobj Blaze::GameManager::NotifyGameStateChange : Blaze::Tdf
        {
          unsigned int mGameId;
          Blaze::GameManager::GameState mNewGameState;
        };

        Blaze::GameManager::NotifyGameStateChange {
	        TdfInt(unsigned int) GID = 0
	        TdfEnum GSTA = 0 from (Blaze::TdfEnumMap*)44650580
        }

         */

        [TdfMember("GID")]
        public uint mGameId;

        [TdfMember("GSTA")]
        public GameState mNewGameState;
    }
}
