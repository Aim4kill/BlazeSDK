using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Rsp;

public class ServerSettings : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("BannerId", "mBannerId", 0x8A990000, TdfType.Int32, 0, true), // BID
        new TdfMemberInfo("Description", "mDescription", 0x925CE300, TdfType.String, 1, true), // DESC
        new TdfMemberInfo("Message", "mMessage", 0xB65CF300, TdfType.String, 2, true), // MESS
        new TdfMemberInfo("MapRotationId", "mMapRotationId", 0xB6990000, TdfType.UInt8, 3, true), // MID
        new TdfMemberInfo("Name", "mName", 0xBA1B6500, TdfType.String, 4, true), // NAME
        new TdfMemberInfo("Password", "mPassword", 0xC21CF300, TdfType.String, 5, true), // PASS
        new TdfMemberInfo("PresetId", "mPresetId", 0xC2990000, TdfType.UInt8, 6, true), // PID
        new TdfMemberInfo("PasswordSalt", "mPasswordSalt", 0xCE1B3400, TdfType.Int32, 7, true), // SALT
        new TdfMemberInfo("ServerType", "mServerType", 0xD39C2500, TdfType.Enum, 8, true), // TYPE
    ];
    private ITdfMember[] __members;

    private TdfInt32 _bannerId = new(__typeInfos[0]);
    private TdfString _description = new(__typeInfos[1]);
    private TdfString _message = new(__typeInfos[2]);
    private TdfUInt8 _mapRotationId = new(__typeInfos[3]);
    private TdfString _name = new(__typeInfos[4]);
    private TdfString _password = new(__typeInfos[5]);
    private TdfUInt8 _presetId = new(__typeInfos[6]);
    private TdfInt32 _passwordSalt = new(__typeInfos[7]);
    private TdfEnum<Blaze3SDK.Blaze.Rsp.ServerType> _serverType = new(__typeInfos[8]);

    public ServerSettings()
    {
        __members = [
            _bannerId,
            _description,
            _message,
            _mapRotationId,
            _name,
            _password,
            _presetId,
            _passwordSalt,
            _serverType,
        ];
    }

    public override Tdf CreateNew() => new ServerSettings();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ServerSettings";
    public override string GetFullClassName() => "Blaze::Rsp::ServerSettings";

    public int BannerId
    {
        get => _bannerId.Value;
        set => _bannerId.Value = value;
    }

    public string Description
    {
        get => _description.Value;
        set => _description.Value = value;
    }

    public string Message
    {
        get => _message.Value;
        set => _message.Value = value;
    }

    public byte MapRotationId
    {
        get => _mapRotationId.Value;
        set => _mapRotationId.Value = value;
    }

    public string Name
    {
        get => _name.Value;
        set => _name.Value = value;
    }

    public string Password
    {
        get => _password.Value;
        set => _password.Value = value;
    }

    public byte PresetId
    {
        get => _presetId.Value;
        set => _presetId.Value = value;
    }

    public int PasswordSalt
    {
        get => _passwordSalt.Value;
        set => _passwordSalt.Value = value;
    }

    public Blaze3SDK.Blaze.Rsp.ServerType ServerType
    {
        get => _serverType.Value;
        set => _serverType.Value = value;
    }

}

