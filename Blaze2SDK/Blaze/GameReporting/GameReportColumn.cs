using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.GameReporting;

public class GameReportColumn : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("AttributeName", "mAttributeName", 0x86E86D00, TdfType.String, 0, true), // ANAM
        new TdfMemberInfo("Index", "mIndex", 0x874A6400, TdfType.UInt32, 1, true), // ATID
        new TdfMemberInfo("AttributeType", "mAttributeType", 0x874E7000, TdfType.String, 2, true), // ATYP
        new TdfMemberInfo("Type", "mType", 0x934E7000, TdfType.Int32, 3, true), // DTYP
        new TdfMemberInfo("EntityType", "mEntityType", 0x974E7000, TdfType.UInt32, 4, true), // ETYP
        new TdfMemberInfo("Format", "mFormat", 0x9B2B7400, TdfType.String, 5, true), // FRMT
        new TdfMemberInfo("Kind", "mKind", 0xAE9BA400, TdfType.String, 6, true), // KIND
        new TdfMemberInfo("Desc", "mDesc", 0xB24CE300, TdfType.String, 7, true), // LDSC
        new TdfMemberInfo("Metadata", "mMetadata", 0xB65D2100, TdfType.String, 8, true), // META
        new TdfMemberInfo("ShortDesc", "mShortDesc", 0xCE4CE300, TdfType.String, 9, true), // SDSC
        new TdfMemberInfo("Values", "mValues", 0xDA1B3500, TdfType.List, 10, true), // VALU
    ];
    private ITdfMember[] __members;

    private TdfString _attributeName = new(__typeInfos[0]);
    private TdfUInt32 _index = new(__typeInfos[1]);
    private TdfString _attributeType = new(__typeInfos[2]);
    private TdfInt32 _type = new(__typeInfos[3]);
    private TdfUInt32 _entityType = new(__typeInfos[4]);
    private TdfString _format = new(__typeInfos[5]);
    private TdfString _kind = new(__typeInfos[6]);
    private TdfString _desc = new(__typeInfos[7]);
    private TdfString _metadata = new(__typeInfos[8]);
    private TdfString _shortDesc = new(__typeInfos[9]);
    private TdfList<string> _values = new(__typeInfos[10]);

    public GameReportColumn()
    {
        __members = [
            _attributeName,
            _index,
            _attributeType,
            _type,
            _entityType,
            _format,
            _kind,
            _desc,
            _metadata,
            _shortDesc,
            _values,
        ];
    }

    public override Tdf CreateNew() => new GameReportColumn();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GameReportColumn";
    public override string GetFullClassName() => "Blaze::GameReporting::GameReportColumn";

    public string AttributeName
    {
        get => _attributeName.Value;
        set => _attributeName.Value = value;
    }

    public uint Index
    {
        get => _index.Value;
        set => _index.Value = value;
    }

    public string AttributeType
    {
        get => _attributeType.Value;
        set => _attributeType.Value = value;
    }

    public int Type
    {
        get => _type.Value;
        set => _type.Value = value;
    }

    public uint EntityType
    {
        get => _entityType.Value;
        set => _entityType.Value = value;
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

    public string Desc
    {
        get => _desc.Value;
        set => _desc.Value = value;
    }

    public string Metadata
    {
        get => _metadata.Value;
        set => _metadata.Value = value;
    }

    public string ShortDesc
    {
        get => _shortDesc.Value;
        set => _shortDesc.Value = value;
    }

    public IList<string> Values
    {
        get => _values.Value;
        set => _values.Value = value;
    }

}

