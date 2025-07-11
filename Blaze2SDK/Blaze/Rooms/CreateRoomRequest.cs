using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Rooms;

public class CreateRoomRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("RoomAttributes", "mRoomAttributes", 0x874D3200, TdfType.Map, 0, true), // ATTR
        new TdfMemberInfo("EntryCriteria", "mEntryCriteria", 0x8F2A7400, TdfType.Map, 1, true), // CRIT
        new TdfMemberInfo("CategoryId", "mCategoryId", 0x8F4A6400, TdfType.UInt32, 2, true), // CTID
        new TdfMemberInfo("Password", "mPassword", 0xC21CF300, TdfType.String, 3, true), // PASS
        new TdfMemberInfo("Name", "mName", 0xCAE86D00, TdfType.String, 4, true), // RNAM
    ];
    private ITdfMember[] __members;

    private TdfMap<string, string> _roomAttributes = new(__typeInfos[0]);
    private TdfMap<string, string> _entryCriteria = new(__typeInfos[1]);
    private TdfUInt32 _categoryId = new(__typeInfos[2]);
    private TdfString _password = new(__typeInfos[3]);
    private TdfString _name = new(__typeInfos[4]);

    public CreateRoomRequest()
    {
        __members = [
            _roomAttributes,
            _entryCriteria,
            _categoryId,
            _password,
            _name,
        ];
    }

    public override Tdf CreateNew() => new CreateRoomRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "CreateRoomRequest";
    public override string GetFullClassName() => "Blaze::Rooms::CreateRoomRequest";

    public IDictionary<string, string> RoomAttributes
    {
        get => _roomAttributes.Value;
        set => _roomAttributes.Value = value;
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

    public string Password
    {
        get => _password.Value;
        set => _password.Value = value;
    }

    public string Name
    {
        get => _name.Value;
        set => _name.Value = value;
    }

}

