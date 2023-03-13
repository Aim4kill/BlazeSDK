using Tdf;

namespace Blaze3SDK.Blaze.Redirector
{
    [TdfStruct]
    public struct NameRemapEntry
    {
        /*  
              Blaze::TdfMemberInfoInt mDstPortDef;
              Blaze::TdfMemberInfoInt mServiceIdDef;
              Blaze::TdfMemberInfoString mHostnameDef;
              Blaze::TdfMemberInfoString mSiteNameDef;
              Blaze::TdfMemberInfoInt mSrcPortDef;

            TdfInt(unsigned __int16) DPRT = 0
	        TdfInt(unsigned int) SID = 0
	        TdfString SIP = (const char*)37007354
	        TdfString SITE = (const char*)37007354
	        TdfInt(unsigned __int16) SPRT = 0

          Blaze::TdfString mHostname;
          unsigned int mServiceId;
          Blaze::TdfString mSiteName;
          unsigned __int16 mSrcPort;
          unsigned __int16 mDstPort;
        */

        [TdfMember("DPRT")]
        public ushort mDstPort;

        [TdfMember("SID")]
        public uint mServiceId;

        [TdfMember("SIP")]
        public string mHostname;

        [TdfMember("SITE")]
        public string mSiteName;

        [TdfMember("SPRT")]
        public ushort mSrcPort;

    }
}
