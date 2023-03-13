using Tdf;

namespace Blaze3SDK.Blaze.Authentication
{
    [TdfStruct]
    public struct SilentLoginRequest
    {
        /*
        Blaze::Authentication::SilentLoginRequest {
	        TdfString AUTH = (const char*)37007354
	        TdfInt(__int64) PID = 0
	        TdfEnum TYPE = 16777216 from (Blaze::TdfEnumMap*)44651792
        }

        struct __cppobj __declspec(align(8)) Blaze::Authentication::SilentLoginRequest : Blaze::Tdf
        {
          Blaze::TdfString mAuthToken;
          __int64 mPersonaId;
          Blaze::Authentication::TOKENTYPE mTokenType;
        };

         */

        [TdfMember("AUTH")]
        public string mAuthToken;

        [TdfMember("PID")]
        public long mPersonaId;

        [TdfMember("TYPE")]
        public TOKENTYPE mTokenType;
    }
}
