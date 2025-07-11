using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameReporting;

public class TableData : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Columns", "mColumns", 0x8EFB3300, TdfType.List, 0, true), // COLS
        new TdfMemberInfo("PrimaryKey", "mPrimaryKey", 0xC2B97900, TdfType.List, 1, true), // PKEY
        new TdfMemberInfo("Table", "mTable", 0xD218AE00, TdfType.String, 2, true), // TABN
    ];
    private ITdfMember[] __members;

    private TdfList<string> _columns = new(__typeInfos[0]);
    private TdfList<string> _primaryKey = new(__typeInfos[1]);
    private TdfString _table = new(__typeInfos[2]);

    public TableData()
    {
        __members = [
            _columns,
            _primaryKey,
            _table,
        ];
    }

    public override Tdf CreateNew() => new TableData();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "TableData";
    public override string GetFullClassName() => "Blaze::GameReporting::TableData";

    public IList<string> Columns
    {
        get => _columns.Value;
        set => _columns.Value = value;
    }

    public IList<string> PrimaryKey
    {
        get => _primaryKey.Value;
        set => _primaryKey.Value = value;
    }

    public string Table
    {
        get => _table.Value;
        set => _table.Value = value;
    }

}

