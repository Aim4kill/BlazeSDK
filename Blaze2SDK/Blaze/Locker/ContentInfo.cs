using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Locker;

public class ContentInfo : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Attributes", "mAttributes", 0x874D3200, TdfType.List, 0, true), // ATTR
        new TdfMemberInfo("BlazeObjId", "mBlazeObjId", 0x8AFA6400, TdfType.UInt64, 1, true), // BOID
        new TdfMemberInfo("ContentCategory", "mContentCategory", 0x8E387400, TdfType.String, 2, true), // CCAT
        new TdfMemberInfo("CreateDate", "mCreateDate", 0x8E487400, TdfType.Int32, 3, true), // CDAT
        new TdfMemberInfo("ContentId", "mContentId", 0x8E990000, TdfType.Int32, 4, true), // CID
        new TdfMemberInfo("ContextId", "mContextId", 0x8EFA6400, TdfType.UInt32, 5, true), // COID
        new TdfMemberInfo("Description", "mDescription", 0x925CE300, TdfType.String, 6, true), // DESC
        new TdfMemberInfo("DataFormat", "mDataFormat", 0x926B7400, TdfType.String, 7, true), // DFMT
        new TdfMemberInfo("EntityId", "mEntityId", 0x96990000, TdfType.UInt32, 8, true), // EID
        new TdfMemberInfo("EntityName", "mEntityName", 0x96E86D00, TdfType.String, 9, true), // ENAM
        new TdfMemberInfo("GroupId", "mGroupId", 0x9F0A6400, TdfType.UInt64, 10, true), // GPID
        new TdfMemberInfo("GetURL", "mGetURL", 0x9F5CAC00, TdfType.String, 11, true), // GURL
        new TdfMemberInfo("Name", "mName", 0xBA1B6500, TdfType.String, 12, true), // NAME
        new TdfMemberInfo("Permission", "mPermission", 0xC25CAD00, TdfType.Enum, 13, true), // PERM
        new TdfMemberInfo("Rate", "mRate", 0xCA1D2500, TdfType.Int32, 14, true), // RATE
        new TdfMemberInfo("TotalRatingCount", "mTotalRatingCount", 0xCA3BB400, TdfType.UInt32, 15, true), // RCNT
        new TdfMemberInfo("Size", "mSize", 0xCE9EA500, TdfType.Int32, 16, true), // SIZE
        new TdfMemberInfo("Status", "mStatus", 0xCF4D3300, TdfType.Enum, 17, true), // STTS
        new TdfMemberInfo("SubContentInfos", "mSubContentInfos", 0xCF58AC00, TdfType.Map, 18, true), // SUBL
        new TdfMemberInfo("Tags", "mTags", 0xD219F300, TdfType.List, 19, true), // TAGS
        new TdfMemberInfo("UseCount", "mUseCount", 0xD63BB400, TdfType.Int32, 20, true), // UCNT
        new TdfMemberInfo("UpdateDate", "mUpdateDate", 0xD6487400, TdfType.Int32, 21, true), // UDAT
        new TdfMemberInfo("MyRating", "mMyRating", 0xD7287400, TdfType.UInt32, 22, true), // URAT
        new TdfMemberInfo("UploadURL", "mUploadURL", 0xD75CAC00, TdfType.String, 23, true), // UURL
        new TdfMemberInfo("XrefId", "mXrefId", 0xE2990000, TdfType.String, 24, true), // XID
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze2SDK.Blaze.Locker.Attribute> _attributes = new(__typeInfos[0]);
    private TdfUInt64 _blazeObjId = new(__typeInfos[1]);
    private TdfString _contentCategory = new(__typeInfos[2]);
    private TdfInt32 _createDate = new(__typeInfos[3]);
    private TdfInt32 _contentId = new(__typeInfos[4]);
    private TdfUInt32 _contextId = new(__typeInfos[5]);
    private TdfString _description = new(__typeInfos[6]);
    private TdfString _dataFormat = new(__typeInfos[7]);
    private TdfUInt32 _entityId = new(__typeInfos[8]);
    private TdfString _entityName = new(__typeInfos[9]);
    private TdfUInt64 _groupId = new(__typeInfos[10]);
    private TdfString _getURL = new(__typeInfos[11]);
    private TdfString _name = new(__typeInfos[12]);
    private TdfEnum<Blaze2SDK.Blaze.Locker.Permission> _permission = new(__typeInfos[13]);
    private TdfInt32 _rate = new(__typeInfos[14]);
    private TdfUInt32 _totalRatingCount = new(__typeInfos[15]);
    private TdfInt32 _size = new(__typeInfos[16]);
    private TdfEnum<Blaze2SDK.Blaze.Locker.Status> _status = new(__typeInfos[17]);
    private TdfMap<string, Blaze2SDK.Blaze.Locker.SubContentInfo> _subContentInfos = new(__typeInfos[18]);
    private TdfList<Blaze2SDK.Blaze.Locker.Tag> _tags = new(__typeInfos[19]);
    private TdfInt32 _useCount = new(__typeInfos[20]);
    private TdfInt32 _updateDate = new(__typeInfos[21]);
    private TdfUInt32 _myRating = new(__typeInfos[22]);
    private TdfString _uploadURL = new(__typeInfos[23]);
    private TdfString _xrefId = new(__typeInfos[24]);

    public ContentInfo()
    {
        __members = [
            _attributes,
            _blazeObjId,
            _contentCategory,
            _createDate,
            _contentId,
            _contextId,
            _description,
            _dataFormat,
            _entityId,
            _entityName,
            _groupId,
            _getURL,
            _name,
            _permission,
            _rate,
            _totalRatingCount,
            _size,
            _status,
            _subContentInfos,
            _tags,
            _useCount,
            _updateDate,
            _myRating,
            _uploadURL,
            _xrefId,
        ];
    }

    public override Tdf CreateNew() => new ContentInfo();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ContentInfo";
    public override string GetFullClassName() => "Blaze::Locker::ContentInfo";

    public IList<Blaze2SDK.Blaze.Locker.Attribute> Attributes
    {
        get => _attributes.Value;
        set => _attributes.Value = value;
    }

    public ulong BlazeObjId
    {
        get => _blazeObjId.Value;
        set => _blazeObjId.Value = value;
    }

    public string ContentCategory
    {
        get => _contentCategory.Value;
        set => _contentCategory.Value = value;
    }

    public int CreateDate
    {
        get => _createDate.Value;
        set => _createDate.Value = value;
    }

    public int ContentId
    {
        get => _contentId.Value;
        set => _contentId.Value = value;
    }

    public uint ContextId
    {
        get => _contextId.Value;
        set => _contextId.Value = value;
    }

    public string Description
    {
        get => _description.Value;
        set => _description.Value = value;
    }

    public string DataFormat
    {
        get => _dataFormat.Value;
        set => _dataFormat.Value = value;
    }

    public uint EntityId
    {
        get => _entityId.Value;
        set => _entityId.Value = value;
    }

    public string EntityName
    {
        get => _entityName.Value;
        set => _entityName.Value = value;
    }

    public ulong GroupId
    {
        get => _groupId.Value;
        set => _groupId.Value = value;
    }

    public string GetURL
    {
        get => _getURL.Value;
        set => _getURL.Value = value;
    }

    public string Name
    {
        get => _name.Value;
        set => _name.Value = value;
    }

    public Blaze2SDK.Blaze.Locker.Permission Permission
    {
        get => _permission.Value;
        set => _permission.Value = value;
    }

    public int Rate
    {
        get => _rate.Value;
        set => _rate.Value = value;
    }

    public uint TotalRatingCount
    {
        get => _totalRatingCount.Value;
        set => _totalRatingCount.Value = value;
    }

    public int Size
    {
        get => _size.Value;
        set => _size.Value = value;
    }

    public Blaze2SDK.Blaze.Locker.Status Status
    {
        get => _status.Value;
        set => _status.Value = value;
    }

    public IDictionary<string, Blaze2SDK.Blaze.Locker.SubContentInfo> SubContentInfos
    {
        get => _subContentInfos.Value;
        set => _subContentInfos.Value = value;
    }

    public IList<Blaze2SDK.Blaze.Locker.Tag> Tags
    {
        get => _tags.Value;
        set => _tags.Value = value;
    }

    public int UseCount
    {
        get => _useCount.Value;
        set => _useCount.Value = value;
    }

    public int UpdateDate
    {
        get => _updateDate.Value;
        set => _updateDate.Value = value;
    }

    public uint MyRating
    {
        get => _myRating.Value;
        set => _myRating.Value = value;
    }

    public string UploadURL
    {
        get => _uploadURL.Value;
        set => _uploadURL.Value = value;
    }

    public string XrefId
    {
        get => _xrefId.Value;
        set => _xrefId.Value = value;
    }

}

