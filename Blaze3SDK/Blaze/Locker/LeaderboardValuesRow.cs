using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Locker;

public class LeaderboardValuesRow : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Attrs", "mAttrs", 0x874D3200, TdfType.List, 0, true), // ATTR
        new TdfMemberInfo("ContentId", "mContentId", 0x8E990000, TdfType.Int32, 1, true), // CID
        new TdfMemberInfo("EntityId", "mEntityId", 0x96990000, TdfType.Int64, 2, true), // EID
        new TdfMemberInfo("EntityName", "mEntityName", 0x96E86D00, TdfType.String, 3, true), // ENAM
        new TdfMemberInfo("Rank", "mRank", 0xCA1BAB00, TdfType.Int32, 4, true), // RANK
        new TdfMemberInfo("Tags", "mTags", 0xD219F300, TdfType.List, 5, true), // TAGS
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze3SDK.Blaze.Locker.Attribute> _attrs = new(__typeInfos[0]);
    private TdfInt32 _contentId = new(__typeInfos[1]);
    private TdfInt64 _entityId = new(__typeInfos[2]);
    private TdfString _entityName = new(__typeInfos[3]);
    private TdfInt32 _rank = new(__typeInfos[4]);
    private TdfList<string> _tags = new(__typeInfos[5]);

    public LeaderboardValuesRow()
    {
        __members = [
            _attrs,
            _contentId,
            _entityId,
            _entityName,
            _rank,
            _tags,
        ];
    }

    public override Tdf CreateNew() => new LeaderboardValuesRow();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "LeaderboardValuesRow";
    public override string GetFullClassName() => "Blaze::Locker::LeaderboardValuesRow";

    public IList<Blaze3SDK.Blaze.Locker.Attribute> Attrs
    {
        get => _attrs.Value;
        set => _attrs.Value = value;
    }

    public int ContentId
    {
        get => _contentId.Value;
        set => _contentId.Value = value;
    }

    public long EntityId
    {
        get => _entityId.Value;
        set => _entityId.Value = value;
    }

    public string EntityName
    {
        get => _entityName.Value;
        set => _entityName.Value = value;
    }

    public int Rank
    {
        get => _rank.Value;
        set => _rank.Value = value;
    }

    public IList<string> Tags
    {
        get => _tags.Value;
        set => _tags.Value = value;
    }

}

