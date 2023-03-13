using Tdf;

namespace Blaze3SDK.Blaze.GameReporting.Frostbite
{
    [TdfStruct(2014491990)]
    public struct Report
    {
        /*
        
        Blaze::GameReporting::Frostbite::Report {
	        TdfMap CLBS
	        TdfMap GAME
	        TdfMap PLYR
        }

        struct Blaze::GameReporting::Frostbite::Report::TdfMemberInfoDefinition
        {
          Blaze::TdfMemberInfo mGroupReportsDef;
          Blaze::TdfMemberInfo mGameAttributesDef;
          Blaze::TdfMemberInfo mPlayerReportsDef;
        };

        struct __cppobj Blaze::GameReporting::Frostbite::Report : Blaze::Tdf
        {
          Blaze::TdfPrimitiveMap<Blaze::TdfString,Blaze::TdfString,1,1,0,0,Blaze::TdfStringCompareIgnoreCase> mGameAttributes;
          Blaze::TdfStructMap<__int64,Blaze::GameReporting::Frostbite::EntityReport,0,3,Blaze::TdfTdfMapBase,0,eastl::less<__int64> > mPlayerReports;
          Blaze::TdfStructMap<unsigned int,Blaze::GameReporting::Frostbite::GroupReport,0,3,Blaze::TdfTdfMapBase,0,eastl::less<unsigned int> > mGroupReports;
        };


         */

        [TdfMember("CLBS")]
        public SortedDictionary<uint, GroupReport> mGroupReports;

        [TdfMember("GAME")]
        public SortedDictionary<string, string> mGameAttributes;

        [TdfMember("PLYR")]
        public SortedDictionary<long, EntityReport> mPlayerReports;

    }
}
