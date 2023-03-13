using Tdf;

namespace Blaze3SDK.Blaze.GameManager
{
    [TdfStruct(1008717040)]
    public struct ReplicatedGameData
    {
		/*
        Blaze::GameManager::ReplicatedGameData {
			TdfList ADMN
			TdfMap ATTR
			TdfList CAP
			TdfMap CRIT
			TdfInt(unsigned int) GID = 0
			TdfString GNAM = (const char*)37007354
			TdfInt(unsigned __int64) GPVH = 0
			TdfBitSet GSET
			TdfInt(unsigned __int64) GSID = 0
			TdfEnum GSTA = 0 from (Blaze::TdfEnumMap*)44650580
			TdfString GTYP = (const char*)37007354
			TdfList HNET
			TdfInt(unsigned int) HSES = -1
			TdfBool IGNO = 0
			TdfMap MATR
			TdfInt(unsigned __int16) MCAP = 0
			TdfClass NQOS
			TdfBool NRES = 0
			TdfEnum NTOP = 0 from (Blaze::TdfEnumMap*)44653752
			TdfString PGID = (const char*)37007354
			TdfBlob PGSR
			TdfClass PHST
			TdfEnum PRES = 0 from (Blaze::TdfEnumMap*)44653616
			TdfString PSAS = (const char*)37007354
			TdfInt(unsigned __int16) QCAP = 0
			TdfInt(unsigned int) SEED = 0
			TdfInt(unsigned __int16) TCAP = 0
			TdfClass THST
			TdfList TIDS
			TdfString UUID = (const char*)37007354
			TdfEnum VOIP = 0 from (Blaze::TdfEnumMap*)44653760
			TdfString VSTR = (const char*)37007354
			TdfBlob XNNC
			TdfBlob XSES
		}

		struct Blaze::GameManager::ReplicatedGameData::TdfMemberInfoDefinition
		{
		  Blaze::TdfMemberInfo mAdminPlayerListDef;
		  Blaze::TdfMemberInfo mGameAttribsDef;
		  Blaze::TdfMemberInfo mSlotCapacitiesDef;
		  Blaze::TdfMemberInfo mEntryCriteriaMapDef;
		  Blaze::TdfMemberInfoInt mGameIdDef;
		  Blaze::TdfMemberInfoString mGameNameDef;
		  Blaze::TdfMemberInfoInt64 mGameProtocolVersionHashDef;
		  Blaze::TdfMemberInfo mGameSettingsDef;
		  Blaze::TdfMemberInfoInt64 mGameReportingIdDef;
		  Blaze::TdfMemberInfoEnum mGameStateDef;
		  Blaze::TdfMemberInfoString mGameTypeNameDef;
		  Blaze::TdfMemberInfo mHostNetworkAddressListDef;
		  Blaze::TdfMemberInfoInt mTopologyHostSessionIdDef;
		  Blaze::TdfMemberInfoInt mIgnoreEntryCriteriaWithInviteDef;
		  Blaze::TdfMemberInfo mMeshAttribsDef;
		  Blaze::TdfMemberInfoInt mMaxPlayerCapacityDef;
		  Blaze::TdfMemberInfoClass mNetworkQosDataDef;
		  Blaze::TdfMemberInfoInt mServerNotResetableDef;
		  Blaze::TdfMemberInfoEnum mNetworkTopologyDef;
		  Blaze::TdfMemberInfoString mPersistedGameIdDef;
		  Blaze::TdfMemberInfo mPersistedGameIdSecretDef;
		  Blaze::TdfMemberInfoClass mPlatformHostInfoDef;
		  Blaze::TdfMemberInfoEnum mPresenceModeDef;
		  Blaze::TdfMemberInfoString mPingSiteAliasDef;
		  Blaze::TdfMemberInfoInt mQueueCapacityDef;
		  Blaze::TdfMemberInfoInt mSharedSeedDef;
		  Blaze::TdfMemberInfoInt mTeamCapacityDef;
		  Blaze::TdfMemberInfoClass mTopologyHostInfoDef;
		  Blaze::TdfMemberInfo mTeamIdsDef;
		  Blaze::TdfMemberInfoString mUUIDDef;
		  Blaze::TdfMemberInfoEnum mVoipNetworkDef;
		  Blaze::TdfMemberInfoString mGameProtocolVersionStringDef;
		  Blaze::TdfMemberInfo mXnetNonceDef;
		  Blaze::TdfMemberInfo mXnetSessionDef;
		};

		struct __cppobj __declspec(align(4)) Blaze::GameManager::ReplicatedGameData : Blaze::Tdf
		{
		  Blaze::TdfString mGameName;
		  unsigned int mGameId;
		  Blaze::TdfString mUUID;
		  unsigned int mSharedSeed;
		  unsigned __int64 mGameReportingId;
		  Blaze::TdfString mGameTypeName;
		  Blaze::TdfString mGameProtocolVersionString;
		  unsigned __int64 mGameProtocolVersionHash;
		  Blaze::PresenceMode mPresenceMode;
		  Blaze::TdfBlob mXnetNonce;
		  Blaze::TdfBlob mXnetSession;
		  Blaze::GameNetworkTopology mNetworkTopology;
		  Blaze::VoipTopology mVoipNetwork;
		  Blaze::TdfString mPingSiteAlias;
		  Blaze::GameManager::HostInfo mTopologyHostInfo;
		  Blaze::GameManager::HostInfo mPlatformHostInfo;
		  unsigned int mTopologyHostSessionId;
		  Blaze::TdfStructVector<Blaze::NetworkAddress,Blaze::TdfUnionVectorBase> mHostNetworkAddressList;
		  Blaze::Util::NetworkQosData mNetworkQosData;
		  Blaze::GameManager::GameState mGameState;
		  Blaze::GameManager::GameSettings mGameSettings;
		  Blaze::TdfPrimitiveMap<Blaze::TdfString,Blaze::TdfString,1,1,0,0,Blaze::TdfStringCompareIgnoreCase> mGameAttribs;
		  Blaze::TdfPrimitiveMap<Blaze::TdfString,Blaze::TdfString,1,1,0,0,Blaze::TdfStringCompareIgnoreCase> mMeshAttribs;
		  Blaze::TdfPrimitiveVector<__int64,0,0> mAdminPlayerList;
		  Blaze::TdfPrimitiveVector<unsigned short,0,0> mSlotCapacities;
		  Blaze::TdfPrimitiveVector<unsigned short,0,0> mTeamIds;
		  unsigned __int16 mTeamCapacity;
		  unsigned __int16 mMaxPlayerCapacity;
		  Blaze::TdfPrimitiveMap<Blaze::TdfString,Blaze::TdfString,1,1,0,0,Blaze::TdfStringCompareIgnoreCase> mEntryCriteriaMap;
		  bool mIgnoreEntryCriteriaWithInvite;
		  unsigned __int16 mQueueCapacity;
		  Blaze::TdfString mPersistedGameId;
		  Blaze::TdfBlob mPersistedGameIdSecret;
		  bool mServerNotResetable;
		};

		



         */

