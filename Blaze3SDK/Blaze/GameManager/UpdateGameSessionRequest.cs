using Tdf;

namespace Blaze3SDK.Blaze.GameManager
{
    [TdfStruct]
    public struct UpdateGameSessionRequest
    {
        /*
        
        Blaze::GameManager::UpdateGameSessionRequest {
	        TdfInt(unsigned int) GID = 0
	        TdfBlob XNNC
	        TdfBlob XSES
        }

        struct Blaze::GameManager::UpdateGameSessionRequest::TdfMemberInfoDefinition
        {
          Blaze::TdfMemberInfoInt mGameIdDef;
          Blaze::TdfMemberInfo mXnetNonceDef;
          Blaze::TdfMemberInfo mXnetSessionDef;
        };

        struct __cppobj Blaze::GameManager::UpdateGameSessionRequest : Blaze::Tdf
        {
          unsigned int mGameId;
          Blaze::TdfBlob mXnetNonce;
          Blaze::TdfBlob mXnetSession;
        };

        */

        [TdfMember("GID")]
        public uint mGameId;

        [TdfMember("XNNC")]
        public byte[] mXnetNonce;

        [TdfMember("XSES")]
        public byte[] mXnetSession;
    }
}
