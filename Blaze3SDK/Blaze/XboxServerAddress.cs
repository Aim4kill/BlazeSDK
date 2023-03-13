using Tdf;

namespace Blaze3SDK.Blaze
{
    [TdfStruct]
    public struct XboxServerAddress
    {
        /*
                  TdfInt(unsigned __int16) PORT = 0
                  TdfString SITE = (const char*)37007354
                  TdfInt(unsigned int) SVID = 0

                  unsigned int mSid;
                  Blaze::TdfString mSiteName;
                  unsigned __int16 mPort;

                  Blaze::TdfMemberInfoInt mPortDef;
                  Blaze::TdfMemberInfoString mSiteNameDef;
                  Blaze::TdfMemberInfoInt mSidDef;
         */

        [TdfMember("PORT")]
        public ushort mPort;

        [TdfMember("SITE")]
        public string mSiteName;

        [TdfMember("SVID")]
        public uint mSid;
    }
}
