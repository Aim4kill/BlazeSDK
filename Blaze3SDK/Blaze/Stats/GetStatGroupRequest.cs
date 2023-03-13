using Tdf;

namespace Blaze3SDK.Blaze.Stats
{
    [TdfStruct]
    public struct GetStatGroupRequest
    {
        /*
        Blaze::Stats::GetStatGroupRequest {
	        TdfString NAME = (const char*)37007354
        }
        
        struct __cppobj Blaze::Stats::GetStatGroupRequest : Blaze::Tdf
        {
          Blaze::TdfString mName;
        };


         */

        [TdfMember("NAME")]
        public string mName;
    }
}
