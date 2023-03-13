using Tdf;

namespace Blaze3SDK.Blaze.Stats
{
    [TdfStruct]
    public struct EntityStats
    {
        /*
        
        Blaze::Stats::EntityStats {
	        TdfInt(__int64) EID = 0
	        TODO-Blaze::BlazeObjectType ETYP
	        TdfInt(int) POFF = 0
	        TdfList STAT
        }

        struct Blaze::Stats::EntityStats::TdfMemberInfoDefinition
        {
          Blaze::TdfMemberInfoInt mEntityIdDef;
          Blaze::TdfMemberInfo mEntityTypeDef;
          Blaze::TdfMemberInfoInt mPeriodOffsetDef;
          Blaze::TdfMemberInfo mStatValuesDef;
        };

        struct __cppobj __declspec(align(8)) Blaze::Stats::EntityStats : Blaze::Tdf
        {
          __int64 mEntityId;
          Blaze::BlazeObjectType mEntityType;
          int mPeriodOffset;
          Blaze::TdfPrimitiveVector<Blaze::TdfString,1,0> mStatValues;
        };


         */

        [TdfMember("EID")]
        public long mEntityId;

        [TdfMember("ETYP")]
        public BlazeObjectType mEntityType;

        [TdfMember("POFF")]
        public int mPeriodOffset;

        [TdfMember("STAT")]
        public List<string> mStatValues;
    }
}