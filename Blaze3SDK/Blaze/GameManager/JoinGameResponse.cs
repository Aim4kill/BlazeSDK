using Tdf;

namespace Blaze3SDK.Blaze.GameManager
{
    [TdfStruct]
    public struct JoinGameResponse
    {

        /*
        Blaze::GameManager::JoinGameResponse {
	        TdfInt(unsigned int) GID = 0
	        TdfEnum JGS = 0 from (Blaze::TdfEnumMap*)44650100
        }

        struct __cppobj Blaze::GameManager::JoinGameResponse : Blaze::Tdf
        {
          unsigned int mGameId;
          Blaze::GameManager::JoinState mJoinState;
        };

         */

        [TdfMember("GID")]
        public uint mGameId;

        [TdfMember("JGS")]
        public JoinState mJoinState;
    }
}
