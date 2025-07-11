using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Authentication;

public class DeviceLoginGuestRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("DeviceId", "mDeviceId", 0x936A6400, TdfType.UInt64, 0, true), // DVID
    ];
    private ITdfMember[] __members;

    private TdfUInt64 _deviceId = new(__typeInfos[0]);

    public DeviceLoginGuestRequest()
    {
        __members = [
            _deviceId,
        ];
    }

    public override Tdf CreateNew() => new DeviceLoginGuestRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "DeviceLoginGuestRequest";
    public override string GetFullClassName() => "Blaze::Authentication::DeviceLoginGuestRequest";

    public ulong DeviceId
    {
        get => _deviceId.Value;
        set => _deviceId.Value = value;
    }

}

