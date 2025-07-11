using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameReporting;

public class GameReportColumnKey : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Index", "mIndex", 0x86993800, TdfType.UInt16, 0, true), // AIDX
        new TdfMemberInfo("AttributeName", "mAttributeName", 0x86E86D00, TdfType.String, 1, true), // ANAM
        new TdfMemberInfo("Table", "mTable", 0xD218AE00, TdfType.String, 2, true), // TABN
    ];
    private ITdfMember[] __members;

    private TdfUInt16 _index = new(__typeInfos[0]);
    private TdfString _attributeName = new(__typeInfos[1]);
    private TdfString _table = new(__typeInfos[2]);

    public GameReportColumnKey()
    {
        __members = [
            _index,
            _attributeName,
            _table,
        ];
    }

    public override Tdf CreateNew() => new GameReportColumnKey();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GameReportColumnKey";
    public override string GetFullClassName() => "Blaze::GameReporting::GameReportColumnKey";

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

    public string Table
    {
        get => _table.Value;
        set => _table.Value = value;
    }

}

