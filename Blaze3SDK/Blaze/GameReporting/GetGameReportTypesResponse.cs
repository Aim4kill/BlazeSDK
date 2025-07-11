using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameReporting;

public class GetGameReportTypesResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("GameReportTypes", "mGameReportTypes", 0x9F2D3300, TdfType.List, 0, true), // GRTS
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze3SDK.Blaze.GameReporting.GameReportType> _gameReportTypes = new(__typeInfos[0]);

    public GetGameReportTypesResponse()
    {
        __members = [
            _gameReportTypes,
        ];
    }

    public override Tdf CreateNew() => new GetGameReportTypesResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetGameReportTypesResponse";
    public override string GetFullClassName() => "Blaze::GameReporting::GetGameReportTypesResponse";

    public IList<Blaze3SDK.Blaze.GameReporting.GameReportType> GameReportTypes
    {
        get => _gameReportTypes.Value;
        set => _gameReportTypes.Value = value;
    }

}

