using Tdf;

namespace Blaze3SDK.Blaze.GameManager
{
    [TdfStruct]
    public struct AdvanceGameStateRequest
    {
        /*
        
        Blaze::GameManager::AdvanceGameStateRequest {
	        TdfInt(unsigned int) GID = 0
	        TdfEnum GSTA = 0 from (Blaze::TdfEnumMap*)44650580
        }

        struct __cppobj Blaze::GameManager::AdvanceGameStateRequest : Blaze::Tdf
        {
          unsigned int mGameId;
          Blaze::GameManager::GameState mNewGameState;
        };

         */

        [TdfMember("GID")]
        public uint mGameId;

        [TdfMember("GSTA")]
        public GameState mNewGameState;

    }
}
