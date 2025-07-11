using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameReportingLegacy;

public class GameReport : Tdf
{
    public class Report : Tdf
    {
        static readonly TdfMemberInfo[] __typeInfos = [
            new TdfMemberInfo("AttributeMap", "mAttributeMap", 0xCB0CB400, TdfType.Map, 0, true), // RPRT
        ];
        private ITdfMember[] __members;
    
        private TdfMap<string, string> _attributeMap = new(__typeInfos[0]);
    
        public Report()
        {
            __members = [
                _attributeMap,
            ];
        }
    
        public override Tdf CreateNew() => new Report();
        public override ITdfMember[] GetMembers() => __members;
        public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
        public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
        public override string GetClassName() => "Report";
        public override string GetFullClassName() => "Blaze::GameReportingLegacy::GameReport::Report";
    
        public IDictionary<string, string> AttributeMap
        {
            get => _attributeMap.Value;
            set => _attributeMap.Value = value;
        }
    
    }
    
    public class ReportType : Tdf
    {
        static readonly TdfMemberInfo[] __typeInfos = [
            new TdfMemberInfo("ReportMap", "mReportMap", 0xCB0B7000, TdfType.Map, 0, true), // RPMP
        ];
        private ITdfMember[] __members;
    
        private TdfMap<long, Blaze3SDK.Blaze.GameReportingLegacy.GameReport.Report> _reportMap = new(__typeInfos[0]);
    
        public ReportType()
        {
            __members = [
                _reportMap,
            ];
        }
    
        public override Tdf CreateNew() => new ReportType();
        public override ITdfMember[] GetMembers() => __members;
        public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
        public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
        public override string GetClassName() => "ReportType";
        public override string GetFullClassName() => "Blaze::GameReportingLegacy::GameReport::ReportType";
    
        public IDictionary<long, Blaze3SDK.Blaze.GameReportingLegacy.GameReport.Report> ReportMap
        {
            get => _reportMap.Value;
            set => _reportMap.Value = value;
        }
    
    }
    
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("AttributeMap", "mAttributeMap", 0x874CA200, TdfType.Map, 0, true), // ATRB
        new TdfMemberInfo("Finished", "mFinished", 0x9AECE800, TdfType.Bool, 1, true), // FNSH
        new TdfMemberInfo("GameReportingId", "mGameReportingId", 0x9F2A6400, TdfType.UInt64, 2, true), // GRID
        new TdfMemberInfo("GameTypeId", "mGameTypeId", 0x9F4E7000, TdfType.UInt32, 3, true), // GTYP
        new TdfMemberInfo("Process", "mProcess", 0xC328F300, TdfType.Bool, 4, true), // PRCS
        new TdfMemberInfo("PlayerReportMap", "mPlayerReportMap", 0xCB0CB400, TdfType.Map, 5, true), // RPRT
        new TdfMemberInfo("ReportTypeMap", "mReportTypeMap", 0xCB4B4000, TdfType.Map, 6, true), // RTM
    ];
    private ITdfMember[] __members;

    private TdfMap<string, string> _attributeMap = new(__typeInfos[0]);
    private TdfBool _finished = new(__typeInfos[1]);
    private TdfUInt64 _gameReportingId = new(__typeInfos[2]);
    private TdfUInt32 _gameTypeId = new(__typeInfos[3]);
    private TdfBool _process = new(__typeInfos[4]);
    private TdfMap<long, Blaze3SDK.Blaze.GameReportingLegacy.GameReport.Report> _playerReportMap = new(__typeInfos[5]);
    private TdfMap<string, Blaze3SDK.Blaze.GameReportingLegacy.GameReport.ReportType> _reportTypeMap = new(__typeInfos[6]);

    public GameReport()
    {
        __members = [
            _attributeMap,
            _finished,
            _gameReportingId,
            _gameTypeId,
            _process,
            _playerReportMap,
            _reportTypeMap,
        ];
    }

    public override Tdf CreateNew() => new GameReport();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GameReport";
    public override string GetFullClassName() => "Blaze::GameReportingLegacy::GameReport";

    public IDictionary<string, string> AttributeMap
    {
        get => _attributeMap.Value;
        set => _attributeMap.Value = value;
    }

    public bool Finished
    {
        get => _finished.Value;
        set => _finished.Value = value;
    }

    public ulong GameReportingId
    {
        get => _gameReportingId.Value;
        set => _gameReportingId.Value = value;
    }

    public uint GameTypeId
    {
        get => _gameTypeId.Value;
        set => _gameTypeId.Value = value;
    }

    public bool Process
    {
        get => _process.Value;
        set => _process.Value = value;
    }

    public IDictionary<long, Blaze3SDK.Blaze.GameReportingLegacy.GameReport.Report> PlayerReportMap
    {
        get => _playerReportMap.Value;
        set => _playerReportMap.Value = value;
    }

    public IDictionary<string, Blaze3SDK.Blaze.GameReportingLegacy.GameReport.ReportType> ReportTypeMap
    {
        get => _reportTypeMap.Value;
        set => _reportTypeMap.Value = value;
    }

}

