using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Locker;

public class ListContentForUsersRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Attributes", "mAttributes", 0x874D3200, TdfType.List, 0, true), // ATTR
        new TdfMemberInfo("ContentCategory", "mContentCategory", 0x8E387400, TdfType.String, 1, true), // CCAT
        new TdfMemberInfo("EntityIds", "mEntityIds", 0x96990000, TdfType.List, 2, true), // EID
        new TdfMemberInfo("GroupId", "mGroupId", 0x9F0A6400, TdfType.ObjectId, 3, true), // GPID
        new TdfMemberInfo("MaxResultCount", "mMaxResultCount", 0xB78CA300, TdfType.UInt32, 4, true), // MXRC
        new TdfMemberInfo("Offset", "mOffset", 0xBE6CA300, TdfType.UInt32, 5, true), // OFRC
        new TdfMemberInfo("ObjectId", "mObjectId", 0xBEAA6400, TdfType.ObjectId, 6, true), // OJID
        new TdfMemberInfo("PermissionFlag", "mPermissionFlag", 0xC25CAD00, TdfType.Enum, 7, true), // PERM
        new TdfMemberInfo("ReferenceFlag", "mReferenceFlag", 0xCA59A600, TdfType.Enum, 8, true), // REFF
        new TdfMemberInfo("Tags", "mTags", 0xD219F300, TdfType.List, 9, true), // TAGS
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze3SDK.Blaze.Locker.Attribute> _attributes = new(__typeInfos[0]);
    private TdfString _contentCategory = new(__typeInfos[1]);
    private TdfList<long> _entityIds = new(__typeInfos[2]);
    private TdfObjectId _groupId = new(__typeInfos[3]);
    private TdfUInt32 _maxResultCount = new(__typeInfos[4]);
    private TdfUInt32 _offset = new(__typeInfos[5]);
    private TdfObjectId _objectId = new(__typeInfos[6]);
    private TdfEnum<Blaze3SDK.Blaze.Locker.PermissionFlag> _permissionFlag = new(__typeInfos[7]);
    private TdfEnum<Blaze3SDK.Blaze.Locker.RefSearchFlag> _referenceFlag = new(__typeInfos[8]);
    private TdfList<Blaze3SDK.Blaze.Locker.Tag> _tags = new(__typeInfos[9]);

    public ListContentForUsersRequest()
    {
        __members = [
            _attributes,
            _contentCategory,
            _entityIds,
            _groupId,
            _maxResultCount,
            _offset,
            _objectId,
            _permissionFlag,
            _referenceFlag,
            _tags,
        ];
    }

    public override Tdf CreateNew() => new ListContentForUsersRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ListContentForUsersRequest";
    public override string GetFullClassName() => "Blaze::Locker::ListContentForUsersRequest";

    public IList<Blaze3SDK.Blaze.Locker.Attribute> Attributes
    {
        get => _attributes.Value;
        set => _attributes.Value = value;
    }

    public string ContentCategory
    {
        get => _contentCategory.Value;
        set => _contentCategory.Value = value;
    }

    public IList<long> EntityIds
    {
        get => _entityIds.Value;
        set => _entityIds.Value = value;
    }

    public ObjectId GroupId
    {
        get => _groupId.Value;
        set => _groupId.Value = value;
    }

    public uint MaxResultCount
    {
        get => _maxResultCount.Value;
        set => _maxResultCount.Value = value;
    }

    public uint Offset
    {
        get => _offset.Value;
        set => _offset.Value = value;
    }

    public ObjectId ObjectId
    {
        get => _objectId.Value;
        set => _objectId.Value = value;
    }

    public Blaze3SDK.Blaze.Locker.PermissionFlag PermissionFlag
    {
        get => _permissionFlag.Value;
        set => _permissionFlag.Value = value;
    }

    public Blaze3SDK.Blaze.Locker.RefSearchFlag ReferenceFlag
    {
        get => _referenceFlag.Value;
        set => _referenceFlag.Value = value;
    }

    public IList<Blaze3SDK.Blaze.Locker.Tag> Tags
    {
        get => _tags.Value;
        set => _tags.Value = value;
    }

}

