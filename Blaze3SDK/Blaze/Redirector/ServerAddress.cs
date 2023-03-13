using Tdf;

namespace Blaze3SDK.Blaze.Redirector
{
    public class ServerAddress : TdfUnion
    {

        //Blaze::Redirector::IpAddress *mIpAddress;
        //Blaze::Redirector::XboxServerAddress* mXboxServerAddress;

        [TdfUnion(0)]
        private IpAddress? mIpAddress;
        public IpAddress? IpAddress { get { return mIpAddress; } set { SetValue(value); } }

        [TdfUnion(1)]
        private XboxServerAddress? mXboxServerAddress;
        public XboxServerAddress? XboxServerAddress { get { return mXboxServerAddress; } set { SetValue(value); } }


        public static implicit operator ServerAddress(IpAddress ipAddress)
        {
            return new ServerAddress() { IpAddress = ipAddress };
        }

        public static implicit operator ServerAddress(XboxServerAddress xboxServerAddress)
        {
            return new ServerAddress() { XboxServerAddress = xboxServerAddress };
        }


    }
}
