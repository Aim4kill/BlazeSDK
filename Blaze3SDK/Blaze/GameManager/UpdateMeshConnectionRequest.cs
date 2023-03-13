using Tdf;

namespace Blaze3SDK.Blaze.GameManager
{
    [TdfStruct]
    public struct UpdateMeshConnectionRequest
    {
        /*
        Blaze::GameManager::UpdateMeshConnectionRequest {
	        TdfInt(unsigned int) GID = 0
	        TdfList TARG
        }

        struct __cppobj Blaze::GameManager::UpdateMeshConnectionRequest : Blaze::Tdf
        {
          unsigned int mGameId;
          Blaze::TdfStructVector<Blaze::GameManager::PlayerConnectionStatus,Blaze::TdfTdfVectorBase> mMeshConnectionStatusList;
        };

         */

        [TdfMember("GID")]
        public uint mGameId;

        [TdfMember("TARG")]
        public List<PlayerConnectionStatus> mMeshConnectionStatusList;
    }
}
