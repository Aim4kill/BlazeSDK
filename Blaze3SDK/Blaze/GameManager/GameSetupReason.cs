using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameManager;

public class GameSetupReason : Union
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("DatalessSetupContext", "mDatalessSetupContext", 0xDA1B3500, TdfType.Struct, 0, false), // VALU
        new TdfMemberInfo("ResetDedicatedServerSetupContext", "mResetDedicatedServerSetupContext", 0xDA1B3500, TdfType.Struct, 1, false), // VALU
        new TdfMemberInfo("IndirectJoinGameSetupContext", "mIndirectJoinGameSetupContext", 0xDA1B3500, TdfType.Struct, 2, false), // VALU
        new TdfMemberInfo("MatchmakingSetupContext", "mMatchmakingSetupContext", 0xDA1B3500, TdfType.Struct, 3, false), // VALU
        new TdfMemberInfo("IndirectMatchmakingSetupContext", "mIndirectMatchmakingSetupContext", 0xDA1B3500, TdfType.Struct, 4, false), // VALU
    ];

    private TdfStruct<Blaze3SDK.Blaze.GameManager.DatalessSetupContext?> _datalessSetupContext = new(__typeInfos[0]);
    private TdfStruct<Blaze3SDK.Blaze.GameManager.ResetDedicatedServerSetupContext?> _resetDedicatedServerSetupContext = new(__typeInfos[1]);
    private TdfStruct<Blaze3SDK.Blaze.GameManager.IndirectJoinGameSetupContext?> _indirectJoinGameSetupContext = new(__typeInfos[2]);
    private TdfStruct<Blaze3SDK.Blaze.GameManager.MatchmakingSetupContext?> _matchmakingSetupContext = new(__typeInfos[3]);
    private TdfStruct<Blaze3SDK.Blaze.GameManager.IndirectMatchmakingSetupContext?> _indirectMatchmakingSetupContext = new(__typeInfos[4]);

    public override ITdfMember? GetActiveMember()
    {
        return ActiveIndex switch
        {
            0 => _datalessSetupContext,
            1 => _resetDedicatedServerSetupContext,
            2 => _indirectJoinGameSetupContext,
            3 => _matchmakingSetupContext,
            4 => _indirectMatchmakingSetupContext,
            _ => null
        };
    }
    public override Tdf CreateNew() => new GameSetupReason();
    public override string GetClassName() => "GameSetupReason";
    public override string GetFullClassName() => "Blaze::GameManager::GameSetupReason";

    public Blaze3SDK.Blaze.GameManager.DatalessSetupContext? DatalessSetupContext
    {
        get => _datalessSetupContext.Value;
        set
        {
            SwitchActiveIndex(0);
            _datalessSetupContext.Value = value;
        }
    }

    public Blaze3SDK.Blaze.GameManager.ResetDedicatedServerSetupContext? ResetDedicatedServerSetupContext
    {
        get => _resetDedicatedServerSetupContext.Value;
        set
        {
            SwitchActiveIndex(1);
            _resetDedicatedServerSetupContext.Value = value;
        }
    }

    public Blaze3SDK.Blaze.GameManager.IndirectJoinGameSetupContext? IndirectJoinGameSetupContext
    {
        get => _indirectJoinGameSetupContext.Value;
        set
        {
            SwitchActiveIndex(2);
            _indirectJoinGameSetupContext.Value = value;
        }
    }

    public Blaze3SDK.Blaze.GameManager.MatchmakingSetupContext? MatchmakingSetupContext
    {
        get => _matchmakingSetupContext.Value;
        set
        {
            SwitchActiveIndex(3);
            _matchmakingSetupContext.Value = value;
        }
    }

    public Blaze3SDK.Blaze.GameManager.IndirectMatchmakingSetupContext? IndirectMatchmakingSetupContext
    {
        get => _indirectMatchmakingSetupContext.Value;
        set
        {
            SwitchActiveIndex(4);
            _indirectMatchmakingSetupContext.Value = value;
        }
    }

}

