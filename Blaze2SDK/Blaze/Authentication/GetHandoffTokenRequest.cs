using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Authentication;

public class GetHandoffTokenRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ClientString", "mClientString", 0x8F3D3200, TdfType.String, 0, true), // CSTR
    ];
    private ITdfMember[] __members;

    private TdfString _clientString = new(__typeInfos[0]);

    public GetHandoffTokenRequest()
    {
        __members = [
            _clientString,
        ];
    }

    public override Tdf CreateNew() => new GetHandoffTokenRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetHandoffTokenRequest";
    public override string GetFullClassName() => "Blaze::Authentication::GetHandoffTokenRequest";

    public string ClientString
    {
        get => _clientString.Value;
        set => _clientString.Value = value;
    }

}

