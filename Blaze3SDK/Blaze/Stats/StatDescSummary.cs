using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Stats;

public class StatDescSummary : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Category", "mCategory", 0x8E1D2700, TdfType.String, 0, true), // CATG
        new TdfMemberInfo("DefaultValue", "mDefaultValue", 0x926B3400, TdfType.String, 1, true), // DFLT
        new TdfMemberInfo("Derived", "mDerived", 0x932DA400, TdfType.Bool, 2, true), // DRVD
        new TdfMemberInfo("Format", "mFormat", 0x9B2B7400, TdfType.String, 3, true), // FRMT
        new TdfMemberInfo("Kind", "mKind", 0xAE9BA400, TdfType.String, 4, true), // KIND
        new TdfMemberInfo("LongDesc", "mLongDesc", 0xB24CE300, TdfType.String, 5, true), // LDSC
        new TdfMemberInfo("Metadata", "mMetadata", 0xB65D2100, TdfType.String, 6, true), // META
        new TdfMemberInfo("Name", "mName", 0xBA1B6500, TdfType.String, 7, true), // NAME
        new TdfMemberInfo("ShortDesc", "mShortDesc", 0xCE4CE300, TdfType.String, 8, true), // SDSC
        new TdfMemberInfo("Type", "mType", 0xD39C2500, TdfType.Int32, 9, true), // TYPE
    ];
    private ITdfMember[] __members;

    private TdfString _category = new(__typeInfos[0]);
    private TdfString _defaultValue = new(__typeInfos[1]);
    private TdfBool _derived = new(__typeInfos[2]);
    private TdfString _format = new(__typeInfos[3]);
    private TdfString _kind = new(__typeInfos[4]);
    private TdfString _longDesc = new(__typeInfos[5]);
    private TdfString _metadata = new(__typeInfos[6]);
    private TdfString _name = new(__typeInfos[7]);
    private TdfString _shortDesc = new(__typeInfos[8]);
    private TdfInt32 _type = new(__typeInfos[9]);

    public StatDescSummary()
    {
        __members = [
            _category,
            _defaultValue,
            _derived,
            _format,
            _kind,
            _longDesc,
            _metadata,
            _name,
            _shortDesc,
            _type,
        ];
    }

    public override Tdf CreateNew() => new StatDescSummary();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "StatDescSummary";
    public override string GetFullClassName() => "Blaze::Stats::StatDescSummary";

    public string Category
    {
        get => _category.Value;
        set => _category.Value = value;
    }

    public string DefaultValue
    {
        get => _defaultValue.Value;
        set => _defaultValue.Value = value;
    }

    public bool Derived
    {
        get => _derived.Value;
        set => _derived.Value = value;
    }

    public string Format
    {
        get => _format.Value;
        set => _format.Value = value;
    }

    public string Kind
    {
        get => _kind.Value;
        set => _kind.Value = value;
    }

    public string LongDesc
    {
        get => _longDesc.Value;
        set => _longDesc.Value = value;
    }

    public string Metadata
    {
        get => _metadata.Value;
        set => _metadata.Value = value;
    }

    public string Name
    {
        get => _name.Value;
        set => _name.Value = value;
    }

    public string ShortDesc
    {
        get => _shortDesc.Value;
        set => _shortDesc.Value = value;
    }

    public int Type
    {
        get => _type.Value;
        set => _type.Value = value;
    }

}

