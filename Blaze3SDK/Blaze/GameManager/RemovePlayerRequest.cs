using Tdf;

namespace Blaze3SDK.Blaze.GameManager
{
    [TdfStruct]
    public struct RemovePlayerRequest
    {
        /*
        Blaze::GameManager::RemovePlayerRequest {
	        TdfVector3 BTPL
	        TdfInt(unsigned __int16) CNTX = 0
	        TdfInt(unsigned int) GID = 0
	        TdfInt(__int64) PID = 0
	        TdfEnum REAS = 0 from (Blaze::TdfEnumMap*)44650764
        }

        struct Blaze::GameManager::RemovePlayerRequest::TdfMemberInfoDefinition
        {
          Blaze::TdfMemberInfo mGroupIdDef;
          Blaze::TdfMemberInfoInt mPlayerRemovedTitleContextDef;
          Blaze::TdfMemberInfoInt mGameIdDef;
          Blaze::TdfMemberInfoInt64 mPlayerIdDef;
          Blaze::TdfMemberInfoEnum mPlayerRemovedReasonDef;
        };
        
        struct __cppobj Blaze::GameManager::RemovePlayerRequest : Blaze::Tdf
        {
          unsigned int mGameId;
          __int64 mPlayerId;
          Blaze::GameManager::PlayerRemovedReason mPlayerRemovedReason;
          unsigned __int16 mPlayerRemovedTitleContext;
          Blaze::BlazeObjectId mGroupId;
        };

        */

        [TdfMember("BTPL")]
        public BlazeObjectId mGroupId;

        [TdfMember("CNTX")]
        public ushort mPlayerRemovedTitleContext;

        [TdfMember("GID")]
        public uint mGameId;

        [TdfMember("PID")]
        public long mPlayerId;

        [TdfMember("REAS")]
        public PlayerRemovedReason mPlayerRemovedReason;

    }
}
