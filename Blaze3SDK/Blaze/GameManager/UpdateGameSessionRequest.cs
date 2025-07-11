using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameManager;

public class UpdateGameSessionRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("GameId", "mGameId", 0x9E990000, TdfType.UInt32, 0, true), // GID
        new TdfMemberInfo("XnetNonce", "mXnetNonce", 0xE2EBA300, TdfType.Blob, 1, true), // XNNC
        new TdfMemberInfo("XnetSession", "mXnetSession", 0xE3397300, TdfType.Blob, 2, true), // XSES
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _gameId = new(__typeInfos[0]);
    private TdfBlob _xnetNonce = new(__typeInfos[1]);
    private TdfBlob _xnetSession = new(__typeInfos[2]);

    public UpdateGameSessionRequest()
    {
        __members = [
            _gameId,
            _xnetNonce,
            _xnetSession,
        ];
    }

    public override Tdf CreateNew() => new UpdateGameSessionRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "UpdateGameSessionRequest";
    public override string GetFullClassName() => "Blaze::GameManager::UpdateGameSessionRequest";

    public uint GameId
    {
        get => _gameId.Value;
        set => _gameId.Value = value;
    }

    public byte[] XnetNonce
    {
        get => _xnetNonce.Value;
        set => _xnetNonce.Value = value;
    }

    public byte[] XnetSession
    {
        get => _xnetSession.Value;
        set => _xnetSession.Value = value;
    }

}

