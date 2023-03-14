using Tdf;

namespace Blaze3SDK.Blaze.GameManager
{
    [TdfStruct]
    public struct StartMatchmakingResponse
    {
        /*
        
        Blaze::GameManager::StartMatchmakingResponse {
	        TdfInt(unsigned int) MSID = 0
        }

        struct __cppobj Blaze::GameManager::StartMatchmakingResponse : Blaze::Tdf
        {
          unsigned int mSessionId;
        };

         */

        [TdfMember("MSID")]
        public uint mSessionId;
    }
}
