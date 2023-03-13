using Tdf;

namespace Blaze3SDK.Blaze
{
    [TdfStruct]
    public struct NotifyUserAdded
    {
        /*
         * 	TdfClass DATA
	        TdfClass USER

            Blaze::TdfMemberInfoClass mExtendedDataDef;
            Blaze::TdfMemberInfoClass mUserInfoDef;

            Blaze::UserIdentification mUserInfo;
            Blaze::UserSessionExtendedData mExtendedData;
         */

        [TdfMember("DATA")]
        public UserSessionExtendedData mExtendedData;

        [TdfMember("USER")]
        public UserIdentification mUserInfo;
    }
}
