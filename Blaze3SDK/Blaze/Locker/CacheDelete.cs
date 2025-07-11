using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Locker;

public class CacheDelete : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Category", "mCategory", 0x8E1D0000, TdfType.String, 0, true), // CAT
        new TdfMemberInfo("ContentId", "mContentId", 0x8E990000, TdfType.Int32, 1, true), // CID
        new TdfMemberInfo("ContextType", "mContextType", 0x8F4E7000, TdfType.ObjectType, 2, true), // CTYP
        new TdfMemberInfo("EntityType", "mEntityType", 0x974E7000, TdfType.ObjectType, 3, true), // ETYP
    ];
    private ITdfMember[] __members;

    private TdfString _category = new(__typeInfos[0]);
    private TdfInt32 _contentId = new(__typeInfos[1]);
    private TdfObjectType _contextType = new(__typeInfos[2]);
    private TdfObjectType _entityType = new(__typeInfos[3]);

    public CacheDelete()
    {
        __members = [
            _category,
            _contentId,
            _contextType,
            _entityType,
        ];
    }

    public override Tdf CreateNew() => new CacheDelete();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "CacheDelete";
    public override string GetFullClassName() => "Blaze::Locker::CacheDelete";

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

}

