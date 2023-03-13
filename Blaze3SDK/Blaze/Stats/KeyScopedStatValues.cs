using Tdf;

namespace Blaze3SDK.Blaze.Stats
{
    [TdfStruct]
    public struct KeyScopedStatValues
    {
        /*
        Blaze::Stats::KeyScopedStatValues {
	        TdfString GRNM = (const char*)37007354
	        TdfString KEY = (const char*)37007354
	        TdfBool LAST = 0
	        TdfClass STS
	        TdfInt(unsigned int) VID = 0
        }

        struct Blaze::Stats::KeyScopedStatValues::TdfMemberInfoDefinition
        {
          Blaze::TdfMemberInfoString mGroupNameDef;
          Blaze::TdfMemberInfoString mKeyStringDef;
          Blaze::TdfMemberInfoInt mLastDef;
          Blaze::TdfMemberInfoClass mStatValuesDef;
          Blaze::TdfMemberInfoInt mViewIdDef;
        };

        struct __cppobj Blaze::Stats::KeyScopedStatValues : Blaze::Tdf
        {
          unsigned int mViewId;
          Blaze::TdfString mGroupName;
          Blaze::TdfString mKeyString;
          bool mLast;
          Blaze::Stats::StatValues mStatValues;
        };

         */

        [TdfMember("GRNM")]
        public string mGroupName;

        [TdfMember("KEY")]
        public string mKeyString;

        [TdfMember("LAST")]
        public bool mLast;

        [TdfMember("STS")]
        public StatValues mStatValues;

        [TdfMember("VID")]
        public uint mViewId;
    }
}
