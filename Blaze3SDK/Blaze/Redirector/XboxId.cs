using Tdf;

namespace Blaze3SDK.Blaze.Redirector
{
    [TdfStruct]
    public struct XboxId
    {
        /*
         
        struct Blaze::Redirector::XboxId::TdfMemberInfoDefinition
        {
          Blaze::TdfMemberInfoString mGamertagDef;
          Blaze::TdfMemberInfoInt64 mXuidDef;
        };

        Blaze::Redirector::XboxId {
	        TdfString GTAG = (const char*)37007354
	        TdfInt(unsigned __int64) XUID = 0
        }

        struct __cppobj __declspec(align(8)) Blaze::Redirector::XboxId : Blaze::Tdf
        {
          unsigned __int64 mXuid;
          Blaze::TdfString mGamertag;
        };

        */


        [TdfMember("GTAG")]
        public string mGamertag;

        [TdfMember("XUID")]
        public ulong mXuid;
    }
}
