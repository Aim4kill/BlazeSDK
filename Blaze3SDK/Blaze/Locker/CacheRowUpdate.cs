using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Locker;

public class CacheRowUpdate : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Category", "mCategory", 0x8E1D0000, TdfType.String, 0, true), // CAT
        new TdfMemberInfo("ContentId", "mContentId", 0x8E990000, TdfType.Int32, 1, true), // CID
        new TdfMemberInfo("ContextType", "mContextType", 0x8F4E7000, TdfType.ObjectType, 2, true), // CTYP
        new TdfMemberInfo("EntityType", "mEntityType", 0x974E7000, TdfType.ObjectType, 3, true), // ETYP
        new TdfMemberInfo("Hide", "mHide", 0xA2992500, TdfType.Bool, 4, true), // HIDE
        new TdfMemberInfo("Tags", "mTags", 0xD219F300, TdfType.List, 5, true), // TAGS
        new TdfMemberInfo("Attributes", "mAttributes", 0xD7093400, TdfType.List, 6, true), // UPDT
    ];
    private ITdfMember[] __members;

    private TdfString _category = new(__typeInfos[0]);
    private TdfInt32 _contentId = new(__typeInfos[1]);
    private TdfObjectType _contextType = new(__typeInfos[2]);
    private TdfObjectType _entityType = new(__typeInfos[3]);
    private TdfBool _hide = new(__typeInfos[4]);
    private TdfList<string> _tags = new(__typeInfos[5]);
    private TdfList<Blaze3SDK.Blaze.Locker.Attribute> _attributes = new(__typeInfos[6]);

    public CacheRowUpdate()
    {
        __members = [
            _category,
            _contentId,
            _contextType,
            _entityType,
            _hide,
            _tags,
            _attributes,
        ];
    }

    public override Tdf CreateNew() => new CacheRowUpdate();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "CacheRowUpdate";
    public override string GetFullClassName() => "Blaze::Locker::CacheRowUpdate";

    public string Category
    {
        get => _category.Value;
        set => _category.Value = value;
    }

    public int ContentId
    {
        get => _contentId.Value;
        set => _contentId.Value = value;
    }

    public ObjectType ContextType
    {
        get => _contextType.Value;
        set => _contextType.Value = value;
    }

    public ObjectType EntityType
    {
        get => _entityType.Value;
        set => _entityType.Value = value;
    }

    public bool Hide
    {
        get => _hide.Value;
        set => _hide.Value = value;
    }

    public IList<string> Tags
    {
        get => _tags.Value;
        set => _tags.Value = value;
    }

    public IList<Blaze3SDK.Blaze.Locker.Attribute> Attributes
    {
        get => _attributes.Value;
        set => _attributes.Value = value;
    }

}

