using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.GameManager;

public class GenericRuleConfig : Tdf
{
    public enum GenericRuleAttributeType : int
    {
        PLAYER_ATTRIBUTE = 0,
        GAME_ATTRIBUTE = 1,
    }
    
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("AttributeName", "mAttributeName", 0x86EB6500, TdfType.String, 0, true), // ANME
        new TdfMemberInfo("AttributeType", "mAttributeType", 0x874E7000, TdfType.Enum, 1, true), // ATYP
        new TdfMemberInfo("PossibleValues", "mPossibleValues", 0xC2FCF600, TdfType.List, 2, true), // POSV
        new TdfMemberInfo("RuleName", "mRuleName", 0xCAEB6500, TdfType.String, 3, true), // RNME
        new TdfMemberInfo("ThresholdNames", "mThresholdNames", 0xD28B3300, TdfType.List, 4, true), // THLS
        new TdfMemberInfo("Weight", "mWeight", 0xDE7A3400, TdfType.UInt32, 5, true), // WGHT
    ];
    private ITdfMember[] __members;

    private TdfString _attributeName = new(__typeInfos[0]);
    private TdfEnum<Blaze2SDK.Blaze.GameManager.GenericRuleConfig.GenericRuleAttributeType> _attributeType = new(__typeInfos[1]);
    private TdfList<string> _possibleValues = new(__typeInfos[2]);
    private TdfString _ruleName = new(__typeInfos[3]);
    private TdfList<string> _thresholdNames = new(__typeInfos[4]);
    private TdfUInt32 _weight = new(__typeInfos[5]);

    public GenericRuleConfig()
    {
        __members = [
            _attributeName,
            _attributeType,
            _possibleValues,
            _ruleName,
            _thresholdNames,
            _weight,
        ];
    }

    public override Tdf CreateNew() => new GenericRuleConfig();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GenericRuleConfig";
    public override string GetFullClassName() => "Blaze::GameManager::GenericRuleConfig";

    public string AttributeName
    {
        get => _attributeName.Value;
        set => _attributeName.Value = value;
    }

    public Blaze2SDK.Blaze.GameManager.GenericRuleConfig.GenericRuleAttributeType AttributeType
    {
        get => _attributeType.Value;
        set => _attributeType.Value = value;
    }

    public IList<string> PossibleValues
    {
        get => _possibleValues.Value;
        set => _possibleValues.Value = value;
    }

    public string RuleName
    {
        get => _ruleName.Value;
        set => _ruleName.Value = value;
    }

    public IList<string> ThresholdNames
    {
        get => _thresholdNames.Value;
        set => _thresholdNames.Value = value;
    }

    public uint Weight
    {
        get => _weight.Value;
        set => _weight.Value = value;
    }

}

