using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Locker;

public class CreateContentInfoRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Attributes", "mAttributes", 0x874D3200, TdfType.List, 0, true), // ATTR
        new TdfMemberInfo("ContentCategory", "mContentCategory", 0x8E387400, TdfType.String, 1, true), // CCAT
        new TdfMemberInfo("ContextId", "mContextId", 0x8EFA6400, TdfType.Int64, 2, true), // COID
        new TdfMemberInfo("Description", "mDescription", 0x925CE300, TdfType.String, 3, true), // DESC
        new TdfMemberInfo("ExpireDate", "mExpireDate", 0x96487400, TdfType.Int32, 4, true), // EDAT
        new TdfMemberInfo("Name", "mName", 0xBA1B6500, TdfType.String, 5, true), // NAME
        new TdfMemberInfo("Permission", "mPermission", 0xC25CAD00, TdfType.Enum, 6, true), // PERM
        new TdfMemberInfo("SubContentNames", "mSubContentNames", 0xCF58AC00, TdfType.List, 7, true), // SUBL
        new TdfMemberInfo("Tags", "mTags", 0xD219F300, TdfType.List, 8, true), // TAGS
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze3SDK.Blaze.Locker.Attribute> _attributes = new(__typeInfos[0]);
    private TdfString _contentCategory = new(__typeInfos[1]);
    private TdfInt64 _contextId = new(__typeInfos[2]);
    private TdfString _description = new(__typeInfos[3]);
    private TdfInt32 _expireDate = new(__typeInfos[4]);
    private TdfString _name = new(__typeInfos[5]);
    private TdfEnum<Blaze3SDK.Blaze.Locker.Permission> _permission = new(__typeInfos[6]);
    private TdfList<string> _subContentNames = new(__typeInfos[7]);
    private TdfList<string> _tags = new(__typeInfos[8]);

    public CreateContentInfoRequest()
    {
        __members = [
            _attributes,
            _contentCategory,
            _contextId,
            _description,
            _expireDate,
            _name,
            _permission,
            _subContentNames,
            _tags,
        ];
    }

    public override Tdf CreateNew() => new CreateContentInfoRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "CreateContentInfoRequest";
    public override string GetFullClassName() => "Blaze::Locker::CreateContentInfoRequest";

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

    public IList<string> SubContentNames
    {
        get => _subContentNames.Value;
        set => _subContentNames.Value = value;
    }

    public IList<string> Tags
    {
        get => _tags.Value;
        set => _tags.Value = value;
    }

}

