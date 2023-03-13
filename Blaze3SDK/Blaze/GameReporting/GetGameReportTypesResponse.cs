using Tdf;

namespace Blaze3SDK.Blaze.GameReporting
{
    [TdfStruct]
    public struct GetGameReportTypesResponse
    {

        /*
        
        Blaze::GameReporting::GetGameReportTypesResponse {
	        TdfList GRTS
        }

        
        struct __cppobj Blaze::GameReporting::GetGameReportTypesResponse : Blaze::Tdf
        {
          Blaze::TdfStructVector<Blaze::GameReporting::GameReportType,Blaze::TdfTdfVectorBase> mGameReportTypes;
        };


        struct Blaze::GameReporting::GetGameReportTypesResponse::TdfMemberInfoDefinition
        {
          Blaze::TdfMemberInfo mGameReportTypesDef;
        };

         */

        [TdfMember("GRTS")]
        public List<GameReportType> mGameReportTypes;

    }
}
