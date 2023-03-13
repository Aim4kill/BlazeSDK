using Tdf;

namespace Blaze3SDK.Blaze.GameManager
{
    [TdfStruct]
    public struct CreateGameRequest
    {
        /*
			TdfList ADMN
			TdfMap ATTR
			TdfVector3 BTPL
			TdfMap CRIT
			TdfString GCTR = (const char*)37007354
			TdfEnum GENT = 0 from (Blaze::TdfEnumMap*)44649928
			TdfString GNAM = (const char*)37007354
			TdfBitSet GSET
			TdfString GTYP = (const char*)37007354
			TdfString GURL = (const char*)37007354
			TdfList HNET
			TdfBool IGNO = 0
			TdfMap MATR
			TdfBool NRES = 0
			TdfEnum NTOP = 0 from (Blaze::TdfEnumMap*)44653752
			TdfMap PATT
			TdfList PCAP
			TdfString PGID = (const char*)37007354
			TdfBlob PGSC
			TdfInt(unsigned __int16) PMAX = 0
			TdfEnum PRES = 16777216 from (Blaze::TdfEnumMap*)44653616
			TdfInt(unsigned __int16) QCAP = 0
			TdfInt(unsigned int) RGID = 0
			TdfList SEAT
			TdfList SIDL
			TdfEnum SLOT = 0 from (Blaze::TdfEnumMap*)44649936
			TdfInt(unsigned __int16) TCAP = 0
			TdfList TIDS
			TdfInt(unsigned __int16) TIDX = -65536
			TdfEnum VOIP = 0 from (Blaze::TdfEnumMap*)44653760
			TdfString VSTR = (const char*)37007354
		
		  Blaze::TdfMemberInfo mAdminPlayerList;
		  Blaze::TdfMemberInfo mGameAttribs;
		  Blaze::TdfMemberInfo mGroupId;
		  Blaze::TdfMemberInfo mEntryCriteriaMap;
		  Blaze::TdfMemberInfoString mGamePingSiteAlias;
		  Blaze::TdfMemberInfoEnum mGameEntryType;
		  Blaze::TdfMemberInfoString mGameName;
		  Blaze::TdfMemberInfo mGameSettings;
		  Blaze::TdfMemberInfoString mGameTypeName;
		  Blaze::TdfMemberInfoString mGameStatusUrl;
		  Blaze::TdfMemberInfo mHostNetworkAddressList;
		  Blaze::TdfMemberInfoInt mIgnoreEntryCriteriaWithInvite;
		  Blaze::TdfMemberInfo mMeshAttribs;
		  Blaze::TdfMemberInfoInt mServerNotResetable;
		  Blaze::TdfMemberInfoEnum mNetworkTopology;
		  Blaze::TdfMemberInfo mHostPlayerAttribs;
		  Blaze::TdfMemberInfo mSlotCapacities;
		  Blaze::TdfMemberInfoString mPersistedGameId;
		  Blaze::TdfMemberInfo mPersistedGameIdSecret;
		  Blaze::TdfMemberInfoInt mMaxPlayerCapacity;
		  Blaze::TdfMemberInfoEnum mPresenceMode;
		  Blaze::TdfMemberInfoInt mQueueCapacity;
		  Blaze::TdfMemberInfoInt mReservedDynamicDSGameId;
		  Blaze::TdfMemberInfo mReservedPlayerSeats;
		  Blaze::TdfMemberInfo mSessionIdList;
		  Blaze::TdfMemberInfoEnum mJoiningSlotType;
		  Blaze::TdfMemberInfoInt mTeamCapacity;
		  Blaze::TdfMemberInfo mTeamIds;
		  Blaze::TdfMemberInfoInt mJoiningTeamIndex;
		  Blaze::TdfMemberInfoEnum mVoipNetwork;
		  Blaze::TdfMemberInfoString mGameProtocolVersionString;

		Blaze::TdfPrimitiveVector<__int64,0,0> mAdminPlayerList;
		Blaze::TdfPrimitiveMap<Blaze::TdfString,Blaze::TdfString,1,1,0,0,Blaze::TdfStringCompareIgnoreCase> mGameAttribs;
		Blaze::BlazeObjectId mGroupId;
		Blaze::TdfPrimitiveMap<Blaze::TdfString,Blaze::TdfString,1,1,0,0,Blaze::TdfStringCompareIgnoreCase> mEntryCriteriaMap;
		Blaze::TdfString mGamePingSiteAlias;
		Blaze::GameManager::GameEntryType mGameEntryType;
		Blaze::TdfString mGameName;
		Blaze::GameManager::GameSettings mGameSettings;
		Blaze::TdfString mGameTypeName;
		Blaze::TdfString mGameStatusUrl;
		Blaze::TdfStructVector<Blaze::NetworkAddress,Blaze::TdfUnionVectorBase> mHostNetworkAddressList;
		bool mIgnoreEntryCriteriaWithInvite;
		Blaze::TdfPrimitiveMap<Blaze::TdfString,Blaze::TdfString,1,1,0,0,Blaze::TdfStringCompareIgnoreCase> mMeshAttribs;
		bool mServerNotResetable;
		Blaze::GameNetworkTopology mNetworkTopology;
		Blaze::TdfPrimitiveMap<Blaze::TdfString,Blaze::TdfString,1,1,0,0,Blaze::TdfStringCompareIgnoreCase> mHostPlayerAttribs;
		Blaze::TdfPrimitiveVector<unsigned short,0,0> mSlotCapacities;
		Blaze::TdfString mPersistedGameId;
		Blaze::TdfBlob mPersistedGameIdSecret;
		unsigned __int16 mMaxPlayerCapacity;
		Blaze::PresenceMode mPresenceMode;
		unsigned __int16 mQueueCapacity;
		unsigned int mReservedDynamicDSGameId;
		Blaze::TdfPrimitiveVector<__int64,0,0> mReservedPlayerSeats; 
		Blaze::TdfPrimitiveVector<unsigned int,0,0> mSessionIdList;
		Blaze::GameManager::SlotType mJoiningSlotType;
		unsigned __int16 mTeamCapacity;
		Blaze::TdfPrimitiveVector<unsigned short,0,0> mTeamIds;
		unsigned __int16 mJoiningTeamIndex;
		Blaze::VoipTopology mVoipNetwork;
		Blaze::TdfString mGameProtocolVersionString;
		 
         */


