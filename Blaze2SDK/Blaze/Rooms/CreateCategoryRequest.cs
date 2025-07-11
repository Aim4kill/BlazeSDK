using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Rooms;

public class CreateCategoryRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("RoomAttributes", "mRoomAttributes", 0x874D3200, TdfType.Map, 0, true), // ATTR
        new TdfMemberInfo("Capacity", "mCapacity", 0x8E1C2100, TdfType.UInt32, 1, true), // CAPA
        new TdfMemberInfo("ClientMetaData", "mClientMetaData", 0x8ED97400, TdfType.Map, 2, true), // CMET
        new TdfMemberInfo("CatName", "mCatName", 0x8EE86D00, TdfType.String, 3, true), // CNAM
        new TdfMemberInfo("EntryCriteria", "mEntryCriteria", 0x8F2A7400, TdfType.Map, 4, true), // CRIT
        new TdfMemberInfo("Description", "mDescription", 0x925CE300, TdfType.String, 5, true), // DESC
        new TdfMemberInfo("GameMetaData", "mGameMetaData", 0x9ED97400, TdfType.Map, 6, true), // GMET
        new TdfMemberInfo("JoinIfExists", "mJoinIfExists", 0xAAFA6E00, TdfType.Bool, 7, true), // JOIN
        new TdfMemberInfo("Password", "mPassword", 0xC21CF300, TdfType.String, 8, true), // PASS
        new TdfMemberInfo("ViewName", "mViewName", 0xDAE86D00, TdfType.String, 9, true), // VNAM
        new TdfMemberInfo("ViewId", "mViewId", 0xDB7A6400, TdfType.UInt32, 10, true), // VWID
    ];
    private ITdfMember[] __members;

    private TdfMap<string, string> _roomAttributes = new(__typeInfos[0]);
    private TdfUInt32 _capacity = new(__typeInfos[1]);
    private TdfMap<string, string> _clientMetaData = new(__typeInfos[2]);
    private TdfString _catName = new(__typeInfos[3]);
    private TdfMap<string, string> _entryCriteria = new(__typeInfos[4]);
    private TdfString _description = new(__typeInfos[5]);
    private TdfMap<string, string> _gameMetaData = new(__typeInfos[6]);
    private TdfBool _joinIfExists = new(__typeInfos[7]);
    private TdfString _password = new(__typeInfos[8]);
    private TdfString _viewName = new(__typeInfos[9]);
    private TdfUInt32 _viewId = new(__typeInfos[10]);

    public CreateCategoryRequest()
    {
        __members = [
            _roomAttributes,
            _capacity,
            _clientMetaData,
            _catName,
            _entryCriteria,
            _description,
            _gameMetaData,
            _joinIfExists,
            _password,
            _viewName,
            _viewId,
        ];
    }

    public override Tdf CreateNew() => new CreateCategoryRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "CreateCategoryRequest";
    public override string GetFullClassName() => "Blaze::Rooms::CreateCategoryRequest";

    public IDictionary<string, string> RoomAttributes
    {
        get => _roomAttributes.Value;
        set => _roomAttributes.Value = value;
    }

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

    public string CatName
    {
        get => _catName.Value;
        set => _catName.Value = value;
    }

    public IDictionary<string, string> EntryCriteria
    {
        get => _entryCriteria.Value;
        set => _entryCriteria.Value = value;
    }

    public string Description
    {
        get => _description.Value;
        set => _description.Value = value;
    }

    public IDictionary<string, string> GameMetaData
    {
        get => _gameMetaData.Value;
        set => _gameMetaData.Value = value;
    }

    public bool JoinIfExists
    {
        get => _joinIfExists.Value;
        set => _joinIfExists.Value = value;
    }

    public string Password
    {
        get => _password.Value;
        set => _password.Value = value;
    }

    public string ViewName
    {
        get => _viewName.Value;
        set => _viewName.Value = value;
    }

    public uint ViewId
    {
        get => _viewId.Value;
        set => _viewId.Value = value;
    }

}

