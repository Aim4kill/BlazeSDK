using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Util;

public class GetTelemetryServerRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("MacAddress", "mMacAddress", 0x8ED86300, TdfType.String, 0, true), // CMAC
    ];
    private ITdfMember[] __members;

    private TdfString _macAddress = new(__typeInfos[0]);

    public GetTelemetryServerRequest()
    {
        __members = [
            _macAddress,
        ];
    }

    public override Tdf CreateNew() => new GetTelemetryServerRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetTelemetryServerRequest";
    public override string GetFullClassName() => "Blaze::Util::GetTelemetryServerRequest";

    public string MacAddress
    {
        get => _macAddress.Value;
        set => _macAddress.Value = value;
    }

}

