using Tdf;

namespace Blaze3SDK.Blaze
{
    public class NetworkAddress : TdfUnion
    {
        /*
        enum Blaze::NetworkAddress::Member : __int32
        {
            MEMBER_XBOXCLIENTADDRESS = 0x0,
            MEMBER_XBOXSERVERADDRESS = 0x1,
            MEMBER_IPPAIRADDRESS = 0x2,
            MEMBER_IPADDRESS = 0x3,
            MEMBER_HOSTNAMEADDRESS = 0x4,
            MEMBER_UNSET = 0x7F,
        };

          Blaze::XboxClientAddress *mXboxClientAddress;
          Blaze::XboxServerAddress *mXboxServerAddress;
          Blaze::IpPairAddress *mIpPairAddress;
          Blaze::IpAddress *mIpAddress;
          Blaze::HostNameAddress *mHostNameAddress;

        union Blaze::NetworkAddress::<unnamed_type_u>
        {
          Blaze::XboxClientAddress *mXboxClientAddress;
          Blaze::XboxServerAddress *mXboxServerAddress;
          Blaze::IpPairAddress *mIpPairAddress;
          Blaze::IpAddress *mIpAddress;
          Blaze::HostNameAddress *mHostNameAddress;
        };


         */

        [TdfUnion(0)]
        private XboxClientAddress? mXboxClientAddress;
        public XboxClientAddress? XboxClientAddress { get { return mXboxClientAddress; } set { SetValue(value); } }

        [TdfUnion(1)]
        private XboxServerAddress? mXboxServerAddress;
        public XboxServerAddress? XboxServerAddress { get { return mXboxServerAddress; } set { SetValue(value); } }

        [TdfUnion(2)]
        private IpPairAddress? mIpPairAddress;
        public IpPairAddress? IpPairAddress { get { return mIpPairAddress; } set { SetValue(value); } }

        [TdfUnion(3)]
        private IpAddress? mIpAddress;
        public IpAddress? IpAddress { get { return mIpAddress; } set { SetValue(value); } }

        [TdfUnion(4)]
        private HostNameAddress? mHostNameAddress;
        public HostNameAddress? HostNameAddress { get { return mHostNameAddress; } set { SetValue(value); } }

    }
}
