using Tdf;

namespace Blaze3SDK.Blaze.Util
{
    [TdfStruct]
    public struct UserSettingsLoadAllResponse
    {
        /*
        Blaze::Util::UserSettingsLoadAllResponse {
	        TdfMap SMAP
        }

        struct __cppobj Blaze::Util::UserSettingsLoadAllResponse : Blaze::Tdf
        {
          Blaze::TdfPrimitiveMap<Blaze::TdfString,Blaze::TdfString,1,1,0,0,Blaze::TdfStringCompareIgnoreCase> mDataMap;
        };

         */

        [TdfMember("SMAP")]
        public SortedDictionary<string, string> mDataMap;
    }
}
