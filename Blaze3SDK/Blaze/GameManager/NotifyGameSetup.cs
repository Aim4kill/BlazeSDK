using Tdf;

namespace Blaze3SDK.Blaze.GameManager
{
    [TdfStruct]
    public struct NotifyGameSetup
    {

        /*
        struct Blaze::GameManager::NotifyGameSetup::TdfMemberInfoDefinition
        {
          Blaze::TdfMemberInfoClass mGameDataDef;
          Blaze::TdfMemberInfo mGameRosterDef;
          Blaze::TdfMemberInfo mGameQueueDef;
          Blaze::TdfMemberInfo mGameSetupReasonDef;
        };

        Blaze::GameManager::NotifyGameSetup {
	        TdfClass GAME
	        TdfList PROS
	        TdfList QUEU
	        TdfUnion REAS
        }


        struct __cppobj Blaze::GameManager::NotifyGameSetup : Blaze::Tdf
        {
          Blaze::GameManager::ReplicatedGameData mGameData;
          Blaze::GameManager::ReplicatedGameData *mGameDataPtr;
          Blaze::TdfStructVector<Blaze::GameManager::ReplicatedGamePlayer,Blaze::TdfTdfVectorBase> mGameRoster;
          Blaze::TdfStructVector<Blaze::GameManager::ReplicatedGamePlayer,Blaze::TdfTdfVectorBase> mGameQueue;
          Blaze::GameManager::GameSetupReason mGameSetupReason;
        };


        */


        [TdfMember("GAME")]
        public ReplicatedGameData mGameData;

        [TdfMember("PROS")]
        public List<ReplicatedGamePlayer> mGameRoster;

        [TdfMember("QUEU")]
        public List<ReplicatedGamePlayer> mGameQueue;

        [TdfMember("REAS")]
        public GameSetupReason mGameSetupReason;
    }
}
