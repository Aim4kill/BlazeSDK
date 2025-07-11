using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Authentication;

public class ListDeviceAccountsRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("DeviceId", "mDeviceId", 0x936A6400, TdfType.UInt64, 0, true), // DVID
    ];
    private ITdfMember[] __members;

    private TdfUInt64 _deviceId = new(__typeInfos[0]);

    public ListDeviceAccountsRequest()
    {
        __members = [
            _deviceId,
        ];
    }

    public override Tdf CreateNew() => new ListDeviceAccountsRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ListDeviceAccountsRequest";
    public override string GetFullClassName() => "Blaze::Authentication::ListDeviceAccountsRequest";

    public ulong DeviceId
    {
        get => _deviceId.Value;
        set => _deviceId.Value = value;
    }

}

