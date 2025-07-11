using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameReporting.Frostbite;

public class GroupReport : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Stats", "mStats", 0x874CA200, TdfType.Map, 0, true), // ATRB
        new TdfMemberInfo("PlayerReports", "mPlayerReports", 0xC2CE7200, TdfType.Map, 1, true), // PLYR
    ];
    private ITdfMember[] __members;

    private TdfMap<string, float> _stats = new(__typeInfos[0]);
    private TdfMap<long, Blaze3SDK.Blaze.GameReporting.Frostbite.EntityReport> _playerReports = new(__typeInfos[1]);

    public GroupReport()
    {
        __members = [
            _stats,
            _playerReports,
        ];
    }

    public override Tdf CreateNew() => new GroupReport();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GroupReport";
    public override string GetFullClassName() => "Blaze::GameReporting::Frostbite::GroupReport";

    public IDictionary<string, float> Stats
    {
        get => _stats.Value;
        set => _stats.Value = value;
    }

    public IDictionary<long, Blaze3SDK.Blaze.GameReporting.Frostbite.EntityReport> PlayerReports
    {
        get => _playerReports.Value;
        set => _playerReports.Value = value;
    }

}

