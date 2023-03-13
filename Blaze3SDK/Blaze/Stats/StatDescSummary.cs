using Tdf;

namespace Blaze3SDK.Blaze.Stats
{
    [TdfStruct]
    public struct StatDescSummary
    {
        /*
        
        Blaze::Stats::StatDescSummary {
	        TdfString CATG = (const char*)37007354
	        TdfString DFLT = (const char*)37007354
	        TdfBool DRVD = 0
	        TdfString FRMT = (const char*)37007354
	        TdfString KIND = (const char*)37007354
	        TdfString LDSC = (const char*)37007354
	        TdfString META = (const char*)37007354
	        TdfString NAME = (const char*)37007354
	        TdfString SDSC = (const char*)37007354
	        TdfInt(int) TYPE = 0
        }

        struct Blaze::Stats::StatDescSummary::TdfMemberInfoDefinition
        {
          Blaze::TdfMemberInfoString mCategoryDef;
          Blaze::TdfMemberInfoString mDefaultValueDef;
          Blaze::TdfMemberInfoInt mDerivedDef;
          Blaze::TdfMemberInfoString mFormatDef;
          Blaze::TdfMemberInfoString mKindDef;
          Blaze::TdfMemberInfoString mLongDescDef;
          Blaze::TdfMemberInfoString mMetadataDef;
          Blaze::TdfMemberInfoString mNameDef;
          Blaze::TdfMemberInfoString mShortDescDef;
          Blaze::TdfMemberInfoInt mTypeDef;
        };

        struct __cppobj __declspec(align(4)) Blaze::Stats::StatDescSummary : Blaze::Tdf
        {
          Blaze::TdfString mName;
          Blaze::TdfString mShortDesc;
          Blaze::TdfString mLongDesc;
          int mType;
          Blaze::TdfString mDefaultValue;
          Blaze::TdfString mFormat;
          Blaze::TdfString mKind;
          Blaze::TdfString mMetadata;
          Blaze::TdfString mCategory;
          bool mDerived;
        };

         */

        [TdfMember("CATG")]
        public string mCategory;

        [TdfMember("DFLT")]
        public string mDefaultValue;

        [TdfMember("DRVD")]
        public bool mDerived;

        [TdfMember("FRMT")]
        public string mFormat;

        [TdfMember("KIND")]
        public string mKind;

        [TdfMember("LDSC")]
        public string mLongDesc;

        [TdfMember("META")]
        public string mMetadata;

        [TdfMember("NAME")]
        public string mName;

        [TdfMember("SDSC")]
        public string mShortDesc;

        [TdfMember("TYPE")]
        public int mType;

    }
}