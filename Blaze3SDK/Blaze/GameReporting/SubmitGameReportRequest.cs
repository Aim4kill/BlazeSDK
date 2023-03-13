using Tdf;

namespace Blaze3SDK.Blaze.GameReporting
{
    [TdfStruct]
    public struct SubmitGameReportRequest
    {
        /*
        Blaze::GameReporting::SubmitGameReportRequest {
	        TdfEnum FNSH = 0 from (Blaze::TdfEnumMap*)44652132
	        TODO-Blaze::VariableTdfBase PRVT
	        TdfClass RPRT
        }

        struct Blaze::GameReporting::SubmitGameReportRequest::TdfMemberInfoDefinition
        {
          Blaze::TdfMemberInfoEnum mFinishedStatusDef;
          Blaze::TdfMemberInfo mPrivateReportDef;
          Blaze::TdfMemberInfoClass mGameReportDef;
        };

        struct __cppobj Blaze::GameReporting::SubmitGameReportRequest : Blaze::Tdf
        {
          Blaze::GameReporting::GameReport mGameReport;
          Blaze::GameReporting::GameReportPlayerFinishedStatus mFinishedStatus;
          Blaze::VariableTdfBase mPrivateReport;
        };

         */

        [TdfMember("FNSH")]
        public GameReportPlayerFinishedStatus mFinishedStatus;

        [TdfMember("PRVT")]
        public object? mPrivateReport;

        [TdfMember("RPRT")]
        public GameReport mGameReport;
    }
}
