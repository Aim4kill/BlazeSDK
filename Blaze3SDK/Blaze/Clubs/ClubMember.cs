using Tdf;

namespace Blaze3SDK.Blaze.Clubs
{
    [TdfStruct]
    public struct ClubMember
    {
        /*
        Blaze::Clubs::ClubMember {
	        TdfInt(__int64) BLID = 0
	        TdfEnum CMTP = 0 from (Blaze::TdfEnumMap*)44653648
	        TdfEnum MBOS = 0 from (Blaze::TdfEnumMap*)44653712
	        TdfMap META
	        TdfInt(unsigned int) MSTM = 0
	        TdfString PERS = (const char*)37007354
        }

        struct __declspec(align(8)) Blaze::Clubs::ClubMember::TdfMemberInfoDefinition
        {
          Blaze::TdfMemberInfoInt64 mBlazeIdDef;
          Blaze::TdfMemberInfoEnum mMembershipStatusDef;
          Blaze::TdfMemberInfoEnum mOnlineStatusDef;
          Blaze::TdfMemberInfo mMetaDataDef;
          Blaze::TdfMemberInfoInt mMembershipSinceTimeDef;
          Blaze::TdfMemberInfoString mPersonaDef;
        };


        struct __cppobj __declspec(align(8)) Blaze::Clubs::ClubMember : Blaze::Tdf
        {
          __int64 mBlazeId;
          Blaze::TdfString mPersona;
          Blaze::Clubs::MembershipStatus mMembershipStatus;
          unsigned int mMembershipSinceTime;
          Blaze::Clubs::MemberOnlineStatus mOnlineStatus;
          Blaze::TdfPrimitiveMap<Blaze::TdfString,Blaze::TdfString,1,1,0,0,Blaze::TdfStringCompareIgnoreCase> mMetaData;
        };

         */

        [TdfMember("BLID")]
        public long mBlazeId;
        
        [TdfMember("CMTP")]
        public MembershipStatus mMembershipStatus;

        [TdfMember("MBOS")]
        public MemberOnlineStatus mOnlineStatus;

        [TdfMember("META")]
        public SortedDictionary<string, string> mMetaData;

        [TdfMember("MSTM")]
        public uint mMembershipSinceTime;

        [TdfMember("PERS")]
        public string mPersona;
    }
}