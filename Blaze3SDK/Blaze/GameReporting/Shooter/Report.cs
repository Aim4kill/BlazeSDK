using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameReporting.Shooter;

public class Report : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("GroupReports", "mGroupReports", 0x8EC8B300, TdfType.Map, 0, true), // CLBS
        new TdfMemberInfo("GameAttributes", "mGameAttributes", 0x9E1B6500, TdfType.Map, 1, true), // GAME
        new TdfMemberInfo("PlayerReports", "mPlayerReports", 0xC2CE7200, TdfType.Map, 2, true), // PLYR
    ];
    private ITdfMember[] __members;

    private TdfMap<uint, Blaze3SDK.Blaze.GameReporting.Shooter.GroupReport> _groupReports = new(__typeInfos[0]);
    private TdfMap<string, string> _gameAttributes = new(__typeInfos[1]);
    private TdfMap<long, Blaze3SDK.Blaze.GameReporting.Shooter.EntityReport> _playerReports = new(__typeInfos[2]);

    public Report()
    {
        __members = [
            _groupReports,
            _gameAttributes,
            _playerReports,
        ];
    }

    public override Tdf CreateNew() => new Report();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "Report";
    public override string GetFullClassName() => "Blaze::GameReporting::Shooter::Report";

    public IDictionary<uint, Blaze3SDK.Blaze.GameReporting.Shooter.GroupReport> GroupReports
    {
        get => _groupReports.Value;
        set => _groupReports.Value = value;
    }

    public IDictionary<string, string> GameAttributes
    {
        get => _gameAttributes.Value;
        set => _gameAttributes.Value = value;
    }

    public IDictionary<long, Blaze3SDK.Blaze.GameReporting.Shooter.EntityReport> PlayerReports
    {
        get => _playerReports.Value;
        set => _playerReports.Value = value;
    }

}

