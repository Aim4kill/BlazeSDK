using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.GameReporting;

public class GameReportsList : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("GameReportList", "mGameReportList", 0x9EDCB300, TdfType.List, 0, true), // GMRS
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze2SDK.Blaze.GameReporting.GameReport> _gameReportList = new(__typeInfos[0]);

    public GameReportsList()
    {
        __members = [
            _gameReportList,
        ];
    }

    public override Tdf CreateNew() => new GameReportsList();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GameReportsList";
    public override string GetFullClassName() => "Blaze::GameReporting::GameReportsList";

    public IList<Blaze2SDK.Blaze.GameReporting.GameReport> GameReportList
    {
        get => _gameReportList.Value;
        set => _gameReportList.Value = value;
    }

}

