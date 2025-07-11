using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.CommerceInfo;

public class GetProductAssociation : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Code", "mCode", 0x8F3D3200, TdfType.String, 0, true), // CSTR
    ];
    private ITdfMember[] __members;

    private TdfString _code = new(__typeInfos[0]);

    public GetProductAssociation()
    {
        __members = [
            _code,
        ];
    }

    public override Tdf CreateNew() => new GetProductAssociation();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetProductAssociation";
    public override string GetFullClassName() => "Blaze::CommerceInfo::GetProductAssociation";

    public string Code
    {
        get => _code.Value;
        set => _code.Value = value;
    }

}

