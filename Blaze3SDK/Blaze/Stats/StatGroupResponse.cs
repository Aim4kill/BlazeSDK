using Tdf;

namespace Blaze3SDK.Blaze.Stats
{
    [TdfStruct]
    public struct StatGroupResponse
    {
        /*
        Blaze::Stats::StatGroupResponse {
	        TdfString CNAM = (const char*)37007354
	        TdfString DESC = (const char*)37007354
	        TODO-Blaze::BlazeObjectType ETYP
	        TdfMap KSUM
	        TdfString META = (const char*)37007354
	        TdfString NAME = (const char*)37007354
	        TdfList STAT
        }
        
        struct Blaze::Stats::StatGroupResponse::TdfMemberInfoDefinition
        {
          Blaze::TdfMemberInfoString mCategoryNameDef;
          Blaze::TdfMemberInfoString mDescDef;
          Blaze::TdfMemberInfo mEntityTypeDef;
          Blaze::TdfMemberInfo mKeyScopeNameValueMapDef;
          Blaze::TdfMemberInfoString mMetadataDef;
          Blaze::TdfMemberInfoString mNameDef;
          Blaze::TdfMemberInfo mStatDescsDef;
        };


        struct __cppobj Blaze::Stats::StatGroupResponse : Blaze::Tdf
        {s
          Blaze::TdfString mName;
          Blaze::TdfString mDesc;
          Blaze::TdfString mCategoryName;
          Blaze::BlazeObjectType mEntityType;
          Blaze::TdfString mMetadata;
          Blaze::TdfStructVector<Blaze::Stats::StatDescSummary,Blaze::TdfTdfVectorBase> mStatDescs;
          Blaze::TdfPrimitiveMap<Blaze::TdfString,__int64,1,0,0,0,Blaze::TdfStringCompareIgnoreCase> mKeyScopeNameValueMap;
        };


         */

        [TdfMember("CNAM")]
        public string mCategoryName;

        [TdfMember("DESC")]
        public string mDesc;

        [TdfMember("ETYP")]
        public BlazeObjectType mEntityType;

        [TdfMember("KSUM")]
        public SortedDictionary<string, long> mKeyScopeNameValueMap;

        [TdfMember("META")]
        public string mMetadata;

        [TdfMember("NAME")]
        public string mName;

        [TdfMember("STAT")]
        public List<StatDescSummary> mStatDescs;

    }
}
