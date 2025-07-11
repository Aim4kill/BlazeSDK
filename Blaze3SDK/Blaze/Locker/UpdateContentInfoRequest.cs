using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Locker;

public class UpdateContentInfoRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Attributes", "mAttributes", 0x874D3200, TdfType.List, 0, true), // ATTR
        new TdfMemberInfo("ContentCategory", "mContentCategory", 0x8E387400, TdfType.String, 1, true), // CCAT
        new TdfMemberInfo("ContentId", "mContentId", 0x8E990000, TdfType.Int32, 2, true), // CID
        new TdfMemberInfo("ContextId", "mContextId", 0x8EFA6400, TdfType.Int64, 3, true), // COID
        new TdfMemberInfo("Description", "mDescription", 0x925CE300, TdfType.String, 4, true), // DESC
        new TdfMemberInfo("ExpireDate", "mExpireDate", 0x96487400, TdfType.Int32, 5, true), // EDAT
        new TdfMemberInfo("Name", "mName", 0xBA1B6500, TdfType.String, 6, true), // NAME
        new TdfMemberInfo("Permission", "mPermission", 0xC25CAD00, TdfType.Enum, 7, true), // PERM
        new TdfMemberInfo("Size", "mSize", 0xCE9EA500, TdfType.UInt32, 8, true), // SIZE
        new TdfMemberInfo("Tags", "mTags", 0xD219F300, TdfType.List, 9, true), // TAGS
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze3SDK.Blaze.Locker.Attribute> _attributes = new(__typeInfos[0]);
    private TdfString _contentCategory = new(__typeInfos[1]);
    private TdfInt32 _contentId = new(__typeInfos[2]);
    private TdfInt64 _contextId = new(__typeInfos[3]);
    private TdfString _description = new(__typeInfos[4]);
    private TdfInt32 _expireDate = new(__typeInfos[5]);
    private TdfString _name = new(__typeInfos[6]);
    private TdfEnum<Blaze3SDK.Blaze.Locker.Permission> _permission = new(__typeInfos[7]);
    private TdfUInt32 _size = new(__typeInfos[8]);
    private TdfList<string> _tags = new(__typeInfos[9]);

    public UpdateContentInfoRequest()
    {
        __members = [
            _attributes,
            _contentCategory,
            _contentId,
            _contextId,
            _description,
            _expireDate,
            _name,
            _permission,
            _size,
            _tags,
        ];
    }

    public override Tdf CreateNew() => new UpdateContentInfoRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "UpdateContentInfoRequest";
    public override string GetFullClassName() => "Blaze::Locker::UpdateContentInfoRequest";

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

    public int ContentId
    {
        get => _contentId.Value;
        set => _contentId.Value = value;
    }

    public long ContextId
    {
        get => _contextId.Value;
        set => _contextId.Value = value;
    }

    public string Description
    {
        get => _description.Value;
        set => _description.Value = value;
    }

    public int ExpireDate
    {
        get => _expireDate.Value;
        set => _expireDate.Value = value;
    }

    public string Name
    {
        get => _name.Value;
        set => _name.Value = value;
    }

    public Blaze3SDK.Blaze.Locker.Permission Permission
    {
        get => _permission.Value;
        set => _permission.Value = value;
    }

    public uint Size
    {
        get => _size.Value;
        set => _size.Value = value;
    }

    public IList<string> Tags
    {
        get => _tags.Value;
        set => _tags.Value = value;
    }

}

