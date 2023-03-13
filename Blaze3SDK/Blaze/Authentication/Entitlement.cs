using Tdf;

namespace Blaze3SDK.Blaze.Authentication
{
    [TdfStruct]
    public struct Entitlement
    {
        /*
        Blaze::Authentication::Entitlement {
			TdfString DEVI = (const char*)37007354
			TdfString GDAY = (const char*)37007354
			TdfString GNAM = (const char*)37007354
			TdfInt(unsigned __int64) ID = 0
			TdfBool ISCO = 0
			TdfInt(__int64) PID = 0
			TdfString PJID = (const char*)37007354
			TdfEnum PRCA = 0 from (Blaze::TdfEnumMap*)44653552
			TdfString PRID = (const char*)37007354
			TdfEnum STAT = 0 from (Blaze::TdfEnumMap*)44653528
			TdfEnum STRC = 0 from (Blaze::TdfEnumMap*)44653544
			TdfString TAG = (const char*)37007354
			TdfString TDAY = (const char*)37007354
			TdfEnum TYPE = 0 from (Blaze::TdfEnumMap*)44653512
			TdfInt(unsigned int) UCNT = 0
			TdfInt(unsigned int) VER = 0
		}

		struct Blaze::Authentication::Entitlement::TdfMemberInfoDefinition
		{
		  Blaze::TdfMemberInfoString mDeviceUriDef;
		  Blaze::TdfMemberInfoString mGrantDateDef;
		  Blaze::TdfMemberInfoString mGroupNameDef;
		  Blaze::TdfMemberInfoInt64 mIdDef;
		  Blaze::TdfMemberInfoInt mIsConsumableDef;
		  Blaze::TdfMemberInfoInt64 mPersonaIdDef;
		  Blaze::TdfMemberInfoString mProjectIdDef;
		  Blaze::TdfMemberInfoEnum mProductCatalogDef;
		  Blaze::TdfMemberInfoString mProductIdDef;
		  Blaze::TdfMemberInfoEnum mStatusDef;
		  Blaze::TdfMemberInfoEnum mStatusReasonCodeDef;
		  Blaze::TdfMemberInfoString mEntitlementTagDef;
		  Blaze::TdfMemberInfoString mTerminationDateDef;
		  Blaze::TdfMemberInfoEnum mEntitlementTypeDef;
		  Blaze::TdfMemberInfoInt mUseCountDef;
		  Blaze::TdfMemberInfoInt mVersionDef;
		};

		struct __cppobj Blaze::Authentication::Entitlement : Blaze::Tdf
		{
		  unsigned __int64 mId;
		  Blaze::TdfString mEntitlementTag;
		  Blaze::TdfString mGroupName;
		  Blaze::TdfString mProjectId;
		  unsigned int mVersion;
		  unsigned int mUseCount;
		  Blaze::TdfString mProductId;
		  Blaze::TdfString mGrantDate;
		  Blaze::TdfString mTerminationDate;
		  Blaze::Authentication::EntitlementStatus::Code mStatus;
		  Blaze::Authentication::EntitlementType::Code mEntitlementType;
		  __int64 mPersonaId;
		  bool mIsConsumable;
		  Blaze::Authentication::StatusReason::Code mStatusReasonCode;
		  Blaze::Authentication::ProductCatalog::Code mProductCatalog;
		  Blaze::TdfString mDeviceUri;
		};

         */

        [TdfMember("DEVI")]
        public string mDeviceUri;

        [TdfMember("GDAY")]
        public string mGrantDate;

        [TdfMember("GNAM")]
        public string mGroupName;

        [TdfMember("ID")]
        public ulong mId;

        [TdfMember("ISCO")]
        public bool mIsConsumable;

        [TdfMember("PID")]
        public long mPersonaId;

        [TdfMember("PJID")]
        public string mProjectId;

        [TdfMember("PRCA")]
        public ProductCatalog mProductCatalog;

        [TdfMember("PRID")]
        public string mProductId;

        [TdfMember("STAT")]
        public EntitlementStatus mStatus;

        [TdfMember("STRC")]
        public StatusReason mStatusReasonCode;

        [TdfMember("TAG")]
        public string mEntitlementTag;

        [TdfMember("TDAY")]
        public string mTerminationDate;

        [TdfMember("TYPE")]
        public EntitlementType mEntitlementType;

        [TdfMember("UCNT")]
        public uint mUseCount;

        [TdfMember("VER")]
        public uint mVersion;
    }
}