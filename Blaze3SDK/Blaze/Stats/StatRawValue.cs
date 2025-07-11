using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Stats;

public class StatRawValue : Union
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("FloatValue", "mFloatValue", 0xDA1B3500, TdfType.Float, 0, false), // VALU
        new TdfMemberInfo("IntValue", "mIntValue", 0xDA1B3500, TdfType.Int64, 1, false), // VALU
        new TdfMemberInfo("StringValue", "mStringValue", 0xDA1B3500, TdfType.String, 2, false), // VALU
    ];

    private TdfFloat _floatValue = new(__typeInfos[0]);
    private TdfInt64 _intValue = new(__typeInfos[1]);
    private TdfString _stringValue = new(__typeInfos[2]);

    public override ITdfMember? GetActiveMember()
    {
        return ActiveIndex switch
        {
            0 => _floatValue,
            1 => _intValue,
            2 => _stringValue,
            _ => null
        };
    }
    public override Tdf CreateNew() => new StatRawValue();
    public override string GetClassName() => "StatRawValue";
    public override string GetFullClassName() => "Blaze::Stats::StatRawValue";

    public float FloatValue
    {
        get => _floatValue.Value;
        set
        {
            SwitchActiveIndex(0);
            _floatValue.Value = value;
        }
    }

    public long IntValue
    {
        get => _intValue.Value;
        set
        {
            SwitchActiveIndex(1);
            _intValue.Value = value;
        }
    }

    public string StringValue
    {
        get => _stringValue.Value;
        set
        {
            SwitchActiveIndex(2);
            _stringValue.Value = value;
        }
    }

}

