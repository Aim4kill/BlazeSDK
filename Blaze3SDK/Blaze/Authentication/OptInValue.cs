using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Authentication;

public class OptInValue : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("OptInValue", "mOptInValue", 0xDA1B3500, TdfType.Bool, 0, true), // VALU
    ];
    private ITdfMember[] __members;

    private TdfBool _optInValue = new(__typeInfos[0]);

    public OptInValue()
    {
        __members = [
            _optInValue,
        ];
    }

    public override Tdf CreateNew() => new OptInValue();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "OptInValue";
    public override string GetFullClassName() => "Blaze::Authentication::OptInValue";

    public bool mOptInValue
    {
        get => _optInValue.Value;
        set => _optInValue.Value = value;
    }

}

