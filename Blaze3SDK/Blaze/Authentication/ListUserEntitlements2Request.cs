using Tdf;

namespace Blaze3SDK.Blaze.Authentication
{
    [TdfStruct]
    public struct ListUserEntitlements2Request
    {
        /*
        Blaze::Authentication::ListUserEntitlements2Request {
	        TdfInt(__int64) BUID = 0
	        TdfInt(unsigned __int16) EPSN = 16777216
	        TdfInt(unsigned __int16) EPSZ = 838860800
	        TdfString ETAG = (const char*)37007354
	        TdfString GDAY = (const char*)37007354
	        TdfList GNLS
	        TdfBool HAUP = 0
	        TdfString PJID = (const char*)37007354
	        TdfString PRID = (const char*)37007354
	        TdfBool RECU = 0
	        TdfEnum STAT = 0 from (Blaze::TdfEnumMap*)44653528
	        TdfString TERD = (const char*)37007354
	        TdfEnum TYPE = 0 from (Blaze::TdfEnumMap*)44653512
        }

        struct Blaze::Authentication::ListUserEntitlements2Request::TdfMemberInfoDefinition
        {
          Blaze::TdfMemberInfoInt64 mUserIdDef;
          Blaze::TdfMemberInfoInt mPageNoDef;
          Blaze::TdfMemberInfoInt mPageSizeDef;
          Blaze::TdfMemberInfoString mEntitlementTagDef;
          Blaze::TdfMemberInfoString mGrantDateDef;
          Blaze::TdfMemberInfo mGroupNameListDef;
          Blaze::TdfMemberInfoInt mHasAuthorizedPersonaDef;
          Blaze::TdfMemberInfoString mProjectIdDef;
          Blaze::TdfMemberInfoString mProductIdDef;
          Blaze::TdfMemberInfoInt mRecursiveSearchDef;
          Blaze::TdfMemberInfoEnum mStatusDef;
          Blaze::TdfMemberInfoString mTerminationDateDef;
          Blaze::TdfMemberInfoEnum mEntitlementTypeDef;
        };

        struct __cppobj __declspec(align(8)) Blaze::Authentication::ListUserEntitlements2Request : Blaze::Tdf
        {
          __int64 mUserId;
          Blaze::TdfPrimitiveVector<Blaze::TdfString,1,0> mGroupNameList;
          unsigned __int16 mPageSize;
          unsigned __int16 mPageNo;
          Blaze::Authentication::EntitlementStatus::Code mStatus;
          Blaze::Authentication::EntitlementType::Code mEntitlementType;
          Blaze::TdfString mEntitlementTag;
          Blaze::TdfString mProductId;
          Blaze::TdfString mProjectId;
          Blaze::TdfString mTerminationDate;
          bool mRecursiveSearch;
          Blaze::TdfString mGrantDate;
          bool mHasAuthorizedPersona;
        };

         */

        [TdfMember("BUID")]
        public long mUserId;

        [TdfMember("EPSN")]
        public ushort mPageNo;

        [TdfMember("EPSZ")]
        public ushort mPageSize;

        [TdfMember("ETAG")]
        public string mEntitlementTag;

        [TdfMember("GDAY")]
        public string mGrantDate;

        [TdfMember("GNLS")]
        public List<string> mGroupNameList;

        [TdfMember("HAUP")]
        public bool mHasAuthorizedPersona;

        [TdfMember("PJID")]
        public string mProjectId;

        [TdfMember("PRID")]
        public string mProductId;

        [TdfMember("RECU")]
        public bool mRecursiveSearch;

        [TdfMember("STAT")]
        public EntitlementStatus mStatus;

        [TdfMember("TERD")]
        public string mTerminationDate;

        [TdfMember("TYPE")]
        public EntitlementType mEntitlementType;

    }
}
