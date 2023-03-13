using Tdf;

namespace Blaze3SDK.Blaze.GameReporting
{
    [TdfStruct]
    public struct GameReport
    {
        /*
        Blaze::GameReporting::GameReport {
	        TODO-Blaze::VariableTdfBase GAME
	        TdfInt(unsigned __int64) GRID = 0
	        TdfString GTYP = (const char*)37007354
        }

        struct Blaze::GameReporting::GameReport::TdfMemberInfoDefinition
        {
          Blaze::TdfMemberInfo mReportDef;
          Blaze::TdfMemberInfoInt64 mGameReportingIdDef;
          Blaze::TdfMemberInfoString mGameTypeNameDef;
        };

        struct __cppobj Blaze::GameReporting::GameReport : Blaze::Tdf
        {
          unsigned __int64 mGameReportingId;
          Blaze::TdfString mGameTypeName;
          Blaze::VariableTdfBase mReport;
        };


         */

        [TdfMember("GAME")]
        public object? mReport;

        [TdfMember("GRID")]
        public ulong mGameReportingId;

        [TdfMember("GTYP")]
        public string mGameTypeName;

    }
}