        [TdfMember("ADMN")]
		public List<long> mAdminPlayerList;

        [TdfMember("ATTR")]
        public SortedDictionary<string, string> mGameAttribs;

        [TdfMember("BTPL")]
        public BlazeObjectId mGroupId;

        [TdfMember("CRIT")]
        public SortedDictionary<string, string> mEntryCriteriaMap;

        [TdfMember("GCTR")]
        public string mGamePingSiteAlias;

        [TdfMember("GENT")]
        public GameEntryType mGameEntryType;

        [TdfMember("GNAM")]
        public string mGameName;

        [TdfMember("GSET")]
        public GameSettings mGameSettings;

        [TdfMember("GTYP")]
        public string mGameTypeName;

        [TdfMember("GURL")]
        public string mGameStatusUrl;

        [TdfMember("HNET")]
        public List<NetworkAddress> mHostNetworkAddressList;

        [TdfMember("IGNO")]
        public bool mIgnoreEntryCriteriaWithInvite;

        [TdfMember("MATR")]
        public SortedDictionary<string, string> mMeshAttribs;

        [TdfMember("NRES")]
        public bool mServerNotResetable;

        [TdfMember("NTOP")]
        public GameNetworkTopology mNetworkTopology;

        [TdfMember("PATT")]
        public SortedDictionary<string, string> mHostPlayerAttribs;

        [TdfMember("PCAP")]
        public List<ushort> mSlotCapacities;

        [TdfMember("PGID")]
        public string mPersistedGameId;

        [TdfMember("PGSC")]
        public byte[] mPersistedGameIdSecret;

        [TdfMember("PMAX")]
        public ushort mMaxPlayerCapacity;

        [TdfMember("PRES")]
        public PresenceMode mPresenceMode;

        [TdfMember("QCAP")]
        public ushort mQueueCapacity;

        [TdfMember("RGID")]
        public uint mReservedDynamicDSGameId;

        [TdfMember("SEAT")]
        public List<long> mReservedPlayerSeats;

        [TdfMember("SIDL")]
        public List<uint> mSessionIdList;

        [TdfMember("SLOT")]
        public SlotType mJoiningSlotType;

        [TdfMember("TCAP")]
        public ushort mTeamCapacity;

        [TdfMember("TIDS")]
        public List<ushort> mTeamIds;

        [TdfMember("TIDX")]
        public ushort mJoiningTeamIndex;

        [TdfMember("VOIP")]
        public VoipTopology mVoipNetwork;

        [TdfMember("VSTR")]
        public string mGameProtocolVersionString;
    }
}
