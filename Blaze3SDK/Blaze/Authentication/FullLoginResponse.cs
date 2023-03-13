using Tdf;

namespace Blaze3SDK.Blaze.Authentication
{
    [TdfStruct]
    public struct FullLoginResponse
    {
        /*
            struct __cppobj __declspec(align(2)) Blaze::Authentication::FullLoginResponse : Blaze::Tdf
            {
              Blaze::TdfString mPCLoginToken;
              Blaze::Authentication::SessionInfo mSessionInfo;
              Blaze::TdfString mTosUri;
              Blaze::TdfString mTermsOfServiceUri;
              Blaze::TdfString mPrivacyPolicyUri;
              Blaze::TdfString mTosHost;
              Blaze::TdfString mLegalDocHost;
              bool mCanAgeUp;
              bool mIsOfLegalContactAge;
              bool mNeedsLegalDoc;
            };

            struct Blaze::Authentication::FullLoginResponse::TdfMemberInfoDefinition
            {
              Blaze::TdfMemberInfoInt mCanAgeUpDef;
              Blaze::TdfMemberInfoString mLegalDocHostDef;
              Blaze::TdfMemberInfoInt mNeedsLegalDocDef;
              Blaze::TdfMemberInfoString mPCLoginTokenDef;
              Blaze::TdfMemberInfoString mPrivacyPolicyUriDef;
              Blaze::TdfMemberInfoClass mSessionInfoDef;
              Blaze::TdfMemberInfoInt mIsOfLegalContactAgeDef;
              Blaze::TdfMemberInfoString mTosHostDef;
              Blaze::TdfMemberInfoString mTermsOfServiceUriDef;
              Blaze::TdfMemberInfoString mTosUriDef;
            };

            Blaze::Authentication::FullLoginResponse {
	            TdfBool AGUP = 0
	            TdfString LDHT = (const char*)37007354
	            TdfBool NTOS = 0
	            TdfString PCTK = (const char*)37007354
	            TdfString PRIV = (const char*)37007354
	            TdfClass SESS
	            TdfBool SPAM = 0
	            TdfString THST = (const char*)37007354
	            TdfString TSUI = (const char*)37007354
	            TdfString TURI = (const char*)37007354
            }

         */

        [TdfMember("AGUP")]
        public bool mCanAgeUp;

        [TdfMember("LDHT")]
        public string mLegalDocHost;

        [TdfMember("NTOS")]
        public bool mNeedsLegalDoc;

        [TdfMember("PCTK")]
        public string mPCLoginToken;

        [TdfMember("PRIV")]
        public string mPrivacyPolicyUri;

        [TdfMember("SESS")]
        public SessionInfo mSessionInfo;

        [TdfMember("SPAM")]
        public bool mIsOfLegalContactAge;

        [TdfMember("THST")]
        public string mTosHost;

        [TdfMember("TSUI")]
        public string mTermsOfServiceUri;

        [TdfMember("TURI")]
        public string mTosUri;
    }
}
