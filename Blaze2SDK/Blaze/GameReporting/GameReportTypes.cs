using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.GameReporting;

public class GameReportTypes : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("GameReportTypes", "mGameReportTypes", 0x9F2D3300, TdfType.List, 0, true), // GRTS
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze2SDK.Blaze.GameReporting.GameReportType> _gameReportTypes = new(__typeInfos[0]);

    public GameReportTypes()
    {
        __members = [
            _gameReportTypes,
        ];
    }

    public override Tdf CreateNew() => new GameReportTypes();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GameReportTypes";
    public override string GetFullClassName() => "Blaze::GameReporting::GameReportTypes";

    public IList<Blaze2SDK.Blaze.GameReporting.GameReportType> mGameReportTypes
    {
        get => _gameReportTypes.Value;
        set => _gameReportTypes.Value = value;
    }

}

