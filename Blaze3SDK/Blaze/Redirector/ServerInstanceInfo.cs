using Tdf;

namespace Blaze3SDK.Blaze.Redirector
{
    [TdfStruct]
    public struct ServerInstanceInfo
    {
        /*
          Blaze::TdfMemberInfo mAddressDef;
          Blaze::TdfMemberInfo mAddressRemapsDef;
          Blaze::TdfMemberInfo mMessagesDef;
          Blaze::TdfMemberInfo mNameRemapsDef;
          Blaze::TdfMemberInfoInt mSecureDef;
          Blaze::TdfMemberInfoInt mDefaultDnsAddressDef;

        	TdfUnion ADDR
	        TdfList AMAP
	        TdfList MSGS
	        TdfList NMAP
	        TdfBool SECU = 0
	        TdfInt(unsigned int) XDNS = 0



          Blaze::Redirector::ServerAddress mAddress;
          bool mSecure;
          __declspec(align(4)) Blaze::TdfStructVector<Blaze::Redirector::AddressRemapEntry,Blaze::TdfTdfVectorBase> mAddressRemaps;
          Blaze::TdfStructVector<Blaze::Redirector::NameRemapEntry,Blaze::TdfTdfVectorBase> mNameRemaps;
          unsigned int mDefaultDnsAddress;
          Blaze::TdfPrimitiveVector<Blaze::TdfString,1,0> mMessages;
         */

        [TdfMember("ADDR")]
        public ServerAddress mAddress;

        [TdfMember("AMAP")]
        public List<AddressRemapEntry> mAddressRemaps;

        [TdfMember("MSGS")]
        public List<string> mMessages;

        [TdfMember("NMAP")]
        public List<NameRemapEntry> mNameRemaps;

        [TdfMember("SECU")]
        public bool mSecure;

        [TdfMember("XDNS")]
        public uint mDefaultDnsAddress;

        [TdfMember("TSVN")]
        public string mTrialServiceName;
    }
}
