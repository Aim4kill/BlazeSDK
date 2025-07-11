using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Rooms;

public class RoomData : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("AutoRemove", "mAutoRemove", 0x87296D00, TdfType.Bool, 0, true), // AREM
        new TdfMemberInfo("Attributes", "mAttributes", 0x874D3200, TdfType.Map, 1, true), // ATTR
        new TdfMemberInfo("CreatorPersonaName", "mCreatorPersonaName", 0x8EE86D00, TdfType.String, 2, true), // CNAM
        new TdfMemberInfo("CreatorUserId", "mCreatorUserId", 0x8F297400, TdfType.UInt32, 3, true), // CRET
        new TdfMemberInfo("EntryCriteria", "mEntryCriteria", 0x8F2A7400, TdfType.Map, 4, true), // CRIT
        new TdfMemberInfo("CreationTime", "mCreationTime", 0x8F2D2D00, TdfType.UInt32, 5, true), // CRTM
        new TdfMemberInfo("CategoryId", "mCategoryId", 0x8F4A6400, TdfType.UInt32, 6, true), // CTID
        new TdfMemberInfo("RoomNumber", "mRoomNumber", 0x96ED6D00, TdfType.UInt32, 7, true), // ENUM
        new TdfMemberInfo("HostPersonaName", "mHostPersonaName", 0xA2E86D00, TdfType.String, 8, true), // HNAM
        new TdfMemberInfo("HostUserId", "mHostUserId", 0xA2FCF400, TdfType.UInt32, 9, true), // HOST
        new TdfMemberInfo("Name", "mName", 0xBA1B6500, TdfType.String, 10, true), // NAME
        new TdfMemberInfo("Population", "mPopulation", 0xC2FC3500, TdfType.UInt32, 11, true), // POPU
        new TdfMemberInfo("Password", "mPassword", 0xC33DE400, TdfType.String, 12, true), // PSWD
        new TdfMemberInfo("PseudoValue", "mPseudoValue", 0xC3686C00, TdfType.String, 13, true), // PVAL
        new TdfMemberInfo("RoomId", "mRoomId", 0xCADA6400, TdfType.UInt32, 14, true), // RMID
        new TdfMemberInfo("IsUserCreated", "mIsUserCreated", 0xD63CB400, TdfType.Bool, 15, true), // UCRT
    ];
    private ITdfMember[] __members;

    private TdfBool _autoRemove = new(__typeInfos[0]);
    private TdfMap<string, string> _attributes = new(__typeInfos[1]);
    private TdfString _creatorPersonaName = new(__typeInfos[2]);
    private TdfUInt32 _creatorUserId = new(__typeInfos[3]);
    private TdfMap<string, string> _entryCriteria = new(__typeInfos[4]);
    private TdfUInt32 _creationTime = new(__typeInfos[5]);
    private TdfUInt32 _categoryId = new(__typeInfos[6]);
    private TdfUInt32 _roomNumber = new(__typeInfos[7]);
    private TdfString _hostPersonaName = new(__typeInfos[8]);
    private TdfUInt32 _hostUserId = new(__typeInfos[9]);
    private TdfString _name = new(__typeInfos[10]);
    private TdfUInt32 _population = new(__typeInfos[11]);
    private TdfString _password = new(__typeInfos[12]);
    private TdfString _pseudoValue = new(__typeInfos[13]);
    private TdfUInt32 _roomId = new(__typeInfos[14]);
    private TdfBool _isUserCreated = new(__typeInfos[15]);

    public RoomData()
    {
        __members = [
            _autoRemove,
            _attributes,
            _creatorPersonaName,
            _creatorUserId,
            _entryCriteria,
            _creationTime,
            _categoryId,
            _roomNumber,
            _hostPersonaName,
            _hostUserId,
            _name,
            _population,
            _password,
            _pseudoValue,
            _roomId,
            _isUserCreated,
        ];
    }

    public override Tdf CreateNew() => new RoomData();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "RoomData";
    public override string GetFullClassName() => "Blaze::Rooms::RoomData";

    public bool AutoRemove
    {
        get => _autoRemove.Value;
        set => _autoRemove.Value = value;
    }

    public IDictionary<string, string> Attributes
    {
        get => _attributes.Value;
        set => _attributes.Value = value;
    }

    public string CreatorPersonaName
    {
        get => _creatorPersonaName.Value;
        set => _creatorPersonaName.Value = value;
    }

    public uint CreatorUserId
    {
        get => _creatorUserId.Value;
        set => _creatorUserId.Value = value;
    }

    public IDictionary<string, string> EntryCriteria
    {
        get => _entryCriteria.Value;
        set => _entryCriteria.Value = value;
    }

    public uint CreationTime
    {
        get => _creationTime.Value;
        set => _creationTime.Value = value;
    }

    public uint CategoryId
    {
        get => _categoryId.Value;
        set => _categoryId.Value = value;
    }

    public uint RoomNumber
    {
        get => _roomNumber.Value;
        set => _roomNumber.Value = value;
    }

    public string HostPersonaName
    {
        get => _hostPersonaName.Value;
        set => _hostPersonaName.Value = value;
    }

    public uint HostUserId
    {
        get => _hostUserId.Value;
        set => _hostUserId.Value = value;
    }

    public string Name
    {
        get => _name.Value;
        set => _name.Value = value;
    }

    public uint Population
    {
        get => _population.Value;
        set => _population.Value = value;
    }

    public string Password
    {
        get => _password.Value;
        set => _password.Value = value;
    }

    public string PseudoValue
    {
        get => _pseudoValue.Value;
        set => _pseudoValue.Value = value;
    }

    public uint RoomId
    {
        get => _roomId.Value;
        set => _roomId.Value = value;
    }

    public bool IsUserCreated
    {
        get => _isUserCreated.Value;
        set => _isUserCreated.Value = value;
    }

}

