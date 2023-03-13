using Tdf;

namespace Blaze3SDK.Blaze.Util
{
    [TdfStruct]
    public struct PostAuthResponse
    {
        /*
          	TdfClass PSS
	        TdfClass TELE
	        TdfClass TICK
	        TdfClass UROP

          Blaze::Util::PssConfig mPssConfig;
          Blaze::Util::GetTelemetryServerResponse mTelemetryServer;
          Blaze::Util::GetTickerServerResponse mTickerServer;
          Blaze::Util::UserOptions mUserOptions;
         */

        [TdfMember("PSS")]
        public PssConfig mPssConfig;

        [TdfMember("TELE")]
        public GetTelemetryServerResponse mTelemetryServer;

        [TdfMember("TICK")]
        public GetTickerServerResponse mTickerServer;

        [TdfMember("UROP")]
        public UserOptions mUserOptions;
    }
}
