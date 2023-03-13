using Tdf;

namespace Blaze3SDK.Blaze.Authentication
{
    [TdfStruct]
    public struct PS3LoginRequest
    {
        /*
        
        	TdfString MAIL = (const char*)37007354
	        TdfBlob TCKT
        
            Blaze::TdfMemberInfoString mEmailDef;
            Blaze::TdfMemberInfo mPS3TicketDef;

            Blaze::TdfBlob mPS3Ticket;
            Blaze::TdfString mEmail;
         */

        [TdfMember("MAIL")]
        public string mEmail;

        [TdfMember("TCKT")]
        public byte[] mPS3Ticket;
    }
}
