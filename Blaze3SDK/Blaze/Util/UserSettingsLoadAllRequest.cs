using Tdf;

namespace Blaze3SDK.Blaze.Util
{
    [TdfStruct]
    public struct UserSettingsLoadAllRequest
    {
        /*
        Blaze::Util::UserSettingsLoadAllRequest {
	        TdfInt(__int64) UID = 0
        }

        struct __cppobj Blaze::Util::UserSettingsLoadAllRequest : Blaze::Tdf
        {
          __int64 mUserId;
        };

         */

        [TdfMember("UID")]
        public long mUserId;
    }
}
