using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze;

public class ClientMetrics : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("BlazeFlags", "mBlazeFlags", 0xD629AC00, TdfType.Enum, 0, true), // UBFL
        new TdfMemberInfo("DeviceInfo", "mDeviceInfo", 0xD6497600, TdfType.String, 1, true), // UDEV
        new TdfMemberInfo("Flags", "mFlags", 0xD66B2700, TdfType.UInt16, 2, true), // UFLG
        new TdfMemberInfo("LastRsltCode", "mLastRsltCode", 0xD6CCA300, TdfType.Int32, 3, true), // ULRC
        new TdfMemberInfo("NatType", "mNatType", 0xD6E87400, TdfType.UInt16, 4, true), // UNAT
        new TdfMemberInfo("Status", "mStatus", 0xD73D2100, TdfType.Enum, 5, true), // USTA
        new TdfMemberInfo("WanIpAddr", "mWanIpAddr", 0xD7786E00, TdfType.UInt32, 6, true), // UWAN
    ];
    private ITdfMember[] __members;

    private TdfEnum<Blaze3SDK.Blaze.BlazeUpnpFlags> _blazeFlags = new(__typeInfos[0]);
    private TdfString _deviceInfo = new(__typeInfos[1]);
    private TdfUInt16 _flags = new(__typeInfos[2]);
    private TdfInt32 _lastRsltCode = new(__typeInfos[3]);
    private TdfUInt16 _natType = new(__typeInfos[4]);
    private TdfEnum<Blaze3SDK.Blaze.UpnpStatus> _status = new(__typeInfos[5]);
    private TdfUInt32 _wanIpAddr = new(__typeInfos[6]);

    public ClientMetrics()
    {
        __members = [
            _blazeFlags,
            _deviceInfo,
            _flags,
            _lastRsltCode,
            _natType,
            _status,
            _wanIpAddr,
        ];
    }

    public override Tdf CreateNew() => new ClientMetrics();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ClientMetrics";
    public override string GetFullClassName() => "Blaze::ClientMetrics";

    public Blaze3SDK.Blaze.BlazeUpnpFlags BlazeFlags
    {
        get => _blazeFlags.Value;
        set => _blazeFlags.Value = value;
    }

    public string DeviceInfo
    {
        get => _deviceInfo.Value;
        set => _deviceInfo.Value = value;
    }

    public ushort Flags
    {
        get => _flags.Value;
        set => _flags.Value = value;
    }

    public int LastRsltCode
    {
        get => _lastRsltCode.Value;
        set => _lastRsltCode.Value = value;
    }

    public ushort NatType
    {
        get => _natType.Value;
        set => _natType.Value = value;
    }

    public Blaze3SDK.Blaze.UpnpStatus Status
    {
        get => _status.Value;
        set => _status.Value = value;
    }

    public uint WanIpAddr
    {
        get => _wanIpAddr.Value;
        set => _wanIpAddr.Value = value;
    }

}

