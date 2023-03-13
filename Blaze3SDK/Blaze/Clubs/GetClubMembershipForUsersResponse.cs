using Tdf;

namespace Blaze3SDK.Blaze.Clubs
{
    [TdfStruct]
    public struct GetClubMembershipForUsersResponse
    {
        /*
        Blaze::Clubs::GetClubMembershipForUsersResponse {
	        TdfMap MMAP
        }

        struct __cppobj Blaze::Clubs::GetClubMembershipForUsersResponse : Blaze::Tdf
        {
          Blaze::TdfStructMap<__int64,Blaze::Clubs::ClubMemberships,0,3,Blaze::TdfTdfMapBase,0,eastl::less<__int64> > mMembershipMap;
        };


         */

        [TdfMember("MMAP")]
        public SortedDictionary<long, ClubMemberships> mMembershipMap;
    }
}
