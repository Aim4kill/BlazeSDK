using Tdf;

namespace Blaze3SDK.Blaze
{
    [TdfStruct]
    public struct NotifyUserRemoved
    {
        /*
        Blaze::NotifyUserRemoved {
	        TdfInt(__int64) BUID = 0
        }

        struct __cppobj Blaze::NotifyUserRemoved : Blaze::Tdf
        {
          __int64 mUserId;
        };

         */

        [TdfMember("BUID")]
        public long mUserId;
    }
}
