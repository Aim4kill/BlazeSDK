using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Locker;

public class ListContentRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Attributes", "mAttributes", 0x874D3200, TdfType.List, 0, true), // ATTR
        new TdfMemberInfo("ContentCategory", "mContentCategory", 0x8E387400, TdfType.String, 1, true), // CCAT
        new TdfMemberInfo("EntityId", "mEntityId", 0x96990000, TdfType.UInt32, 2, true), // EID
        new TdfMemberInfo("GroupId", "mGroupId", 0x9F0A6400, TdfType.UInt64, 3, true), // GPID
        new TdfMemberInfo("PermissionFlag", "mPermissionFlag", 0xC25CAD00, TdfType.Enum, 4, true), // PERM
        new TdfMemberInfo("ReferenceFlag", "mReferenceFlag", 0xCA59A600, TdfType.Enum, 5, true), // REFF
        new TdfMemberInfo("Tags", "mTags", 0xD219F300, TdfType.List, 6, true), // TAGS
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze2SDK.Blaze.Locker.Attribute> _attributes = new(__typeInfos[0]);
    private TdfString _contentCategory = new(__typeInfos[1]);
    private TdfUInt32 _entityId = new(__typeInfos[2]);
    private TdfUInt64 _groupId = new(__typeInfos[3]);
    private TdfEnum<Blaze2SDK.Blaze.Locker.PermissionFlag> _permissionFlag = new(__typeInfos[4]);
    private TdfEnum<Blaze2SDK.Blaze.Locker.RefSearchFlag> _referenceFlag = new(__typeInfos[5]);
    private TdfList<Blaze2SDK.Blaze.Locker.Tag> _tags = new(__typeInfos[6]);

    public ListContentRequest()
    {
        __members = [
            _attributes,
            _contentCategory,
            _entityId,
            _groupId,
            _permissionFlag,
            _referenceFlag,
            _tags,
        ];
    }

    public override Tdf CreateNew() => new ListContentRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ListContentRequest";
    public override string GetFullClassName() => "Blaze::Locker::ListContentRequest";

    public IList<Blaze2SDK.Blaze.Locker.Attribute> Attributes
    {
        get => _attributes.Value;
        set => _attributes.Value = value;
    }

    public string ContentCategory
    {
        get => _contentCategory.Value;
        set => _contentCategory.Value = value;
    }

    public uint EntityId
    {
        get => _entityId.Value;
        set => _entityId.Value = value;
    }

    public ulong GroupId
    {
        get => _groupId.Value;
        set => _groupId.Value = value;
    }

    public Blaze2SDK.Blaze.Locker.PermissionFlag PermissionFlag
    {
        get => _permissionFlag.Value;
        set => _permissionFlag.Value = value;
    }

    public Blaze2SDK.Blaze.Locker.RefSearchFlag ReferenceFlag
    {
        get => _referenceFlag.Value;
        set => _referenceFlag.Value = value;
    }

    public IList<Blaze2SDK.Blaze.Locker.Tag> Tags
    {
        get => _tags.Value;
        set => _tags.Value = value;
    }

}

