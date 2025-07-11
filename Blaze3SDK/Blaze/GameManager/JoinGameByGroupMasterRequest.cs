using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameManager;

public class JoinGameByGroupMasterRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("JoinLeader", "mJoinLeader", 0xAAC96100, TdfType.Bool, 0, true), // JLEA
        new TdfMemberInfo("JoinRequest", "mJoinRequest", 0xAB297100, TdfType.Struct, 1, true), // JREQ
        new TdfMemberInfo("SessionIdList", "mSessionIdList", 0xCE992C00, TdfType.List, 2, true), // SIDL
    ];
    private ITdfMember[] __members;

    private TdfBool _joinLeader = new(__typeInfos[0]);
    private TdfStruct<Blaze3SDK.Blaze.GameManager.JoinGameRequest?> _joinRequest = new(__typeInfos[1]);
    private TdfList<uint> _sessionIdList = new(__typeInfos[2]);

    public JoinGameByGroupMasterRequest()
    {
        __members = [
            _joinLeader,
            _joinRequest,
            _sessionIdList,
        ];
    }

    public override Tdf CreateNew() => new JoinGameByGroupMasterRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "JoinGameByGroupMasterRequest";
    public override string GetFullClassName() => "Blaze::GameManager::JoinGameByGroupMasterRequest";

    public bool JoinLeader
    {
        get => _joinLeader.Value;
        set => _joinLeader.Value = value;
    }

    public Blaze3SDK.Blaze.GameManager.JoinGameRequest? JoinRequest
    {
        get => _joinRequest.Value;
        set => _joinRequest.Value = value;
    }

    public IList<uint> SessionIdList
    {
        get => _sessionIdList.Value;
        set => _sessionIdList.Value = value;
    }

}

