using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Stats;

public class StatUpdate : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Name", "mName", 0xBA1B6500, TdfType.String, 0, true), // NAME
        new TdfMemberInfo("UpdateType", "mUpdateType", 0xD39C2500, TdfType.Int32, 1, true), // TYPE
        new TdfMemberInfo("Value", "mValue", 0xDA1B3500, TdfType.String, 2, true), // VALU
    ];
    private ITdfMember[] __members;

    private TdfString _name = new(__typeInfos[0]);
    private TdfInt32 _updateType = new(__typeInfos[1]);
    private TdfString _value = new(__typeInfos[2]);

    public StatUpdate()
    {
        __members = [
            _name,
            _updateType,
            _value,
        ];
    }

    public override Tdf CreateNew() => new StatUpdate();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "StatUpdate";
    public override string GetFullClassName() => "Blaze::Stats::StatUpdate";

    public string Name
    {
        get => _name.Value;
        set => _name.Value = value;
    }

    public int UpdateType
    {
        get => _updateType.Value;
        set => _updateType.Value = value;
    }

    public string Value
    {
        get => _value.Value;
        set => _value.Value = value;
    }

}

