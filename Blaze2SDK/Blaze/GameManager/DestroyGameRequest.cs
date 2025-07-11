using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.GameManager;

public class DestroyGameRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("GameId", "mGameId", 0x9E990000, TdfType.UInt32, 0, true), // GID
        new TdfMemberInfo("DestructionReason", "mDestructionReason", 0xCA587300, TdfType.Enum, 1, true), // REAS
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _gameId = new(__typeInfos[0]);
    private TdfEnum<Blaze2SDK.Blaze.GameManager.GameDestructionReason> _destructionReason = new(__typeInfos[1]);

    public DestroyGameRequest()
    {
        __members = [
            _gameId,
            _destructionReason,
        ];
    }

    public override Tdf CreateNew() => new DestroyGameRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "DestroyGameRequest";
    public override string GetFullClassName() => "Blaze::GameManager::DestroyGameRequest";

    public uint GameId
    {
        get => _gameId.Value;
        set => _gameId.Value = value;
    }

    public Blaze2SDK.Blaze.GameManager.GameDestructionReason DestructionReason
    {
        get => _destructionReason.Value;
        set => _destructionReason.Value = value;
    }

}

