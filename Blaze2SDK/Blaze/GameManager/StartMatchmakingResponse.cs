using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.GameManager;

public class StartMatchmakingResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("SessionId", "mSessionId", 0xB73A6400, TdfType.UInt32, 0, true), // MSID
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _sessionId = new(__typeInfos[0]);

    public StartMatchmakingResponse()
    {
        __members = [
            _sessionId,
        ];
    }

    public override Tdf CreateNew() => new StartMatchmakingResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "StartMatchmakingResponse";
    public override string GetFullClassName() => "Blaze::GameManager::StartMatchmakingResponse";

    public uint SessionId
    {
        get => _sessionId.Value;
        set => _sessionId.Value = value;
    }

}

