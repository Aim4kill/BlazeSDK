using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameManager;

public class JoinGameResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("GameId", "mGameId", 0x9E990000, TdfType.UInt32, 0, true), // GID
        new TdfMemberInfo("JoinState", "mJoinState", 0xAA7CC000, TdfType.Enum, 1, true), // JGS
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _gameId = new(__typeInfos[0]);
    private TdfEnum<Blaze3SDK.Blaze.GameManager.JoinState> _joinState = new(__typeInfos[1]);

    public JoinGameResponse()
    {
        __members = [
            _gameId,
            _joinState,
        ];
    }

    public override Tdf CreateNew() => new JoinGameResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "JoinGameResponse";
    public override string GetFullClassName() => "Blaze::GameManager::JoinGameResponse";

    public uint GameId
    {
        get => _gameId.Value;
        set => _gameId.Value = value;
    }

    public Blaze3SDK.Blaze.GameManager.JoinState JoinState
    {
        get => _joinState.Value;
        set => _joinState.Value = value;
    }

}

