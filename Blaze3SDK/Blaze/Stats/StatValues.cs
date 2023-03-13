using Tdf;

namespace Blaze3SDK.Blaze.Stats
{
    [TdfStruct]
    public struct StatValues
    {
        /*
         * 
        Blaze::Stats::StatValues {
	        TdfList AGGR
	        TdfList STAT
        }

        struct Blaze::Stats::StatValues::TdfMemberInfoDefinition
        {
          Blaze::TdfMemberInfo mEntityAggrListDef;
          Blaze::TdfMemberInfo mEntityStatsListDef;
        };

        struct __cppobj Blaze::Stats::StatValues : Blaze::Tdf
        {
          Blaze::TdfStructVector<Blaze::Stats::EntityStats,Blaze::TdfTdfVectorBase> mEntityStatsList;
          Blaze::TdfStructVector<Blaze::Stats::EntityStatAggregates,Blaze::TdfTdfVectorBase> mEntityAggrList;
        };

         */

        [TdfMember("AGGR")]
        public List<EntityStatAggregates> mEntityAggrList;

        [TdfMember("STAT")]
        public List<EntityStats> mEntityStatsList;
    }
}