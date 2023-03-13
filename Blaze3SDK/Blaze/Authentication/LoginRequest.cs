using Tdf;

namespace Blaze3SDK.Blaze.Authentication
{
    [TdfStruct]
    public struct LoginRequest
    {
        /*
              Blaze::TdfMemberInfoInt64 mDeviceIdDef;
              Blaze::TdfMemberInfoString mEmailDef;
              Blaze::TdfMemberInfoString mPasswordDef;
              Blaze::TdfMemberInfoString mTokenDef;
              Blaze::TdfMemberInfoEnum mTokenTypeDef;

        	TdfInt(unsigned __int64) DVID = 0
	        TdfString MAIL = (const char*)37007354
	        TdfString PASS = (const char*)37007354
	        TdfString TOKN = (const char*)37007354
	        TdfEnum TYPE = 16777216 from (Blaze::TdfEnumMap*)44651792
         */

        [TdfMember("DVID")]
        public ulong mDeviceId;

        [TdfMember("MAIL")]
        public string mEmail;

        [TdfMember("PASS")]
        public string mPassword;

        [TdfMember("TOKN")]
        public string mToken;

        [TdfMember("TYPE")]
        public TOKENTYPE mTokenType;

    }
}
