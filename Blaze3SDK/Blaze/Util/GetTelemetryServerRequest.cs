using Tdf;

namespace Blaze3SDK.Blaze.Util
{
    [TdfStruct]
    public struct GetTelemetryServerRequest
    {
        /*
          	TdfString CMAC = (const char*)37007354
	        TdfString SNAM = (const char*)37007354

            Blaze::TdfString mMacAddress;
            Blaze::TdfString mServiceName;

            Blaze::TdfMemberInfoString mMacAddressDef;
            Blaze::TdfMemberInfoString mServiceNameDef;
         */

        [TdfMember("CMAC")]
        public string mMacAddress;

        [TdfMember("SNAM")]
        public string mServiceName;
    }
}
