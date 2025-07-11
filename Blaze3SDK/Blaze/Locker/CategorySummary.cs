using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Locker;

public class CategorySummary : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("AssociatedMaxSizeAllowed", "mAssociatedMaxSizeAllowed", 0x86DCE100, TdfType.UInt32, 0, true), // AMSA
        new TdfMemberInfo("ContextType", "mContextType", 0x8EFD3900, TdfType.String, 1, true), // COTY
        new TdfMemberInfo("DataFormat", "mDataFormat", 0x9219AF00, TdfType.String, 2, true), // DAFO
        new TdfMemberInfo("EntityType", "mEntityType", 0x96ED3900, TdfType.String, 3, true), // ENTY
        new TdfMemberInfo("Id", "mId", 0xA6400000, TdfType.UInt16, 4, true), // ID
        new TdfMemberInfo("MaxSizeAllowed", "mMaxSizeAllowed", 0xB61CE100, TdfType.UInt32, 5, true), // MASA
        new TdfMemberInfo("MaxAllowed", "mMaxAllowed", 0xB61E2100, TdfType.UInt16, 6, true), // MAXA
        new TdfMemberInfo("MaxBookmarksAllowed", "mMaxBookmarksAllowed", 0xB62B6100, TdfType.UInt16, 7, true), // MBMA
        new TdfMemberInfo("Name", "mName", 0xBA1B6500, TdfType.String, 8, true), // NAME
        new TdfMemberInfo("Ratings", "mRatings", 0xCA1D2500, TdfType.Bool, 9, true), // RATE
        new TdfMemberInfo("SecurePut", "mSecurePut", 0xCE58F500, TdfType.Bool, 10, true), // SECU
        new TdfMemberInfo("Tags", "mTags", 0xD219F300, TdfType.Bool, 11, true), // TAGS
        new TdfMemberInfo("Usage", "mUsage", 0xD7386700, TdfType.Bool, 12, true), // USAG
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _associatedMaxSizeAllowed = new(__typeInfos[0]);
    private TdfString _contextType = new(__typeInfos[1]);
    private TdfString _dataFormat = new(__typeInfos[2]);
    private TdfString _entityType = new(__typeInfos[3]);
    private TdfUInt16 _id = new(__typeInfos[4]);
    private TdfUInt32 _maxSizeAllowed = new(__typeInfos[5]);
    private TdfUInt16 _maxAllowed = new(__typeInfos[6]);
    private TdfUInt16 _maxBookmarksAllowed = new(__typeInfos[7]);
    private TdfString _name = new(__typeInfos[8]);
    private TdfBool _ratings = new(__typeInfos[9]);
    private TdfBool _securePut = new(__typeInfos[10]);
    private TdfBool _tags = new(__typeInfos[11]);
    private TdfBool _usage = new(__typeInfos[12]);

    public CategorySummary()
    {
        __members = [
            _associatedMaxSizeAllowed,
            _contextType,
            _dataFormat,
            _entityType,
            _id,
            _maxSizeAllowed,
            _maxAllowed,
            _maxBookmarksAllowed,
            _name,
            _ratings,
            _securePut,
            _tags,
            _usage,
        ];
    }

    public override Tdf CreateNew() => new CategorySummary();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "CategorySummary";
    public override string GetFullClassName() => "Blaze::Locker::CategorySummary";

    public uint AssociatedMaxSizeAllowed
    {
        get => _associatedMaxSizeAllowed.Value;
        set => _associatedMaxSizeAllowed.Value = value;
    }

    public string ContextType
    {
        get => _contextType.Value;
        set => _contextType.Value = value;
    }

    public string DataFormat
    {
        get => _dataFormat.Value;
        set => _dataFormat.Value = value;
    }

    public string EntityType
    {
        get => _entityType.Value;
        set => _entityType.Value = value;
    }

    public ushort Id
    {
        get => _id.Value;
        set => _id.Value = value;
    }

    public uint MaxSizeAllowed
    {
        get => _maxSizeAllowed.Value;
        set => _maxSizeAllowed.Value = value;
    }

    public ushort MaxAllowed
    {
        get => _maxAllowed.Value;
        set => _maxAllowed.Value = value;
    }

    public ushort MaxBookmarksAllowed
    {
        get => _maxBookmarksAllowed.Value;
        set => _maxBookmarksAllowed.Value = value;
    }

    public string Name
    {
        get => _name.Value;
        set => _name.Value = value;
    }

    public bool Ratings
    {
        get => _ratings.Value;
        set => _ratings.Value = value;
    }

    public bool SecurePut
    {
        get => _securePut.Value;
        set => _securePut.Value = value;
    }

    public bool Tags
    {
        get => _tags.Value;
        set => _tags.Value = value;
    }

    public bool Usage
    {
        get => _usage.Value;
        set => _usage.Value = value;
    }

}

