using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Stats;

public class LeaderboardGroupRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("BoardId", "mBoardId", 0xB22A6400, TdfType.Int32, 0, true), // LBID
        new TdfMemberInfo("BoardName", "mBoardName", 0xBA1B6500, TdfType.String, 1, true), // NAME
    ];
    private ITdfMember[] __members;

    private TdfInt32 _boardId = new(__typeInfos[0]);
    private TdfString _boardName = new(__typeInfos[1]);

    public LeaderboardGroupRequest()
    {
        __members = [
            _boardId,
            _boardName,
        ];
    }

    public override Tdf CreateNew() => new LeaderboardGroupRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "LeaderboardGroupRequest";
    public override string GetFullClassName() => "Blaze::Stats::LeaderboardGroupRequest";

    public int BoardId
    {
        get => _boardId.Value;
        set => _boardId.Value = value;
    }

    public string BoardName
    {
        get => _boardName.Value;
        set => _boardName.Value = value;
    }

}

