using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameReporting;

public class GameReportFilter : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Index", "mIndex", 0x86993800, TdfType.UInt16, 0, true), // AIDX
        new TdfMemberInfo("AttributeName", "mAttributeName", 0x86E86D00, TdfType.String, 1, true), // ANAM
        new TdfMemberInfo("EntityType", "mEntityType", 0x974E7000, TdfType.ObjectType, 2, true), // ETYP
        new TdfMemberInfo("Expression", "mExpression", 0x978C3200, TdfType.String, 3, true), // EXPR
        new TdfMemberInfo("HasVariable", "mHasVariable", 0xA3687200, TdfType.Bool, 4, true), // HVAR
        new TdfMemberInfo("Table", "mTable", 0xD218AE00, TdfType.String, 5, true), // TABN
    ];
    private ITdfMember[] __members;

    private TdfUInt16 _index = new(__typeInfos[0]);
    private TdfString _attributeName = new(__typeInfos[1]);
    private TdfObjectType _entityType = new(__typeInfos[2]);
    private TdfString _expression = new(__typeInfos[3]);
    private TdfBool _hasVariable = new(__typeInfos[4]);
    private TdfString _table = new(__typeInfos[5]);

    public GameReportFilter()
    {
        __members = [
            _index,
            _attributeName,
            _entityType,
            _expression,
            _hasVariable,
            _table,
        ];
    }

    public override Tdf CreateNew() => new GameReportFilter();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GameReportFilter";
    public override string GetFullClassName() => "Blaze::GameReporting::GameReportFilter";

    public ushort Index
    {
        get => _index.Value;
        set => _index.Value = value;
    }

    public string AttributeName
    {
        get => _attributeName.Value;
        set => _attributeName.Value = value;
    }

    public ObjectType EntityType
    {
        get => _entityType.Value;
        set => _entityType.Value = value;
    }

    public string Expression
    {
        get => _expression.Value;
        set => _expression.Value = value;
    }

    public bool HasVariable
    {
        get => _hasVariable.Value;
        set => _hasVariable.Value = value;
    }

    public string Table
    {
        get => _table.Value;
        set => _table.Value = value;
    }

}

