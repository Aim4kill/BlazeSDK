using Tdf;

namespace Blaze3SDK.Blaze.GameReporting.Frostbite
{
    [TdfStruct(3377573273)]
    public struct EntityReport
    {
        /*
        Blaze::GameReporting::Frostbite::EntityReport {
	        TdfMap STAT
        }

        struct __cppobj Blaze::GameReporting::Frostbite::EntityReport : Blaze::Tdf
        {
          Blaze::TdfPrimitiveMap<Blaze::TdfString,float,1,10,0,0,Blaze::TdfStringCompareIgnoreCase> mStats;
        };


         */

        [TdfMember("STAT")]
        public SortedDictionary<string, float> mStats;
    }
}