using Tdf;

namespace Blaze3SDK.Blaze.GameManager
{
    [TdfStruct]
    public struct DestroyGameResponse
    {
        /*
        struct __cppobj Blaze::GameManager::DestroyGameResponse : Blaze::Tdf
        {
          unsigned int mGameId;
        };
        Blaze::GameManager::DestroyGameResponse {
	        TdfInt(unsigned int) GID = 0
        }


         */

        [TdfMember("GID")]
        public uint mGameId;
    }
}
