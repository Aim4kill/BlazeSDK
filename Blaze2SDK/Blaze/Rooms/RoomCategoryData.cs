using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Rooms;

public class RoomCategoryData : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Capacity", "mCapacity", 0x8E1C2100, TdfType.UInt32, 0, true), // CAPA
        new TdfMemberInfo("ClientMetaData", "mClientMetaData", 0x8ED97400, TdfType.Map, 1, true), // CMET
        new TdfMemberInfo("EntryCriteria", "mEntryCriteria", 0x8F2A7400, TdfType.Map, 2, true), // CRIT
        new TdfMemberInfo("CategoryId", "mCategoryId", 0x8F4A6400, TdfType.UInt32, 3, true), // CTID
        new TdfMemberInfo("Description", "mDescription", 0x925CE300, TdfType.String, 4, true), // DESC
        new TdfMemberInfo("DisplayName", "mDisplayName", 0x929CF000, TdfType.String, 5, true), // DISP
        new TdfMemberInfo("RoomDisplayName", "mRoomDisplayName", 0x929CF200, TdfType.String, 6, true), // DISR
        new TdfMemberInfo("MaxExpandedRooms", "mMaxExpandedRooms", 0x96D87800, TdfType.UInt32, 7, true), // EMAX
        new TdfMemberInfo("ExpandThresholdPercent", "mExpandThresholdPercent", 0x9708F400, TdfType.UInt16, 8, true), // EPCT
        new TdfMemberInfo("Flags", "mFlags", 0x9AC86700, TdfType.Enum, 9, true), // FLAG
        new TdfMemberInfo("GameMetaData", "mGameMetaData", 0x9ED97400, TdfType.Map, 10, true), // GMET
        new TdfMemberInfo("Locale", "mLocale", 0xB2F8EC00, TdfType.String, 11, true), // LOCL
        new TdfMemberInfo("Name", "mName", 0xBA1B6500, TdfType.String, 12, true), // NAME
        new TdfMemberInfo("NumExpandedRooms", "mNumExpandedRooms", 0xBA5E3000, TdfType.UInt16, 13, true), // NEXP
        new TdfMemberInfo("Password", "mPassword", 0xC21CF300, TdfType.String, 14, true), // PASS
        new TdfMemberInfo("IsUserCreated", "mIsUserCreated", 0xD63CB400, TdfType.Bool, 15, true), // UCRT
        new TdfMemberInfo("ViewId", "mViewId", 0xDB7A6400, TdfType.UInt32, 16, true), // VWID
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _capacity = new(__typeInfos[0]);
    private TdfMap<string, string> _clientMetaData = new(__typeInfos[1]);
    private TdfMap<string, string> _entryCriteria = new(__typeInfos[2]);
    private TdfUInt32 _categoryId = new(__typeInfos[3]);
    private TdfString _description = new(__typeInfos[4]);
    private TdfString _displayName = new(__typeInfos[5]);
    private TdfString _roomDisplayName = new(__typeInfos[6]);
    private TdfUInt32 _maxExpandedRooms = new(__typeInfos[7]);
    private TdfUInt16 _expandThresholdPercent = new(__typeInfos[8]);
    private TdfEnum<Blaze2SDK.Blaze.Rooms.RoomCategoryFlags> _flags = new(__typeInfos[9]);
    private TdfMap<string, string> _gameMetaData = new(__typeInfos[10]);
    private TdfString _locale = new(__typeInfos[11]);
    private TdfString _name = new(__typeInfos[12]);
    private TdfUInt16 _numExpandedRooms = new(__typeInfos[13]);
    private TdfString _password = new(__typeInfos[14]);
    private TdfBool _isUserCreated = new(__typeInfos[15]);
    private TdfUInt32 _viewId = new(__typeInfos[16]);

    public RoomCategoryData()
    {
        __members = [
            _capacity,
            _clientMetaData,
            _entryCriteria,
            _categoryId,
            _description,
            _displayName,
            _roomDisplayName,
            _maxExpandedRooms,
            _expandThresholdPercent,
            _flags,
            _gameMetaData,
            _locale,
            _name,
            _numExpandedRooms,
            _password,
            _isUserCreated,
            _viewId,
        ];
    }

    public override Tdf CreateNew() => new RoomCategoryData();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "RoomCategoryData";
    public override string GetFullClassName() => "Blaze::Rooms::RoomCategoryData";

    public uint Capacity
    {
        get => _capacity.Value;
        set => _capacity.Value = value;
    }

    public IDictionary<string, string> ClientMetaData
    {
        get => _clientMetaData.Value;
        set => _clientMetaData.Value = value;
    }

    public IDictionary<string, string> EntryCriteria
    {
        get => _entryCriteria.Value;
        set => _entryCriteria.Value = value;
    }

    public uint CategoryId
    {
        get => _categoryId.Value;
        set => _categoryId.Value = value;
    }

    public string Description
    {
        get => _description.Value;
        set => _description.Value = value;
    }

    public string DisplayName
    {
        get => _displayName.Value;
        set => _displayName.Value = value;
    }

    public string RoomDisplayName
    {
        get => _roomDisplayName.Value;
        set => _roomDisplayName.Value = value;
    }

    public uint MaxExpandedRooms
    {
        get => _maxExpandedRooms.Value;
        set => _maxExpandedRooms.Value = value;
    }

    public ushort ExpandThresholdPercent
    {
        get => _expandThresholdPercent.Value;
        set => _expandThresholdPercent.Value = value;
    }

    public Blaze2SDK.Blaze.Rooms.RoomCategoryFlags Flags
    {
        get => _flags.Value;
        set => _flags.Value = value;
    }

    public IDictionary<string, string> GameMetaData
    {
        get => _gameMetaData.Value;
        set => _gameMetaData.Value = value;
    }

    public string Locale
    {
        get => _locale.Value;
        set => _locale.Value = value;
    }

    public string Name
    {
        get => _name.Value;
        set => _name.Value = value;
    }

    public ushort NumExpandedRooms
    {
        get => _numExpandedRooms.Value;
        set => _numExpandedRooms.Value = value;
    }

    public string Password
    {
        get => _password.Value;
        set => _password.Value = value;
    }

    public bool IsUserCreated
    {
        get => _isUserCreated.Value;
        set => _isUserCreated.Value = value;
    }

    public uint ViewId
    {
        get => _viewId.Value;
        set => _viewId.Value = value;
    }

}

