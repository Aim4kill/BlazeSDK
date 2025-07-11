using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Locker;

public class Attribute : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Name", "mName", 0xBA1B6500, TdfType.String, 0, true), // NAME
        new TdfMemberInfo("Value", "mValue", 0xDA1B3500, TdfType.String, 1, true), // VALU
    ];
    private ITdfMember[] __members;

    private TdfString _name = new(__typeInfos[0]);
    private TdfString _value = new(__typeInfos[1]);

    public Attribute()
    {
        __members = [
            _name,
            _value,
        ];
    }

    public override Tdf CreateNew() => new Attribute();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "Attribute";
    public override string GetFullClassName() => "Blaze::Locker::Attribute";

    public string Name
    {
        get => _name.Value;
        set => _name.Value = value;
    }

    public string Value
    {
        get => _value.Value;
        set => _value.Value = value;
    }

}

