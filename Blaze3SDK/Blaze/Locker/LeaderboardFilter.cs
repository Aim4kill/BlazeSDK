using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Locker;

public class LeaderboardFilter : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Name", "mName", 0xBA1B6500, TdfType.String, 0, true), // NAME
        new TdfMemberInfo("Operator", "mOperator", 0xBF000000, TdfType.String, 1, true), // OP
        new TdfMemberInfo("Value", "mValue", 0xDA1B3500, TdfType.String, 2, true), // VALU
    ];
    private ITdfMember[] __members;

    private TdfString _name = new(__typeInfos[0]);
    private TdfString _operator = new(__typeInfos[1]);
    private TdfString _value = new(__typeInfos[2]);

    public LeaderboardFilter()
    {
        __members = [
            _name,
            _operator,
            _value,
        ];
    }

    public override Tdf CreateNew() => new LeaderboardFilter();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "LeaderboardFilter";
    public override string GetFullClassName() => "Blaze::Locker::LeaderboardFilter";

    public string Name
    {
        get => _name.Value;
        set => _name.Value = value;
    }

    public string Operator
    {
        get => _operator.Value;
        set => _operator.Value = value;
    }

    public string Value
    {
        get => _value.Value;
        set => _value.Value = value;
    }

}

