using Tdf;

namespace Blaze3SDK.Blaze.Clubs
{
    [TdfStruct]
    public struct ClubMembership
    {
        /*
        Blaze::Clubs::ClubMembership {
	        TdfInt(unsigned int) CLID = 0
	        TdfInt(unsigned int) DMID = 0
	        TdfClass MBER
	        TdfString NAME = (const char*)37007354
        }
        
        struct Blaze::Clubs::ClubMembership::TdfMemberInfoDefinition
        {
          Blaze::TdfMemberInfoInt mClubIdDef;
          Blaze::TdfMemberInfoInt mClubDomainIdDef;
          Blaze::TdfMemberInfoClass mClubMemberDef;
          Blaze::TdfMemberInfoString mClubNameDef;
        };
        
        struct __cppobj Blaze::Clubs::ClubMembership : Blaze::Tdf
        {
          unsigned int mClubId;
          unsigned int mClubDomainId;
          Blaze::TdfString mClubName;
          Blaze::Clubs::ClubMember mClubMember;
        };        

         */

        [TdfMember("CLID")]
        public uint mClubId;

        [TdfMember("DMID")]
        public uint mClubDomainId;

        [TdfMember("MBER")]
        public ClubMember mClubMember;

        [TdfMember("NAME")]
        public string mClubName;
    }
}