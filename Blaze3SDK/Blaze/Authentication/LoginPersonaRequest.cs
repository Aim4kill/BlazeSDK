using Tdf;

namespace Blaze3SDK.Blaze.Authentication
{
    [TdfStruct]
    public struct LoginPersonaRequest
    {
        //Blaze::TdfMemberInfoString mPersonaNameDef;
        //TdfString PNAM = (const char*)37007354

        [TdfMember("PNAM")]
        public string mPersonaName;

    }
}
