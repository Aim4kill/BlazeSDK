using Tdf;

namespace Blaze3SDK.Blaze.GameReporting
{
    [TdfStruct]
    public struct GameReportType
    {

        /*
        
        Blaze::GameReporting::GameReportType {
	        TdfString GTNA = (const char*)37007354
	        TdfList HIST
        }

        struct Blaze::GameReporting::GameReportType::TdfMemberInfoDefinition
        {
          Blaze::TdfMemberInfoString mGameTypeNameDef;
          Blaze::TdfMemberInfo mHistoryTablesDef;
        };

        
        struct __cppobj Blaze::GameReporting::GameReportType : Blaze::Tdf
        {
          Blaze::TdfString mGameTypeName;
          Blaze::TdfStructVector<Blaze::GameReporting::TableData,Blaze::TdfTdfVectorBase> mHistoryTables;
        };

        
         */

        [TdfMember("GTNA")]
        public string mGameTypeName;

        [TdfMember("HIST")]
        public List<TableData> mHistoryTables;
    }
}