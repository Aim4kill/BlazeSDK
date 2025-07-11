using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Rooms;

public class RoomViewData : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("DisplayName", "mDisplayName", 0x929CF000, TdfType.String, 0, true), // DISP
        new TdfMemberInfo("GameMetaData", "mGameMetaData", 0x9ED97400, TdfType.Map, 1, true), // GMET
        new TdfMemberInfo("ClientMetaData", "mClientMetaData", 0xB65D2100, TdfType.Map, 2, true), // META
        new TdfMemberInfo("MaxUserRooms", "mMaxUserRooms", 0xB78CAD00, TdfType.UInt32, 3, true), // MXRM
        new TdfMemberInfo("Name", "mName", 0xBA1B6500, TdfType.String, 4, true), // NAME
        new TdfMemberInfo("NumUserRooms", "mNumUserRooms", 0xD73CAD00, TdfType.UInt32, 5, true), // USRM
        new TdfMemberInfo("ViewId", "mViewId", 0xDB7A6400, TdfType.UInt32, 6, true), // VWID
    ];
    private ITdfMember[] __members;

    private TdfString _displayName = new(__typeInfos[0]);
    private TdfMap<string, string> _gameMetaData = new(__typeInfos[1]);
    private TdfMap<string, string> _clientMetaData = new(__typeInfos[2]);
    private TdfUInt32 _maxUserRooms = new(__typeInfos[3]);
    private TdfString _name = new(__typeInfos[4]);
    private TdfUInt32 _numUserRooms = new(__typeInfos[5]);
    private TdfUInt32 _viewId = new(__typeInfos[6]);

    public RoomViewData()
    {
        __members = [
            _displayName,
            _gameMetaData,
            _clientMetaData,
            _maxUserRooms,
            _name,
            _numUserRooms,
            _viewId,
        ];
    }

    public override Tdf CreateNew() => new RoomViewData();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "RoomViewData";
    public override string GetFullClassName() => "Blaze::Rooms::RoomViewData";

    public string DisplayName
    {
        get => _displayName.Value;
        set => _displayName.Value = value;
    }

    public IDictionary<string, string> GameMetaData
    {
        get => _gameMetaData.Value;
        set => _gameMetaData.Value = value;
    }

    public IDictionary<string, string> ClientMetaData
    {
        get => _clientMetaData.Value;
        set => _clientMetaData.Value = value;
    }

    public uint MaxUserRooms
    {
        get => _maxUserRooms.Value;
        set => _maxUserRooms.Value = value;
    }

    public string Name
    {
        get => _name.Value;
        set => _name.Value = value;
    }

    public uint NumUserRooms
    {
        get => _numUserRooms.Value;
        set => _numUserRooms.Value = value;
    }

    public uint ViewId
    {
        get => _viewId.Value;
        set => _viewId.Value = value;
    }

}

