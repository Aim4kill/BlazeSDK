using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Redirector;

public class ServerListRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Count", "mCount", 0x8EED0000, TdfType.UInt32, 0, true), // CNT
        new TdfMemberInfo("Environment", "mEnvironment", 0x96ED8000, TdfType.String, 1, true), // ENV
        new TdfMemberInfo("Name", "mName", 0xBA1B6500, TdfType.String, 2, true), // NAME
        new TdfMemberInfo("Platform", "mPlatform", 0xC2C87400, TdfType.String, 3, true), // PLAT
        new TdfMemberInfo("ConnectionProfile", "mConnectionProfile", 0xC32BE600, TdfType.String, 4, true), // PROF
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _count = new(__typeInfos[0]);
    private TdfString _environment = new(__typeInfos[1]);
    private TdfString _name = new(__typeInfos[2]);
    private TdfString _platform = new(__typeInfos[3]);
    private TdfString _connectionProfile = new(__typeInfos[4]);

    public ServerListRequest()
    {
        __members = [
            _count,
            _environment,
            _name,
            _platform,
            _connectionProfile,
        ];
    }

    public override Tdf CreateNew() => new ServerListRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ServerListRequest";
    public override string GetFullClassName() => "Blaze::Redirector::ServerListRequest";

    public uint Count
    {
        get => _count.Value;
        set => _count.Value = value;
    }

    public string Environment
    {
        get => _environment.Value;
        set => _environment.Value = value;
    }

    public string Name
    {
        get => _name.Value;
        set => _name.Value = value;
    }

    public string Platform
    {
        get => _platform.Value;
        set => _platform.Value = value;
    }

    public string ConnectionProfile
    {
        get => _connectionProfile.Value;
        set => _connectionProfile.Value = value;
    }

}

