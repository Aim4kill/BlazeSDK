using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze;

public class CensusValue : Union
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("NumValue", "mNumValue", 0xDA1B3500, TdfType.UInt32, 0, false), // VALU
        new TdfMemberInfo("StringValue", "mStringValue", 0xDA1B3500, TdfType.String, 1, false), // VALU
    ];

    private TdfUInt32 _numValue = new(__typeInfos[0]);
    private TdfString _stringValue = new(__typeInfos[1]);

    public override ITdfMember? GetActiveMember()
    {
        return ActiveIndex switch
        {
            0 => _numValue,
            1 => _stringValue,
            _ => null
        };
    }
    public override Tdf CreateNew() => new CensusValue();
    public override string GetClassName() => "CensusValue";
    public override string GetFullClassName() => "Blaze::CensusValue";

    public uint NumValue
    {
        get => _numValue.Value;
        set
        {
            SwitchActiveIndex(0);
            _numValue.Value = value;
        }
    }

    public string StringValue
    {
        get => _stringValue.Value;
        set
        {
            SwitchActiveIndex(1);
            _stringValue.Value = value;
        }
    }

}