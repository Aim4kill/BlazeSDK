using Tdf;

namespace Blaze3SDK.Blaze
{
    [TdfStruct]
    public struct UserSessionExtendedDataUpdate
    {

        //TdfClass DATA
        //TdfInt(__int64) USID = 0

        //Blaze::UserSessionExtendedData mExtendedData;
        //Blaze::UserSessionExtendedData* mExtendedDataPtr;
        //__int64 mUserId;

        [TdfMember("DATA")]
        public UserSessionExtendedData mExtendedData;

        [TdfMember("USID")]
        public long mUserId;

    }
}
