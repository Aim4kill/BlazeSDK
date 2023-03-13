using Tdf;

namespace Blaze3SDK.Blaze.Stats
{
    [TdfStruct]
    public struct GetStatsByGroupRequest
    {
        /*
        Blaze::Stats::GetStatsByGroupRequest {
			TdfBitSet AGGR
			TdfList EID
			TdfMap KSUM
			TdfString NAME = (const char*)37007354
			TdfInt(int) PCTR = 16777216
			TdfInt(int) POFF = 0
			TdfInt(int) PTYP = 0
			TdfInt(int) TIME = 0
			TdfInt(unsigned int) VID = 0
		}

		struct Blaze::Stats::GetStatsByGroupRequest::TdfMemberInfoDefinition
		{
		  Blaze::TdfMemberInfo mAggrFlagsDef;
		  Blaze::TdfMemberInfo mEntityIdsDef;
		  Blaze::TdfMemberInfo mKeyScopeNameValueMapDef;
		  Blaze::TdfMemberInfoString mGroupNameDef;
		  Blaze::TdfMemberInfoInt mPeriodCtrDef;
		  Blaze::TdfMemberInfoInt mPeriodOffsetDef;
		  Blaze::TdfMemberInfoInt mPeriodTypeDef;
		  Blaze::TdfMemberInfoInt mTimeDef;
		  Blaze::TdfMemberInfoInt mViewIdDef;
		};



		struct __cppobj Blaze::Stats::GetStatsByGroupRequest : Blaze::Tdf
		{
		  Blaze::TdfString mGroupName;
		  Blaze::TdfPrimitiveVector<__int64,0,0> mEntityIds;
		  int mPeriodType;
		  int mPeriodOffset;
		  int mPeriodCtr;
		  Blaze::TdfPrimitiveMap<Blaze::TdfString,__int64,1,0,0,0,Blaze::TdfStringCompareIgnoreCase> mKeyScopeNameValueMap;
		  unsigned int mViewId;
		  Blaze::Stats::AggregateCalcFlags mAggrFlags;
		  int mTime;
		};

         */

        [TdfMember("AGGR")]
        public AggregateCalcFlags mAggrFlags;

        [TdfMember("EID")]
        public List<long> mEntityIds;

        [TdfMember("KSUM")]
        public SortedDictionary<string, long> mKeyScopeNameValueMap;

        [TdfMember("NAME")]
        public string mGroupName;

        [TdfMember("PCTR")]
        public int mPeriodCtr;

        [TdfMember("POFF")]
        public int mPeriodOffset;

        [TdfMember("PTYP")]
        public int mPeriodType;

        [TdfMember("TIME")]
        public int mTime;

        [TdfMember("VID")]
        public uint mViewId;
    }
}