		[TdfMember("ADMN")]
		public List<long> mAdminPlayerList;

        [TdfMember("ATTR")]
        public SortedDictionary<string, string> mGameAttribs;

        [TdfMember("CAP")]
        public List<ushort> mSlotCapacities;

        [TdfMember("CRIT")]
        public SortedDictionary<string, string> mEntryCriteriaMap;

        [TdfMember("GID")]
        public uint mGameId;

        [TdfMember("GNAM")]
        public string mGameName;

        [TdfMember("GPVH")]
        public ulong mGameProtocolVersionHash;

        [TdfMember("GSET")]
        public GameSettings mGameSettings;

        [TdfMember("GSID")]
        public ulong mGameReportingId;

        [TdfMember("GSTA")]
        public GameState mGameState;

        [TdfMember("GTYP")]
        public string mGameTypeName;

        [TdfMember("HNET")]
        public List<NetworkAddress> mHostNetworkAddressList;

        [TdfMember("HSES")]
        public uint mTopologyHostSessionId;

        [TdfMember("IGNO")]
        public bool mIgnoreEntryCriteriaWithInvite;

        [TdfMember("MATR")]
        public SortedDictionary<string, string> mMeshAttribs;

        [TdfMember("MCAP")]
        public ushort mMaxPlayerCapacity;

        [TdfMember("NQOS")]
        public Util.NetworkQosData mNetworkQosData;

        [TdfMember("NRES")]
        public bool mServerNotResetable;

        [TdfMember("NTOP")]
        public GameNetworkTopology mNetworkTopology;

        [TdfMember("PGID")]
        public string mPersistedGameId;

        [TdfMember("PGSR")]
        public byte[] mPersistedGameIdSecret;

        [TdfMember("PHST")]
        public HostInfo mPlatformHostInfo;

        [TdfMember("PRES")]
        public PresenceMode mPresenceMode;

        [TdfMember("PSAS")]
        public string mPingSiteAlias;

        [TdfMember("QCAP")]
        public ushort mQueueCapacity;

        [TdfMember("SEED")]
        public uint mSharedSeed;

        [TdfMember("TCAP")]
        public ushort mTeamCapacity;

        [TdfMember("THST")]
        public HostInfo mTopologyHostInfo;

        [TdfMember("TIDS")]
        public List<ushort> mTeamIds;

        [TdfMember("UUID")]
        public string mUUID;

        [TdfMember("VOIP")]
        public VoipTopology mVoipNetwork;

        [TdfMember("VSTR")]
        public string mGameProtocolVersionString;

        [TdfMember("XNNC")]
        public byte[] mXnetNonce;

        [TdfMember("XSES")]
        public byte[] mXnetSession;

    }
}
