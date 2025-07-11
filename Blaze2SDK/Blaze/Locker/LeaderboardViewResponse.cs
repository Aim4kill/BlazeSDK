using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Locker;

public class LeaderboardViewResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ContentCategory", "mContentCategory", 0x8E387400, TdfType.String, 0, true), // CCAT
        new TdfMemberInfo("ContextType", "mContextType", 0x8F4E7000, TdfType.UInt32, 1, true), // CTYP
        new TdfMemberInfo("Desc", "mDesc", 0x925CE300, TdfType.String, 2, true), // DESC
        new TdfMemberInfo("EntityType", "mEntityType", 0x974E7000, TdfType.UInt32, 3, true), // ETYP
        new TdfMemberInfo("LeaderboardType", "mLeaderboardType", 0xB2200000, TdfType.Enum, 4, true), // LB
        new TdfMemberInfo("ViewColumns", "mViewColumns", 0xB29CF400, TdfType.List, 5, true), // LIST
        new TdfMemberInfo("Size", "mSize", 0xCE9EA500, TdfType.Int32, 6, true), // SIZE
        new TdfMemberInfo("TagsIncluded", "mTagsIncluded", 0xD219F300, TdfType.Int32, 7, true), // TAGS
        new TdfMemberInfo("LeaderboardView", "mLeaderboardView", 0xDA997700, TdfType.String, 8, true), // VIEW
    ];
    private ITdfMember[] __members;

    private TdfString _contentCategory = new(__typeInfos[0]);
    private TdfUInt32 _contextType = new(__typeInfos[1]);
    private TdfString _desc = new(__typeInfos[2]);
    private TdfUInt32 _entityType = new(__typeInfos[3]);
    private TdfEnum<Blaze2SDK.Blaze.Locker.LeaderboardType> _leaderboardType = new(__typeInfos[4]);
    private TdfList<Blaze2SDK.Blaze.Locker.LeaderboardViewColumn> _viewColumns = new(__typeInfos[5]);
    private TdfInt32 _size = new(__typeInfos[6]);
    private TdfInt32 _tagsIncluded = new(__typeInfos[7]);
    private TdfString _leaderboardView = new(__typeInfos[8]);

    public LeaderboardViewResponse()
    {
        __members = [
            _contentCategory,
            _contextType,
            _desc,
            _entityType,
            _leaderboardType,
            _viewColumns,
            _size,
            _tagsIncluded,
            _leaderboardView,
        ];
    }

    public override Tdf CreateNew() => new LeaderboardViewResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "LeaderboardViewResponse";
    public override string GetFullClassName() => "Blaze::Locker::LeaderboardViewResponse";

    public string ContentCategory
    {
        get => _contentCategory.Value;
        set => _contentCategory.Value = value;
    }

    public uint ContextType
    {
        get => _contextType.Value;
        set => _contextType.Value = value;
    }

    public string Desc
    {
        get => _desc.Value;
        set => _desc.Value = value;
    }

    public uint EntityType
    {
        get => _entityType.Value;
        set => _entityType.Value = value;
    }

    public Blaze2SDK.Blaze.Locker.LeaderboardType LeaderboardType
    {
        get => _leaderboardType.Value;
        set => _leaderboardType.Value = value;
    }

    public IList<Blaze2SDK.Blaze.Locker.LeaderboardViewColumn> ViewColumns
    {
        get => _viewColumns.Value;
        set => _viewColumns.Value = value;
    }

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

