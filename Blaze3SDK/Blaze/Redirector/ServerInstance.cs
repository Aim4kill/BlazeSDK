using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Redirector;

public class ServerInstance : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ClientTypes", "mClientTypes", 0x8ECD3000, TdfType.List, 0, true), // CLTP
        new TdfMemberInfo("CurrentWorkingDirectory", "mCurrentWorkingDirectory", 0x8F790000, TdfType.String, 1, true), // CWD
        new TdfMemberInfo("Endpoints", "mEndpoints", 0x96E93000, TdfType.List, 2, true), // ENDP
        new TdfMemberInfo("InstanceId", "mInstanceId", 0xA6400000, TdfType.Int32, 3, true), // ID
        new TdfMemberInfo("Load", "mLoad", 0xB2F86400, TdfType.Int32, 4, true), // LOAD
        new TdfMemberInfo("InstanceName", "mInstanceName", 0xBA1B6500, TdfType.String, 5, true), // NAME
        new TdfMemberInfo("InService", "mInService", 0xCF68C000, TdfType.Bool, 6, true), // SVC
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze3SDK.Blaze.ClientType> _clientTypes = new(__typeInfos[0]);
    private TdfString _currentWorkingDirectory = new(__typeInfos[1]);
    private TdfList<Blaze3SDK.Blaze.Redirector.ServerEndpointInfo> _endpoints = new(__typeInfos[2]);
    private TdfInt32 _instanceId = new(__typeInfos[3]);
    private TdfInt32 _load = new(__typeInfos[4]);
    private TdfString _instanceName = new(__typeInfos[5]);
    private TdfBool _inService = new(__typeInfos[6]);

    public ServerInstance()
    {
        __members = [
            _clientTypes,
            _currentWorkingDirectory,
            _endpoints,
            _instanceId,
            _load,
            _instanceName,
            _inService,
        ];
    }

    public override Tdf CreateNew() => new ServerInstance();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ServerInstance";
    public override string GetFullClassName() => "Blaze::Redirector::ServerInstance";

    public IList<Blaze3SDK.Blaze.ClientType> ClientTypes
    {
        get => _clientTypes.Value;
        set => _clientTypes.Value = value;
    }

    public string CurrentWorkingDirectory
    {
        get => _currentWorkingDirectory.Value;
        set => _currentWorkingDirectory.Value = value;
    }

    public IList<Blaze3SDK.Blaze.Redirector.ServerEndpointInfo> Endpoints
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

    public bool InService
    {
        get => _inService.Value;
        set => _inService.Value = value;
    }

}

