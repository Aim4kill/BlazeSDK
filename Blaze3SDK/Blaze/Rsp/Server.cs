using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Rsp;

public class Server : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("BannerId", "mBannerId", 0x8A990000, TdfType.Int32, 0, true), // BID
        new TdfMemberInfo("CreatedDate", "mCreatedDate", 0x8F292100, TdfType.TimeValue, 1, true), // CRDA
        new TdfMemberInfo("ExpirationDate", "mExpirationDate", 0x97892100, TdfType.TimeValue, 2, true), // EXDA
        new TdfMemberInfo("GameProtocolVersionString", "mGameProtocolVersionString", 0x9F0DB300, TdfType.String, 3, true), // GPVS
        new TdfMemberInfo("Name", "mName", 0xBA1B6500, TdfType.String, 4, true), // NAME
        new TdfMemberInfo("OwnerId", "mOwnerId", 0xBE990000, TdfType.Int64, 5, true), // OID
        new TdfMemberInfo("PersistedGameId", "mPersistedGameId", 0xC27A6400, TdfType.String, 6, true), // PGID
        new TdfMemberInfo("PersistedGameIdSecret", "mPersistedGameIdSecret", 0xC27CF200, TdfType.Blob, 7, true), // PGSR
        new TdfMemberInfo("PingSiteAlias", "mPingSiteAlias", 0xC3386C00, TdfType.String, 8, true), // PSAL
        new TdfMemberInfo("ServerId", "mServerId", 0xCE990000, TdfType.UInt32, 9, true), // SID
        new TdfMemberInfo("Status", "mStatus", 0xCF487400, TdfType.Enum, 10, true), // STAT
        new TdfMemberInfo("UpdatedBy", "mUpdatedBy", 0xD708B900, TdfType.Int64, 11, true), // UPBY
        new TdfMemberInfo("UpdatedDate", "mUpdatedDate", 0xD7092100, TdfType.TimeValue, 12, true), // UPDA
    ];
    private ITdfMember[] __members;

    private TdfInt32 _bannerId = new(__typeInfos[0]);
    private TdfTimeValue _createdDate = new(__typeInfos[1]);
    private TdfTimeValue _expirationDate = new(__typeInfos[2]);
    private TdfString _gameProtocolVersionString = new(__typeInfos[3]);
    private TdfString _name = new(__typeInfos[4]);
    private TdfInt64 _ownerId = new(__typeInfos[5]);
    private TdfString _persistedGameId = new(__typeInfos[6]);
    private TdfBlob _persistedGameIdSecret = new(__typeInfos[7]);
    private TdfString _pingSiteAlias = new(__typeInfos[8]);
    private TdfUInt32 _serverId = new(__typeInfos[9]);
    private TdfEnum<Blaze3SDK.Blaze.Rsp.ServerStatus> _status = new(__typeInfos[10]);
    private TdfInt64 _updatedBy = new(__typeInfos[11]);
    private TdfTimeValue _updatedDate = new(__typeInfos[12]);

    public Server()
    {
        __members = [
            _bannerId,
            _createdDate,
            _expirationDate,
            _gameProtocolVersionString,
            _name,
            _ownerId,
            _persistedGameId,
            _persistedGameIdSecret,
            _pingSiteAlias,
            _serverId,
            _status,
            _updatedBy,
            _updatedDate,
        ];
    }

    public override Tdf CreateNew() => new Server();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "Server";
    public override string GetFullClassName() => "Blaze::Rsp::Server";

    public int BannerId
    {
        get => _bannerId.Value;
        set => _bannerId.Value = value;
    }

    public TimeValue CreatedDate
    {
        get => _createdDate.Value;
        set => _createdDate.Value = value;
    }

    public TimeValue ExpirationDate
    {
        get => _expirationDate.Value;
        set => _expirationDate.Value = value;
    }

    public string GameProtocolVersionString
    {
        get => _gameProtocolVersionString.Value;
        set => _gameProtocolVersionString.Value = value;
    }

    public string Name
    {
        get => _name.Value;
        set => _name.Value = value;
    }

    public long OwnerId
    {
        get => _ownerId.Value;
        set => _ownerId.Value = value;
    }

    public string PersistedGameId
    {
        get => _persistedGameId.Value;
        set => _persistedGameId.Value = value;
    }

    public byte[] PersistedGameIdSecret
    {
        get => _persistedGameIdSecret.Value;
        set => _persistedGameIdSecret.Value = value;
    }

    public string PingSiteAlias
    {
        get => _pingSiteAlias.Value;
        set => _pingSiteAlias.Value = value;
    }

    public uint ServerId
    {
        get => _serverId.Value;
        set => _serverId.Value = value;
    }

    public Blaze3SDK.Blaze.Rsp.ServerStatus Status
    {
        get => _status.Value;
        set => _status.Value = value;
    }

    public long UpdatedBy
    {
        get => _updatedBy.Value;
        set => _updatedBy.Value = value;
    }

    public TimeValue UpdatedDate
    {
        get => _updatedDate.Value;
        set => _updatedDate.Value = value;
    }

}

