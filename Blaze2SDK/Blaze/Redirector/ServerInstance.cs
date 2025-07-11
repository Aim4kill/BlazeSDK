using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Redirector;

public class ServerInstance : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("CurrentWorkingDirectory", "mCurrentWorkingDirectory", 0x8F790000, TdfType.String, 0, true), // CWD
        new TdfMemberInfo("Endpoints", "mEndpoints", 0x96E93000, TdfType.List, 1, true), // ENDP
        new TdfMemberInfo("InstanceId", "mInstanceId", 0xA6400000, TdfType.Int32, 2, true), // ID
        new TdfMemberInfo("Load", "mLoad", 0xB2F86400, TdfType.Int32, 3, true), // LOAD
        new TdfMemberInfo("InstanceName", "mInstanceName", 0xBA1B6500, TdfType.String, 4, true), // NAME
    ];
    private ITdfMember[] __members;

    private TdfString _currentWorkingDirectory = new(__typeInfos[0]);
    private TdfList<Blaze2SDK.Blaze.Redirector.ServerEndpointInfo> _endpoints = new(__typeInfos[1]);
    private TdfInt32 _instanceId = new(__typeInfos[2]);
    private TdfInt32 _load = new(__typeInfos[3]);
    private TdfString _instanceName = new(__typeInfos[4]);

    public ServerInstance()
    {
        __members = [
            _currentWorkingDirectory,
            _endpoints,
            _instanceId,
            _load,
            _instanceName,
        ];
    }

    public override Tdf CreateNew() => new ServerInstance();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ServerInstance";
    public override string GetFullClassName() => "Blaze::Redirector::ServerInstance";

    public string CurrentWorkingDirectory
    {
        get => _currentWorkingDirectory.Value;
        set => _currentWorkingDirectory.Value = value;
    }

    public IList<Blaze2SDK.Blaze.Redirector.ServerEndpointInfo> Endpoints
    {
        get => _endpoints.Value;
        set => _endpoints.Value = value;
    }

    public int InstanceId
    {
        get => _instanceId.Value;
        set => _instanceId.Value = value;
    }

    public int Load
    {
        get => _load.Value;
        set => _load.Value = value;
    }

    public string InstanceName
    {
        get => _instanceName.Value;
        set => _instanceName.Value = value;
    }

}

