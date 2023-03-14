using Tdf;

namespace Blaze3SDK.Blaze.GameManager
{
    [TdfStruct]
    public struct MatchmakingCriteriaData
    {
        /*
        
        Blaze::GameManager::MatchmakingCriteriaData {
	        TdfClass CUST
	        TdfClass DNF
	        TdfClass GEO
	        TdfClass GNAM
	        TdfClass NAT
	        TdfClass PSR
	        TdfClass RANK
	        TdfList RLST
	        TdfClass RSZR
	        TdfClass SIZE
	        TdfList SKLZ
	        TdfClass TEAM
	        TdfMap UED
	        TdfClass VIAB
	        TdfClass VIRT
        }

        struct Blaze::GameManager::MatchmakingCriteriaData::TdfMemberInfoDefinition
        {
          Blaze::TdfMemberInfoClass mCustomRulePrefsDef;
          Blaze::TdfMemberInfoClass mDNFRulePrefsDef;
          Blaze::TdfMemberInfoClass mGeoLocationRuleCriteriaDef;
          Blaze::TdfMemberInfoClass mGameNameRuleCriteriaDef;
          Blaze::TdfMemberInfoClass mHostBalancingRulePrefsDef;
          Blaze::TdfMemberInfoClass mPingSiteRulePrefsDef;
          Blaze::TdfMemberInfoClass mRankedGameRulePrefsDef;
          Blaze::TdfMemberInfo mGenericRulePrefsListDef;
          Blaze::TdfMemberInfoClass mRosterSizeRulePrefsDef;
          Blaze::TdfMemberInfoClass mGameSizeRulePrefsDef;
          Blaze::TdfMemberInfo mSkillRulePrefsListDef;
          Blaze::TdfMemberInfoClass mTeamSizeRulePrefsDef;
          Blaze::TdfMemberInfo mUEDRuleCriteriaMapDef;
          Blaze::TdfMemberInfoClass mHostViabilityRulePrefsDef;
          Blaze::TdfMemberInfoClass mVirtualGameRulePrefsDef;
        };

        struct __cppobj Blaze::GameManager::MatchmakingCriteriaData : Blaze::Tdf
        {
          Blaze::GameManager::RankedGameRulePrefs mRankedGameRulePrefs;
          Blaze::GameManager::VirtualGameRulePrefs mVirtualGameRulePrefs;
          Blaze::GameManager::GameSizeRulePrefs mGameSizeRulePrefs;
          Blaze::GameManager::TeamSizeRulePrefs mTeamSizeRulePrefs;
          Blaze::GameManager::HostBalancingRulePrefs mHostBalancingRulePrefs;
          Blaze::GameManager::HostViabilityRulePrefs mHostViabilityRulePrefs;
          Blaze::TdfStructVector<Blaze::GameManager::SkillRulePrefs,Blaze::TdfTdfVectorBase> mSkillRulePrefsList;
          Blaze::GameManager::DNFRulePrefs mDNFRulePrefs;
          Blaze::GameManager::PingSiteRulePrefs mPingSiteRulePrefs;
          Blaze::TdfStructVector<Blaze::GameManager::GenericRulePrefs,Blaze::TdfTdfVectorBase> mGenericRulePrefsList;
          Blaze::GameManager::RosterSizeRulePrefs mRosterSizeRulePrefs;
          Blaze::GameManager::GeoLocationRuleCriteria mGeoLocationRuleCriteria;
          Blaze::GameManager::GameNameRuleCriteria mGameNameRuleCriteria;
          Blaze::TdfStructMap<Blaze::TdfString,Blaze::GameManager::UEDRuleCriteria,1,3,Blaze::TdfTdfMapBase,0,Blaze::TdfStringCompareIgnoreCase> mUEDRuleCriteriaMap;
          Blaze::GameManager::MatchmakingCustomCriteriaData mCustomRulePrefs;
        };

         */

        [TdfMember("CUST")]
        public MatchmakingCustomCriteriaData mCustomRulePrefs;

        [TdfMember("DNF")]
        public DNFRulePrefs mDNFRulePrefs;

        [TdfMember("GEO")]
        public GeoLocationRuleCriteria mGeoLocationRuleCriteria;

        [TdfMember("GNAM")]
        public GameNameRuleCriteria mGameNameRuleCriteria;

        [TdfMember("NAT")]
        public HostBalancingRulePrefs mHostBalancingRulePrefs;

        [TdfMember("PSR")]
        public PingSiteRulePrefs mPingSiteRulePrefs;

        [TdfMember("RANK")]
        public RankedGameRulePrefs mRankedGameRulePrefs;

        [TdfMember("RLST")]
        public List<GenericRulePrefs> mGenericRulePrefsList;

        [TdfMember("RSZR")]
        public RosterSizeRulePrefs mRosterSizeRulePrefs;

        [TdfMember("SIZE")]
        public GameSizeRulePrefs mGameSizeRulePrefs;

        [TdfMember("SKLZ")]
        public List<SkillRulePrefs> mSkillRulePrefsList;

        [TdfMember("TEAM")]
        public TeamSizeRulePrefs mTeamSizeRulePrefs;

        [TdfMember("UED")]
        public SortedDictionary<string, UEDRuleCriteria> mUEDRuleCriteriaMap;

        [TdfMember("VIAB")]
        public HostViabilityRulePrefs mHostViabilityRulePrefs;

        [TdfMember("VIRT")]
        public VirtualGameRulePrefs mVirtualGameRulePrefs;
        
    }
}
