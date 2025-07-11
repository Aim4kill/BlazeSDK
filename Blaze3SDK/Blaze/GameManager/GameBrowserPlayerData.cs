using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameManager;

public class GameBrowserPlayerData : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ExternalId", "mExternalId", 0x978A6400, TdfType.UInt64, 0, true), // EXID
        new TdfMemberInfo("AccountLocale", "mAccountLocale", 0xB2F8C000, TdfType.UInt32, 1, true), // LOC
        new TdfMemberInfo("PlayerName", "mPlayerName", 0xBA1B6500, TdfType.String, 2, true), // NAME
        new TdfMemberInfo("PlayerAttribs", "mPlayerAttribs", 0xC21D3400, TdfType.Map, 3, true), // PATT
        new TdfMemberInfo("PlayerId", "mPlayerId", 0xC2990000, TdfType.Int64, 4, true), // PID
        new TdfMemberInfo("PlayerState", "mPlayerState", 0xCF487400, TdfType.Enum, 5, true), // STAT
        new TdfMemberInfo("TeamIndex", "mTeamIndex", 0xD2993800, TdfType.UInt16, 6, true), // TIDX
    ];
    private ITdfMember[] __members;

    private TdfUInt64 _externalId = new(__typeInfos[0]);
    private TdfUInt32 _accountLocale = new(__typeInfos[1]);
    private TdfString _playerName = new(__typeInfos[2]);
    private TdfMap<string, string> _playerAttribs = new(__typeInfos[3]);
    private TdfInt64 _playerId = new(__typeInfos[4]);
    private TdfEnum<Blaze3SDK.Blaze.GameManager.PlayerState> _playerState = new(__typeInfos[5]);
    private TdfUInt16 _teamIndex = new(__typeInfos[6]);

    public GameBrowserPlayerData()
    {
        __members = [
            _externalId,
            _accountLocale,
            _playerName,
            _playerAttribs,
            _playerId,
            _playerState,
            _teamIndex,
        ];
    }

    public override Tdf CreateNew() => new GameBrowserPlayerData();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GameBrowserPlayerData";
    public override string GetFullClassName() => "Blaze::GameManager::GameBrowserPlayerData";

    public ulong ExternalId
    {
        get => _externalId.Value;
        set => _externalId.Value = value;
    }

    public uint AccountLocale
    {
        get => _accountLocale.Value;
        set => _accountLocale.Value = value;
    }

    public string PlayerName
    {
        get => _playerName.Value;
        set => _playerName.Value = value;
    }

    public IDictionary<string, string> PlayerAttribs
    {
        get => _playerAttribs.Value;
        set => _playerAttribs.Value = value;
    }

    public long PlayerId
    {
        get => _playerId.Value;
        set => _playerId.Value = value;
    }

    public Blaze3SDK.Blaze.GameManager.PlayerState PlayerState
    {
        get => _playerState.Value;
        set => _playerState.Value = value;
    }

    public ushort TeamIndex
    {
        get => _teamIndex.Value;
        set => _teamIndex.Value = value;
    }

}

