using Tdf;

namespace Blaze3SDK.Blaze.Clubs
{
    [TdfStruct]
    public struct GetClubMembershipForUsersRequest
    {
        /*
        struct __cppobj Blaze::Clubs::GetClubMembershipForUsersRequest : Blaze::Tdf
        {
          Blaze::TdfPrimitiveVector<__int64,0,0> mBlazeIdList;
        };

        Blaze::Clubs::GetClubMembershipForUsersRequest {
	        TdfList IDLT
        }

         */

        [TdfMember("IDLT")]
        public List<long> mBlazeIdList;
    }
}
