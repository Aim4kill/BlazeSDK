using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Stats;

public class GetStatGroupRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Name", "mName", 0xBA1B6500, TdfType.String, 0, true), // NAME
    ];
    private ITdfMember[] __members;

    private TdfString _name = new(__typeInfos[0]);

    public GetStatGroupRequest()
    {
        __members = [
            _name,
        ];
    }

    public override Tdf CreateNew() => new GetStatGroupRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetStatGroupRequest";
    public override string GetFullClassName() => "Blaze::Stats::GetStatGroupRequest";

    public string Name
    {
        get => _name.Value;
        set => _name.Value = value;
    }

}

