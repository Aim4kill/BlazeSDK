using Tdf;

namespace Blaze3SDK.Blaze.Clubs
{
    [TdfStruct]
    public struct ClubMemberships
    {
        /*
        Blaze::Clubs::ClubMemberships {
	        TdfList CMSL
        }

        struct __cppobj Blaze::Clubs::ClubMemberships : Blaze::Tdf
        {
          Blaze::TdfStructVector<Blaze::Clubs::ClubMembership,Blaze::TdfTdfVectorBase> mClubMembershipList;
        };

         */

        [TdfMember("CMSL")]
        public List<ClubMembership> mClubMembershipList;
    }
}