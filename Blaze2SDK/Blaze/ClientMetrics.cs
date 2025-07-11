using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze;

public class ClientMetrics : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("DeviceInfo", "mDeviceInfo", 0xD6497600, TdfType.String, 0, true), // UDEV
        new TdfMemberInfo("Status", "mStatus", 0xD73D2100, TdfType.Enum, 1, true), // USTA
    ];
    private ITdfMember[] __members;

    private TdfString _deviceInfo = new(__typeInfos[0]);
    private TdfEnum<Blaze2SDK.Blaze.UpnpStatus> _status = new(__typeInfos[1]);

    public ClientMetrics()
    {
        __members = [
            _deviceInfo,
            _status,
        ];
    }

    public override Tdf CreateNew() => new ClientMetrics();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ClientMetrics";
    public override string GetFullClassName() => "Blaze::ClientMetrics";

    public string DeviceInfo
    {
        get => _deviceInfo.Value;
        set => _deviceInfo.Value = value;
    }

    public Blaze2SDK.Blaze.UpnpStatus Status
    {
        get => _status.Value;
        set => _status.Value = value;
    }

}

