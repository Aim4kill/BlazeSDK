namespace Blaze3SDK.Blaze
{
    [Flags]
    public enum BlazeUpnpFlags
    {
        None = 0x00,
        NatPromoted = 0x01,
        DoubleNat = 0x02,
        PortOverride = 0x04,
    }
}
