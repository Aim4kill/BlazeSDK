using Tdf;

namespace Blaze2SDK.Blaze.Util
{
    [TdfStruct]
    public struct PreAuthRequest
    {
        
        [TdfMember("CDAT")]
        public ClientData mClientData;
        
        [TdfMember("CINF")]
        public ClientInfo mClientInfo;
        
        [TdfMember("FCCR")]
        public FetchClientConfigRequest mFetchClientConfig;
        
    }
}
