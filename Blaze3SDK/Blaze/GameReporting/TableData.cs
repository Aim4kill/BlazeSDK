using Tdf;

namespace Blaze3SDK.Blaze.GameReporting
{
    [TdfStruct]
    public struct TableData
    {
        /*
        Blaze::GameReporting::TableData {
	        TdfList COLS
	        TdfList PKEY
	        TdfString TABN = (const char*)37007354
        }

        struct Blaze::GameReporting::TableData::TdfMemberInfoDefinition
        {
          Blaze::TdfMemberInfo mColumnsDef;
          Blaze::TdfMemberInfo mPrimaryKeyDef;
          Blaze::TdfMemberInfoString mTableDef;
        };

        struct __cppobj Blaze::GameReporting::TableData : Blaze::Tdf
        {
          Blaze::TdfString mTable;
          Blaze::TdfPrimitiveVector<Blaze::TdfString,1,0> mPrimaryKey;
          Blaze::TdfPrimitiveVector<Blaze::TdfString,1,0> mColumns;
        };


         */

        [TdfMember("COLS")]
        public List<string> mColumns;

        [TdfMember("PKEY")]
        public List<string> mPrimaryKey;

        [TdfMember("TABN")]
        public string mTable;

    }
}