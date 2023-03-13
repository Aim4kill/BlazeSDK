using Tdf;

namespace Blaze3SDK.Blaze
{
    [TdfStruct]
    public struct IpPairAddress
    {
        [TdfMember("EXIP")]
        public IpAddress mExternalAddress;

        [TdfMember("INIP")]
        public IpAddress mInternalAddress;


        public IpPairAddress(IpAddress internalAddress, IpAddress externalAddress)
        {
            this.mInternalAddress = internalAddress;
            this.mExternalAddress = externalAddress;
        }


        public static implicit operator NetworkAddress(IpPairAddress ipPairAddress)
        {
            var ret = new NetworkAddress();
            ret.SetValue(ipPairAddress);
            return ret;
        }
    }
}
