using Tdf;

namespace Blaze3SDK.Blaze.Stats
{
    [TdfStruct]
    public struct EntityStatAggregates
    {

        /*
        Blaze::Stats::EntityStatAggregates {
	        TdfList AGGR
	        TdfEnum TYPE = 0 from (Blaze::TdfEnumMap*)44654468
        }

        struct Blaze::Stats::EntityStatAggregates::TdfMemberInfoDefinition
        {
          Blaze::TdfMemberInfo mAggrValuesDef;
          Blaze::TdfMemberInfoEnum mTypeDef;
        };

        struct __cppobj Blaze::Stats::EntityStatAggregates : Blaze::Tdf
        {
          Blaze::Stats::AggregateType mType;
          Blaze::TdfPrimitiveVector<Blaze::TdfString,1,0> mAggrValues;
        };


         */

        [TdfMember("AGGR")]
        public List<string> mAggrValues;

        [TdfMember("TYPE")]
        public AggregateType mType;
    }
}