using Tdf;

namespace Blaze3SDK.Blaze
{
    [TdfStruct]
    public struct HostNameAddress
    {
        /*
            Blaze::TdfMemberInfoString mHostNameDef;
            Blaze::TdfMemberInfoInt mPortDef;

            Blaze::TdfString mHostName;
            unsigned __int16 mPort;

            TdfString NAME = (const char*)37007354
	        TdfInt(unsigned __int16) PORT = 0
         */

        [TdfMember("NAME")]
        public string mHostName;

        [TdfMember("PORT")]
        public ushort mPort;
    }
}
