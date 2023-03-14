using Tdf;

namespace Blaze3SDK.Blaze.GameManager
{
    [TdfStruct]
    public struct StartMatchmakingRequest
    {
        /*
        Blaze::GameManager::StartMatchmakingRequest {
			TdfMap ATTR
			TdfVector3 BTPL
			TdfClass CRIT
			TdfInt(unsigned int) DUR = 0
			TdfMap ECRI
			TdfEnum GENT = 0 from (Blaze::TdfEnumMap*)44649928
			TdfString GNAM = (const char*)37007354
			TdfBitSet GSET
			TdfString GVER = (const char*)37007354
			TdfBool IGNO = 0
			TdfBitSet MODE
			TdfEnum NTOP = 0 from (Blaze::TdfEnumMap*)44653752
			TdfMap PATT
			TdfList PLST
			TdfInt(unsigned __int16) PMAX = 0
			TdfUnion PNET
			TdfInt(unsigned __int16) QCAP = 0
			TdfList SIDL
			TdfEnum VOIP = 0 from (Blaze::TdfEnumMap*)44653760
		}

		struct Blaze::GameManager::StartMatchmakingRequest::TdfMemberInfoDefinition
		{
		  Blaze::TdfMemberInfo mGameAttribsDef;
		  Blaze::TdfMemberInfo mGroupIdDef;
		  Blaze::TdfMemberInfoClass mCriteriaDataDef;
		  Blaze::TdfMemberInfoInt mSessionDurationMSDef;
		  Blaze::TdfMemberInfo mEntryCriteriaMapDef;
		  Blaze::TdfMemberInfoEnum mGameEntryTypeDef;
		  Blaze::TdfMemberInfoString mGameNameDef;
		  Blaze::TdfMemberInfo mGameSettingsDef;
		  Blaze::TdfMemberInfoString mGameProtocolVersionStringDef;
		  Blaze::TdfMemberInfoInt mIgnoreEntryCriteriaWithInviteDef;
		  Blaze::TdfMemberInfo mSessionModeDef;
		  Blaze::TdfMemberInfoEnum mNetworkTopologyDef;
		  Blaze::TdfMemberInfo mPlayerAttribsDef;
		  Blaze::TdfMemberInfo mPlayerIdListDef;
		  Blaze::TdfMemberInfoInt mMaxPlayerCapacityDef;
		  Blaze::TdfMemberInfo mPlayerNetworkAddressDef;
		  Blaze::TdfMemberInfoInt mQueueCapacityDef;
		  Blaze::TdfMemberInfo mSessionIdListDef;
		  Blaze::TdfMemberInfoEnum mVoipNetworkDef;
		};

		struct __cppobj __declspec(align(8)) Blaze::GameManager::StartMatchmakingRequest : Blaze::Tdf
		{
		  Blaze::GameManager::MatchmakingSessionMode mSessionMode;
		  Blaze::TdfString mGameProtocolVersionString;
		  unsigned int mSessionDurationMS;
		  Blaze::GameManager::MatchmakingCriteriaData mCriteriaData;
		  Blaze::TdfString mGameName;
		  Blaze::GameManager::GameSettings mGameSettings;
		  Blaze::GameNetworkTopology mNetworkTopology;
		  Blaze::VoipTopology mVoipNetwork;
		  Blaze::NetworkAddress mPlayerNetworkAddress;
		  unsigned __int16 mQueueCapacity;
		  Blaze::TdfPrimitiveMap<Blaze::TdfString,Blaze::TdfString,1,1,0,0,Blaze::TdfStringCompareIgnoreCase> mGameAttribs;
		  unsigned __int16 mMaxPlayerCapacity;
		  Blaze::TdfPrimitiveMap<Blaze::TdfString,Blaze::TdfString,1,1,0,0,Blaze::TdfStringCompareIgnoreCase> mPlayerAttribs;
		  Blaze::BlazeObjectId mGroupId;
		  Blaze::TdfPrimitiveVector<unsigned int,0,0> mSessionIdList;
		  Blaze::TdfPrimitiveMap<Blaze::TdfString,Blaze::TdfString,1,1,0,0,Blaze::TdfStringCompareIgnoreCase> mEntryCriteriaMap;
		  bool mIgnoreEntryCriteriaWithInvite;
		  Blaze::TdfPrimitiveVector<__int64,0,0> mPlayerIdList;
		  Blaze::GameManager::GameEntryType mGameEntryType;
		};

         */

        [TdfMember("ATTR")]
        public SortedDictionary<string, string> mGameAttribs;

        [TdfMember("BTPL")]
        public BlazeObjectId mGroupId;

        [TdfMember("CRIT")]
        public MatchmakingCriteriaData mCriteriaData;

        [TdfMember("DUR")]
        public uint mSessionDurationMS;

        [TdfMember("ECRI")]
        public SortedDictionary<string, string> mEntryCriteriaMap;

        [TdfMember("GENT")]
        public GameEntryType mGameEntryType;

        [TdfMember("GNAM")]
        public string mGameName;

        [TdfMember("GSET")]
        public GameSettings mGameSettings;

        [TdfMember("GVER")]
        public string mGameProtocolVersionString;

        [TdfMember("IGNO")]
        public bool mIgnoreEntryCriteriaWithInvite;

        [TdfMember("MODE")]
        public MatchmakingSessionMode mSessionMode;

        [TdfMember("NTOP")]
        public GameNetworkTopology mNetworkTopology;

        [TdfMember("PATT")]
        public SortedDictionary<string, string> mPlayerAttribs;

        [TdfMember("PLST")]
        public List<long> mPlayerIdList;

        [TdfMember("PMAX")]
        public ushort mMaxPlayerCapacity;

        [TdfMember("PNET")]
        public NetworkAddress mPlayerNetworkAddress;

        [TdfMember("QCAP")]
        public ushort mQueueCapacity;

        [TdfMember("SIDL")]
        public List<uint> mSessionIdList;

        [TdfMember("VOIP")]
        public VoipTopology mVoipNetwork;
		
    }
}
