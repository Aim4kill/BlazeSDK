using Tdf;

namespace Blaze3SDK.Blaze.Authentication
{
    [TdfStruct]
    public struct AccountInfo
    {
        /*
        	TdfBool AMU = 0
			TdfString ASRC = (const char*)37007354
			TdfString CO = (const char*)37007354
			TdfString DOB = (const char*)37007354
			TdfString DTCR = (const char*)37007354
			TdfInt(int8) GOPT = -1
			TdfString LATH = (const char*)37007354
			TdfString LN = (const char*)37007354
			TdfString MAIL = (const char*)37007354
			TdfString PML = (const char*)37007354
			TdfEnum RC = 0 from (Blaze::TdfEnumMap*)44653544
			TdfEnum STAS = 0 from (Blaze::TdfEnumMap*)44653496
			TdfEnum STAT = 0 from (Blaze::TdfEnumMap*)44653504
			TdfString TOSV = (const char*)37007354
			TdfInt(int8) TPOT = -1
			TdfBool UDU = 0
			TdfInt(__int64) UID = 0

			
		  Blaze::TdfMemberInfoInt mAnonymousUserDef;
		  Blaze::TdfMemberInfoString mAuthenticationSourceDef;
		  Blaze::TdfMemberInfoString mCountryDef;
		  Blaze::TdfMemberInfoString mDOBDef;
		  Blaze::TdfMemberInfoString mDateCreatedDef;
		  Blaze::TdfMemberInfoInt mGlobalOptinDef;
		  Blaze::TdfMemberInfoString mLastAuthDef;
		  Blaze::TdfMemberInfoString mLanguageDef;
		  Blaze::TdfMemberInfoString mEmailDef;
		  Blaze::TdfMemberInfoString mParentalEmailDef;
		  Blaze::TdfMemberInfoEnum mReasonCodeDef;
		  Blaze::TdfMemberInfoEnum mStatusDef;
		  Blaze::TdfMemberInfoEnum mEmailStatusDef;
		  Blaze::TdfMemberInfoString mTosVersionDef;
		  Blaze::TdfMemberInfoInt mThirdPartyOptinDef;
		  Blaze::TdfMemberInfoInt mUnderageUserDef;
		  Blaze::TdfMemberInfoInt64 mUserIdDef;

		  __int64 mUserId;
		  Blaze::TdfString mEmail;
		  Blaze::Authentication::EmailStatus::Code mEmailStatus;
		  Blaze::TdfString mDOB;
		  Blaze::TdfString mCountry;
		  Blaze::TdfString mLanguage;
		  Blaze::TdfString mTosVersion;
		  Blaze::TdfString mParentalEmail;
		  Blaze::Authentication::AccountStatus::Code mStatus;
		  Blaze::Authentication::StatusReason::Code mReasonCode;
		  char mGlobalOptin;
		  char mThirdPartyOptin;
		  Blaze::TdfString mLastAuth;
		  Blaze::TdfString mAuthenticationSource;
		  Blaze::TdfString mDateCreated;
		  bool mAnonymousUser;
		  bool mUnderageUser;
         */

        [TdfMember("AMU")]
        public bool mAnonymousUser;

        [TdfMember("ASRC")]
        public string mAuthenticationSource;

        [TdfMember("CO")]
        public string mCountry;

        [TdfMember("DOB")]
        public string mDOB;

        [TdfMember("DTCR")]
        public string mDateCreated;

        [TdfMember("GOPT")]
        public byte mGlobalOptin;

        [TdfMember("LATH")]
        public string mLastAuth;

        [TdfMember("LN")]
        public string mLanguage;

        [TdfMember("MAIL")]
        public string mEmail;

        [TdfMember("PML")]
        public string mParentalEmail;

        [TdfMember("RC")]
        public StatusReason mReasonCode;

        [TdfMember("STAS")]
        public AccountStatus mStatus;

        [TdfMember("STAT")]
        public EmailStatus mEmailStatus;

        [TdfMember("TOSV")]
        public string mTosVersion;

        [TdfMember("TPOT")]
        public byte mThirdPartyOptin;

        [TdfMember("UDU")]
        public bool mUnderageUser;

        [TdfMember("UID")]
        public long mUserId;
    }
}
