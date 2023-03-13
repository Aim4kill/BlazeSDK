using Tdf;

namespace Blaze3SDK.Blaze.Authentication
{
    [TdfStruct]
    public struct Entitlements
    {
        /*
        Blaze::Authentication::Entitlements {
	        TdfList NLST
        }
        struct __cppobj Blaze::Authentication::Entitlements : Blaze::Tdf
        {
          Blaze::TdfStructVector<Blaze::Authentication::Entitlement,Blaze::TdfTdfVectorBase> mEntitlements;
        };


         */

        [TdfMember("NLST")]
        public List<Entitlement> mEntitlements;
    }
}
