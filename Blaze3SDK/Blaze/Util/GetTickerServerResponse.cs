using Tdf;

namespace Blaze3SDK.Blaze.Util
{
    [TdfStruct]
    public struct GetTickerServerResponse
    {
        /*
        	TdfString ADRS = (const char*)37007354
	        TdfInt(unsigned int) PORT = 0
	        TdfString SKEY = (const char*)37007354

          Blaze::TdfString mAddress;
          unsigned int mPort;
          Blaze::TdfString mKey;

          Blaze::TdfMemberInfoString mAddressDef;
          Blaze::TdfMemberInfoInt mPortDef;
          Blaze::TdfMemberInfoString mKeyDef;
        
        */

        [TdfMember("ADRS")]
        public string mAddress;

        [TdfMember("PORT")]
        public uint mPort;

        [TdfMember("SKEY")]
        public string mKey;
    }
}
