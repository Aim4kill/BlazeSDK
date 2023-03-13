using Tdf;

namespace Blaze3SDK.Blaze.Authentication
{
    [TdfStruct]
    public struct PersonaDetails
    {
        /*
          Blaze::TdfMemberInfoString mDisplayNameDef;
          Blaze::TdfMemberInfoInt mLastAuthenticatedDef;
          Blaze::TdfMemberInfoInt64 mPersonaIdDef;
          Blaze::TdfMemberInfoEnum mStatusDef;
          Blaze::TdfMemberInfoInt64 mExtIdDef;
          Blaze::TdfMemberInfoEnum mExtTypeDef;

        
        	TdfString DSNM = (const char*)37007354
	        TdfInt(unsigned int) LAST = 0
	        TdfInt(__int64) PID = 0
	        TdfEnum STAS = 0 from (Blaze::TdfEnumMap*)44653520
	        TdfInt(unsigned __int64) XREF = 0
	        TdfEnum XTYP = 0 from (Blaze::TdfEnumMap*)44653568

          __int64 mPersonaId;
          Blaze::TdfString mDisplayName;
          unsigned __int64 mExtId;
          Blaze::Authentication::ExternalRefType::Code mExtType;
          unsigned int mLastAuthenticated;
          Blaze::Authentication::PersonaStatus::Code mStatus;
         */

        [TdfMember("DSNM")]
        public string mDisplayName;

        [TdfMember("LAST")]
        public uint mLastAuthenticated;

        [TdfMember("PID")]
        public long mPersonaId;

        [TdfMember("STAS")]
        public PersonaStatus mStatus;

        [TdfMember("XREF")]
        public ulong mExtId;

        [TdfMember("XTYP")]
        public ExternalRefType mExtType;
    }
}
