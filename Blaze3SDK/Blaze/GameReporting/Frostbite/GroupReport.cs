using Tdf;

namespace Blaze3SDK.Blaze.GameReporting.Frostbite
{
    [TdfStruct(1911783857)]
    public struct GroupReport
    {

        /*
        Blaze::GameReporting::Frostbite::GroupReport {
	        TdfMap ATRB
	        TdfMap PLYR
        }

        struct Blaze::GameReporting::Frostbite::GroupReport::TdfMemberInfoDefinition
        {
          Blaze::TdfMemberInfo mStatsDef;
          Blaze::TdfMemberInfo mPlayerReportsDef;
        };


        struct __cppobj Blaze::GameReporting::Frostbite::GroupReport : Blaze::Tdf
        {
          Blaze::TdfPrimitiveMap<Blaze::TdfString,float,1,10,0,0,Blaze::TdfStringCompareIgnoreCase> mStats;
          Blaze::TdfStructMap<__int64,Blaze::GameReporting::Frostbite::EntityReport,0,3,Blaze::TdfTdfMapBase,0,eastl::less<__int64> > mPlayerReports;
        };


         */

        [TdfMember("ATRB")]
        public SortedDictionary<string, float> mStats;

        [TdfMember("PLYR")]
        public SortedDictionary<long, EntityReport> mPlayerReports;
    }
}