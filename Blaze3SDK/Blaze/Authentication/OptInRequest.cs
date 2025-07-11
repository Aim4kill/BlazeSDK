using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Authentication;

public class OptInRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("OptInName", "mOptInName", 0xBA1B6500, TdfType.String, 0, true), // NAME
    ];
    private ITdfMember[] __members;

    private TdfString _optInName = new(__typeInfos[0]);

    public OptInRequest()
    {
        __members = [
            _optInName,
        ];
    }

    public override Tdf CreateNew() => new OptInRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "OptInRequest";
    public override string GetFullClassName() => "Blaze::Authentication::OptInRequest";

    public string OptInName
    {
        get => _optInName.Value;
        set => _optInName.Value = value;
    }

}

