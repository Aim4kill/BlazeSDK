using Tdf;

namespace Blaze3SDK.Blaze.GameManager
{
    [TdfStruct]
    public struct JoinGameRequest
    {
        /*
        Blaze::GameManager::JoinGameRequest {
			TdfMap ATTR
			TdfVector3 BTPL
			TdfEnum GENT = 0 from (Blaze::TdfEnumMap*)44649928
			TdfInt(unsigned int) GID = 0
			TdfString GVER = (const char*)37007354
			TdfEnum JMET = 16777216 from (Blaze::TdfEnumMap*)44649912
			TdfList PLST
			TdfUnion PNET
			TdfInt(unsigned __int8) SLID = -16777216
			TdfEnum SLOT = 0 from (Blaze::TdfEnumMap*)44649936
			TdfInt(unsigned __int16) TIDX = -65536
			TdfClass USER
		}

		struct Blaze::GameManager::JoinGameRequest::TdfMemberInfoDefinition
		{
		  Blaze::TdfMemberInfo mPlayerAttribsDef;
		  Blaze::TdfMemberInfo mGroupIdDef;
		  Blaze::TdfMemberInfoEnum mGameEntryTypeDef;
		  Blaze::TdfMemberInfoInt mGameIdDef;
		  Blaze::TdfMemberInfoString mGameProtocolVersionStringDef;
		  Blaze::TdfMemberInfoEnum mJoinMethodDef;
		  Blaze::TdfMemberInfo mAdditionalPlayerIdListDef;
		  Blaze::TdfMemberInfo mPlayerNetworkAddressDef;
		  Blaze::TdfMemberInfoInt mRequestedSlotIdDef;
		  Blaze::TdfMemberInfoEnum mRequestedSlotTypeDef;
		  Blaze::TdfMemberInfoInt mJoiningTeamIndexDef;
		  Blaze::TdfMemberInfoClass mUserDef;
		};

		struct __cppobj Blaze::GameManager::JoinGameRequest : Blaze::Tdf
		{
		  unsigned int mGameId;
		  Blaze::TdfPrimitiveMap<Blaze::TdfString,Blaze::TdfString,1,1,0,0,Blaze::TdfStringCompareIgnoreCase> mPlayerAttribs;
		  Blaze::GameManager::JoinMethod mJoinMethod;
		  Blaze::NetworkAddress mPlayerNetworkAddress;
		  Blaze::TdfString mGameProtocolVersionString;
		  Blaze::GameManager::SlotType mRequestedSlotType;
		  unsigned __int8 mRequestedSlotId;
		  unsigned __int16 mJoiningTeamIndex;
		  Blaze::BlazeObjectId mGroupId;
		  Blaze::UserIdentification mUser;
		  Blaze::GameManager::GameEntryType mGameEntryType;
		  Blaze::TdfPrimitiveVector<__int64,0,0> mAdditionalPlayerIdList;
		};

         */

        [TdfMember("ATTR")]
        public Dictionary<string, string> mPlayerAttribs;

        [TdfMember("BTPL")]
        public BlazeObjectId mGroupId;

        [TdfMember("GENT")]
        public GameEntryType mGameEntryType;

        [TdfMember("GID")]
        public uint mGameId;

        [TdfMember("GVER")]
        public string mGameProtocolVersionString;

        [TdfMember("JMET")]
        public JoinMethod mJoinMethod;

        [TdfMember("PLST")]
        public List<long> mAdditionalPlayerIdList;

        [TdfMember("PNET")]
        public NetworkAddress mPlayerNetworkAddress;

        [TdfMember("SLID")]
        public byte mRequestedSlotId;

        [TdfMember("SLOT")]
        public SlotType mRequestedSlotType;

        [TdfMember("TIDX")]
        public ushort mJoiningTeamIndex;

        [TdfMember("USER")]
        public UserIdentification mUser;
    }
}
