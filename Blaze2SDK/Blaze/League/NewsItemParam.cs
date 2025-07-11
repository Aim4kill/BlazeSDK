using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.League;

public class NewsItemParam : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Type", "mType", 0xD39C2500, TdfType.Enum, 0, true), // TYPE
        new TdfMemberInfo("Value", "mValue", 0xDA1B0000, TdfType.String, 1, true), // VAL
    ];
    private ITdfMember[] __members;

    private TdfEnum<Blaze2SDK.Blaze.League.NewsParamType> _type = new(__typeInfos[0]);
    private TdfString _value = new(__typeInfos[1]);

    public NewsItemParam()
    {
        __members = [
            _type,
            _value,
        ];
    }

    public override Tdf CreateNew() => new NewsItemParam();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "NewsItemParam";
    public override string GetFullClassName() => "Blaze::League::NewsItemParam";

    public Blaze2SDK.Blaze.League.NewsParamType Type
    {
        get => _type.Value;
        set => _type.Value = value;
    }

    public string Value
    {
        get => _value.Value;
        set => _value.Value = value;
    }

}

