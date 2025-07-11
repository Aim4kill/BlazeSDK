using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Redirector;

public class ServerListResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Servers", "mServers", 0xB29CF400, TdfType.List, 0, true), // LIST
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze2SDK.Blaze.Redirector.ServerInfoData> _servers = new(__typeInfos[0]);

    public ServerListResponse()
    {
        __members = [
            _servers,
        ];
    }

    public override Tdf CreateNew() => new ServerListResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ServerListResponse";
    public override string GetFullClassName() => "Blaze::Redirector::ServerListResponse";

    public IList<Blaze2SDK.Blaze.Redirector.ServerInfoData> Servers
    {
        get => _servers.Value;
        set => _servers.Value = value;
    }

}

