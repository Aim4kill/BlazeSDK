using Tdf;

namespace Blaze3SDK.Blaze
{
    [TdfStruct]
    public struct UserIdentification
    {
        /*
              Blaze::TdfMemberInfoInt64 mAccountIdDef;
              Blaze::TdfMemberInfoInt mAccountLocaleDef;
              Blaze::TdfMemberInfo mExternalBlobDef;
              Blaze::TdfMemberInfoInt64 mExternalIdDef;
              Blaze::TdfMemberInfoInt64 mBlazeIdDef;
              Blaze::TdfMemberInfoString mNameDef;

        	TdfInt(__int64) AID = 0
	        TdfInt(unsigned int) ALOC = 0
	        TdfBlob EXBB
	        TdfInt(unsigned __int64) EXID = 0
	        TdfInt(__int64) ID = 0
	        TdfString NAME = (const char*)37007354

          Blaze::TdfString mName;
          __int64 mBlazeId;
          unsigned __int64 mExternalId;
          Blaze::TdfBlob mExternalBlob;
          __int64 mAccountId;
          unsigned int mAccountLocale;
         */

        [TdfMember("AID")]
        public long mAccountId;

        [TdfMember("ALOC")]
        public uint mAccountLocale;

        [TdfMember("EXBB")]
        public byte[] mExternalBlob;

        [TdfMember("EXID")]
        public ulong mExternalId;

        [TdfMember("ID")]
        public long mBlazeId;

        [TdfMember("NAME")]
        public string mName;
    }
}
