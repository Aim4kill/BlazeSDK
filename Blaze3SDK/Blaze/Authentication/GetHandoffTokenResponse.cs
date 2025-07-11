using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Authentication;

public class GetHandoffTokenResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("HandoffToken", "mHandoffToken", 0xA2F9A600, TdfType.String, 0, true), // HOFF
    ];
    private ITdfMember[] __members;

    private TdfString _handoffToken = new(__typeInfos[0]);

    public GetHandoffTokenResponse()
    {
        __members = [
            _handoffToken,
        ];
    }

    public override Tdf CreateNew() => new GetHandoffTokenResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetHandoffTokenResponse";
    public override string GetFullClassName() => "Blaze::Authentication::GetHandoffTokenResponse";

    public string HandoffToken
    {
        get => _handoffToken.Value;
        set => _handoffToken.Value = value;
    }

}

