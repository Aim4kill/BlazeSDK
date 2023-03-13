using Tdf;

namespace Blaze3SDK.Blaze.Authentication
{
    [TdfStruct]
    public struct ExpressLoginRequest
    {
        /*
            Blaze::Authentication::ExpressLoginRequest {
	            TdfString MAIL = (const char*)37007354
	            TdfString PASS = (const char*)37007354
	            TdfString PNAM = (const char*)37007354
            }

            struct __cppobj Blaze::Authentication::ExpressLoginRequest : Blaze::Tdf
            {
              Blaze::TdfString mEmail;
              Blaze::TdfString mPassword;
              Blaze::TdfString mPersonaName;
            };

         */

        [TdfMember("MAIL")]
        public string mEmail;

        [TdfMember("PASS")]
        public string mPassword;

        [TdfMember("PNAM")]
        public string mPersonaName;

    }
}
