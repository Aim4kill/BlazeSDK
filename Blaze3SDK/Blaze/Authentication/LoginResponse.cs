using Tdf;

namespace Blaze3SDK.Blaze.Authentication
{
    [TdfStruct]
    public struct LoginResponse
    {
        /*
              Blaze::TdfMemberInfoString mLegalDocHostDef;
              Blaze::TdfMemberInfoInt mNeedsLegalDocDef;
              Blaze::TdfMemberInfoString mPCLoginTokenDef;
              Blaze::TdfMemberInfo mPersonaDetailsListDef;
              Blaze::TdfMemberInfoString mPrivacyPolicyUriDef;
              Blaze::TdfMemberInfoString mSessionKeyDef;
              Blaze::TdfMemberInfoInt mIsOfLegalContactAgeDef;
              Blaze::TdfMemberInfoString mTosHostDef;
              Blaze::TdfMemberInfoString mTermsOfServiceUriDef;
              Blaze::TdfMemberInfoString mTosUriDef;
              Blaze::TdfMemberInfoInt64 mUserIdDef;


        	TdfString LDHT = (const char*)37007354
	        TdfBool NTOS = 0
	        TdfString PCTK = (const char*)37007354
	        TdfList PLST
	        TdfString PRIV = (const char*)37007354
	        TdfString SKEY = (const char*)37007354
	        TdfBool SPAM = 0
	        TdfString THST = (const char*)37007354
	        TdfString TSUI = (const char*)37007354
	        TdfString TURI = (const char*)37007354
	        TdfInt(__int64) UID = 0

          __int64 mUserId;
          Blaze::TdfString mPCLoginToken;
          Blaze::TdfStructVector<Blaze::Authentication::PersonaDetails,Blaze::TdfTdfVectorBase> mPersonaDetailsList;
          Blaze::TdfString mTosUri;
          Blaze::TdfString mTermsOfServiceUri;
          Blaze::TdfString mPrivacyPolicyUri;
          Blaze::TdfString mLegalDocHost;
          Blaze::TdfString mTosHost;
          Blaze::TdfString mSessionKey;
          bool mIsOfLegalContactAge;
          bool mNeedsLegalDoc;
         */

        [TdfMember("LDHT")]
        public string mLegalDocHost;

        [TdfMember("NTOS")]
        public bool mNeedsLegalDoc;

        [TdfMember("PCTK")]
        public string mPCLoginToken;

        [TdfMember("PLST")]
        public List<PersonaDetails> mPersonaDetailsList;

        [TdfMember("PRIV")]
        public string mPrivacyPolicyUri;

        [TdfMember("SKEY")]
        public string mSessionKey;

        [TdfMember("SPAM")]
        public bool mIsOfLegalContactAge;

        [TdfMember("THST")]
        public string mTosHost;

        [TdfMember("TSUI")]
        public string mTermsOfServiceUri;

        [TdfMember("TURI")]
        public string mTosUri;

        [TdfMember("UID")]
        public long mUserId;

    }
}
