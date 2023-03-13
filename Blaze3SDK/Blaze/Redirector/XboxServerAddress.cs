using Tdf;

namespace Blaze3SDK.Blaze.Redirector
{
    [TdfStruct]
    public struct XboxServerAddress
    {
        /*
            Blaze::Redirector::XboxServerAddress {
	            TdfInt(unsigned __int16) PORT = 0
	            TdfInt(unsigned int) SID = 0
	            TdfString SITE = (const char*)37007354
            }

            unsigned int mServiceId;
            Blaze::TdfString mSiteName;
            unsigned __int16 mPort;

            Blaze::TdfMemberInfoInt mPortDef;
            Blaze::TdfMemberInfoString mSiteNameDef;
            Blaze::TdfMemberInfoInt mSidDef;
        
        */

        [TdfMember("PORT")]
        public ushort mPort;

        [TdfMember("SID")]
        public uint mServiceId;

        [TdfMember("SITE")]
        public string mSiteName;


        public static implicit operator XboxServerAddress?(ServerAddress serverAddress)
        {
            return serverAddress.XboxServerAddress;
        }
    }
}
