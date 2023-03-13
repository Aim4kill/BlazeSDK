using Tdf;

namespace Blaze3SDK.Blaze.GameManager
{
    [TdfStruct]
    public struct DestroyGameRequest
    {
        /*
        Blaze::GameManager::DestroyGameRequest {
	        TdfInt(unsigned int) GID = 0
	        TdfEnum REAS = 0 from (Blaze::TdfEnumMap*)44650588
        }
        struct __cppobj Blaze::GameManager::DestroyGameRequest : Blaze::Tdf
        {
          unsigned int mGameId;
          Blaze::GameManager::GameDestructionReason mDestructionReason;
        };

         */

        [TdfMember("GID")]
        public uint mGameId;

        [TdfMember("REAS")]
        public GameDestructionReason mDestructionReason;
    }
}
