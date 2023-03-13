using Tdf;

namespace Blaze3SDK.Blaze.GameManager
{
    [TdfStruct(3362602663)]
    public struct ReplicatedGamePlayer
    {
        /*
        Blaze::GameManager::ReplicatedGamePlayer {
	        TdfBlob BLOB
	        TdfInt(unsigned __int64) EXID = 0
	        TdfInt(unsigned int) GID = 0
	        TdfInt(unsigned int) LOC = 0
	        TdfString NAME = (const char*)37007354
	        TdfMap PATT
	        TdfInt(__int64) PID = 0
	        TdfUnion PNET
	        TdfInt(unsigned __int8) SID = -16777216
	        TdfEnum SLOT = 0 from (Blaze::TdfEnumMap*)44649936
	        TdfEnum STAT = 0 from (Blaze::TdfEnumMap*)44650420
	        TdfInt(unsigned __int16) TIDX = -65536
	        TdfInt(__int64) TIME = 0
	        TdfVector3 UGID
	        TdfInt(unsigned int) UID = -1
        }

        struct __declspec(align(8)) Blaze::GameManager::ReplicatedGamePlayer::TdfMemberInfoDefinition
        {
          Blaze::TdfMemberInfo mCustomDataDef;
          Blaze::TdfMemberInfoInt64 mExternalIdDef;
          Blaze::TdfMemberInfoInt mGameIdDef;
          Blaze::TdfMemberInfoInt mAccountLocaleDef;
          Blaze::TdfMemberInfoString mPlayerNameDef;
          Blaze::TdfMemberInfo mPlayerAttribsDef;
          Blaze::TdfMemberInfoInt64 mPlayerIdDef;
          Blaze::TdfMemberInfo mNetworkAddressDef;
          Blaze::TdfMemberInfoInt mSlotIdDef;
          Blaze::TdfMemberInfoEnum mSlotTypeDef;
          Blaze::TdfMemberInfoEnum mPlayerStateDef;
          Blaze::TdfMemberInfoInt mTeamIndexDef;
          Blaze::TdfMemberInfoInt64 mJoinedGameTimestampDef;
          Blaze::TdfMemberInfo mUserGroupIdDef;
          Blaze::TdfMemberInfoInt mPlayerSessionIdDef;
        };

        
        struct __cppobj Blaze::GameManager::ReplicatedGamePlayer : Blaze::Tdf
        {
          unsigned int mGameId;
          __int64 mPlayerId;
          unsigned __int64 mExternalId;
          unsigned int mAccountLocale;
          unsigned __int8 mSlotId;
          unsigned int mPlayerSessionId;
          Blaze::TdfString mPlayerName;
          Blaze::GameManager::PlayerState mPlayerState;
          Blaze::TdfBlob mCustomData;
          Blaze::TdfPrimitiveMap<Blaze::TdfString,Blaze::TdfString,1,1,0,0,Blaze::TdfStringCompareIgnoreCase> mPlayerAttribs;
          Blaze::NetworkAddress mNetworkAddress;
          Blaze::GameManager::SlotType mSlotType;
          unsigned __int16 mTeamIndex;
          Blaze::BlazeObjectId mUserGroupId;
          __int64 mJoinedGameTimestamp;
        };

        

         */

        [TdfMember("BLOB")]
        public byte[] mCustomData;

        [TdfMember("EXID")]
        public ulong mExternalId;

        [TdfMember("GID")]
        public uint mGameId;

        [TdfMember("LOC")]
        public uint mAccountLocale;

        [TdfMember("NAME")]
        public string mPlayerName;

        [TdfMember("PATT")]
        public SortedDictionary<string, string> mPlayerAttribs;

        [TdfMember("PID")]
        public long mPlayerId;

        [TdfMember("PNET")]
        public NetworkAddress mNetworkAddress;

        [TdfMember("SID")]
        public byte mSlotId;

        [TdfMember("SLOT")]
        public SlotType mSlotType;

        [TdfMember("STAT")]
        public PlayerState mPlayerState;

        [TdfMember("TIDX")]
        public ushort mTeamIndex;

        [TdfMember("TIME")]
        public long mJoinedGameTimestamp;

        [TdfMember("UGID")]
        public BlazeObjectId mUserGroupId;

        [TdfMember("UID")]
        public uint mPlayerSessionId;

    }
}
