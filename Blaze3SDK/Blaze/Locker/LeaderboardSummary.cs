using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Locker;

public class LeaderboardSummary : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Size", "mSize", 0xCE9EA500, TdfType.Int32, 0, true), // SIZE
        new TdfMemberInfo("TagsIncluded", "mTagsIncluded", 0xD219F300, TdfType.Int32, 1, true), // TAGS
        new TdfMemberInfo("LeaderboardView", "mLeaderboardView", 0xDA997700, TdfType.String, 2, true), // VIEW
    ];
    private ITdfMember[] __members;

    private TdfInt32 _size = new(__typeInfos[0]);
    private TdfInt32 _tagsIncluded = new(__typeInfos[1]);
    private TdfString _leaderboardView = new(__typeInfos[2]);

    public LeaderboardSummary()
    {
        __members = [
            _size,
            _tagsIncluded,
            _leaderboardView,
        ];
    }

    public override Tdf CreateNew() => new LeaderboardSummary();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "LeaderboardSummary";
    public override string GetFullClassName() => "Blaze::Locker::LeaderboardSummary";

    public int Size
    {
        get => _size.Value;
        set => _size.Value = value;
    }

    public int TagsIncluded
    {
        get => _tagsIncluded.Value;
        set => _tagsIncluded.Value = value;
    }

    public string LeaderboardView
    {
        get => _leaderboardView.Value;
        set => _leaderboardView.Value = value;
    }

}

