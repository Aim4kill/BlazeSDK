using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameManager;

public class GetGameListResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ListId", "mListId", 0x9ECA6400, TdfType.UInt32, 0, true), // GLID
        new TdfMemberInfo("MaxPossibleFitScore", "mMaxPossibleFitScore", 0xB61E2600, TdfType.UInt32, 1, true), // MAXF
        new TdfMemberInfo("NumberOfGamesToBeDownloaded", "mNumberOfGamesToBeDownloaded", 0xBA790000, TdfType.UInt32, 2, true), // NGD
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _listId = new(__typeInfos[0]);
    private TdfUInt32 _maxPossibleFitScore = new(__typeInfos[1]);
    private TdfUInt32 _numberOfGamesToBeDownloaded = new(__typeInfos[2]);

    public GetGameListResponse()
    {
        __members = [
            _listId,
            _maxPossibleFitScore,
            _numberOfGamesToBeDownloaded,
        ];
    }

    public override Tdf CreateNew() => new GetGameListResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetGameListResponse";
    public override string GetFullClassName() => "Blaze::GameManager::GetGameListResponse";

    public uint ListId
    {
        get => _listId.Value;
        set => _listId.Value = value;
    }

    public uint MaxPossibleFitScore
    {
        get => _maxPossibleFitScore.Value;
        set => _maxPossibleFitScore.Value = value;
    }

    public uint NumberOfGamesToBeDownloaded
    {
        get => _numberOfGamesToBeDownloaded.Value;
        set => _numberOfGamesToBeDownloaded.Value = value;
    }

}

