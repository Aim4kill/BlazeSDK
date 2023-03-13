using Tdf;

namespace Blaze3SDK.Blaze.Authentication
{
    [TdfStruct]
    public struct SessionInfo
    {
        /*
          Blaze::TdfMemberInfoInt64 mBlazeUserIdDef;
          Blaze::TdfMemberInfoInt mIsFirstLoginDef;
          Blaze::TdfMemberInfoString mSessionKeyDef;
          Blaze::TdfMemberInfoInt64 mLastLoginDateTimeDef;
          Blaze::TdfMemberInfoString mEmailDef;
          Blaze::TdfMemberInfoClass mPersonaDetailsDef;
          Blaze::TdfMemberInfoInt64 mUserIdDef;

            TdfInt(__int64) BUID = 0
	        TdfBool FRST = 0
	        TdfString KEY = (const char*)37007354
	        TdfInt(__int64) LLOG = 0
	        TdfString MAIL = (const char*)37007354
	        TdfClass PDTL
	        TdfInt(__int64) UID = 0

          Blaze::TdfString mSessionKey;
          __int64 mBlazeUserId;
          __int64 mUserId;
          Blaze::TdfString mEmail;
          bool mIsFirstLogin;
          __int64 mLastLoginDateTime;
          Blaze::Authentication::PersonaDetails mPersonaDetails;
         */

        [TdfMember("BUID")]
        public long mBlazeUserId;

        [TdfMember("FRST")]
        public bool mIsFirstLogin;

        [TdfMember("KEY")]
        public string mSessionKey;

        [TdfMember("LLOG")]
        public long mLastLoginDateTime;

        [TdfMember("MAIL")]
        public string mEmail;

        [TdfMember("PDTL")]
        public PersonaDetails mPersonaDetails;

        [TdfMember("UID")]
        public long mUserId;
    }
}
