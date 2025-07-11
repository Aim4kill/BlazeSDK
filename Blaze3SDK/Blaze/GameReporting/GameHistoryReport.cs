using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameReporting;

public class GameHistoryReport : Tdf
{
    public class TableRow : Tdf
    {
        static readonly TdfMemberInfo[] __typeInfos = [
            new TdfMemberInfo("AttributeMap", "mAttributeMap", 0xD32BF700, TdfType.Map, 0, true), // TROW
        ];
        private ITdfMember[] __members;
    
        private TdfMap<string, string> _attributeMap = new(__typeInfos[0]);
    
        public TableRow()
        {
            __members = [
                _attributeMap,
            ];
        }
    
        public override Tdf CreateNew() => new TableRow();
        public override ITdfMember[] GetMembers() => __members;
        public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
        public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
        public override string GetClassName() => "TableRow";
        public override string GetFullClassName() => "Blaze::GameReporting::GameHistoryReport::TableRow";
    
        public IDictionary<string, string> AttributeMap
        {
            get => _attributeMap.Value;
            set => _attributeMap.Value = value;
        }
    
    }
    
    public class TableRows : Tdf
    {
        static readonly TdfMemberInfo[] __typeInfos = [
            new TdfMemberInfo("TableRowList", "mTableRowList", 0xCACA7300, TdfType.List, 0, true), // RLIS
        ];
        private ITdfMember[] __members;
    
        private TdfList<Blaze3SDK.Blaze.GameReporting.GameHistoryReport.TableRow> _tableRowList = new(__typeInfos[0]);
    
        public TableRows()
        {
            __members = [
                _tableRowList,
            ];
        }
    
        public override Tdf CreateNew() => new TableRows();
        public override ITdfMember[] GetMembers() => __members;
        public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
        public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
        public override string GetClassName() => "TableRows";
        public override string GetFullClassName() => "Blaze::GameReporting::GameHistoryReport::TableRows";
    
        public IList<Blaze3SDK.Blaze.GameReporting.GameHistoryReport.TableRow> TableRowList
        {
            get => _tableRowList.Value;
            set => _tableRowList.Value = value;
        }
    
    }
    
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("GameHistoryId", "mGameHistoryId", 0x9E8A6400, TdfType.UInt64, 0, true), // GHID
        new TdfMemberInfo("GameReportingId", "mGameReportingId", 0x9F2A6400, TdfType.UInt64, 1, true), // GRID
        new TdfMemberInfo("GameTypeName", "mGameTypeName", 0x9F4E7000, TdfType.String, 2, true), // GTYP
        new TdfMemberInfo("Timestamp", "mTimestamp", 0xD29B6500, TdfType.Int64, 3, true), // TIME
        new TdfMemberInfo("TableRowMap", "mTableRowMap", 0xD32B4000, TdfType.Map, 4, true), // TRM
    ];
    private ITdfMember[] __members;

    private TdfUInt64 _gameHistoryId = new(__typeInfos[0]);
    private TdfUInt64 _gameReportingId = new(__typeInfos[1]);
    private TdfString _gameTypeName = new(__typeInfos[2]);
    private TdfInt64 _timestamp = new(__typeInfos[3]);
    private TdfMap<string, Blaze3SDK.Blaze.GameReporting.GameHistoryReport.TableRows> _tableRowMap = new(__typeInfos[4]);

    public GameHistoryReport()
    {
        __members = [
            _gameHistoryId,
            _gameReportingId,
            _gameTypeName,
            _timestamp,
            _tableRowMap,
        ];
    }

    public override Tdf CreateNew() => new GameHistoryReport();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GameHistoryReport";
    public override string GetFullClassName() => "Blaze::GameReporting::GameHistoryReport";

    public ulong GameHistoryId
    {
        get => _gameHistoryId.Value;
        set => _gameHistoryId.Value = value;
    }

    public ulong GameReportingId
    {
        get => _gameReportingId.Value;
        set => _gameReportingId.Value = value;
    }

    public string GameTypeName
    {
        get => _gameTypeName.Value;
        set => _gameTypeName.Value = value;
    }

    public long Timestamp
    {
        get => _timestamp.Value;
        set => _timestamp.Value = value;
    }

    public IDictionary<string, Blaze3SDK.Blaze.GameReporting.GameHistoryReport.TableRows> TableRowMap
    {
        get => _tableRowMap.Value;
        set => _tableRowMap.Value = value;
    }

}

