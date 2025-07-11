using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameManager;

public class SwapPlayerTeamData : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("PlayerId", "mPlayerId", 0xC2990000, TdfType.Int64, 0, true), // PID
        new TdfMemberInfo("TeamIndex", "mTeamIndex", 0xD2993800, TdfType.UInt16, 1, true), // TIDX
    ];
    private ITdfMember[] __members;

    private TdfInt64 _playerId = new(__typeInfos[0]);
    private TdfUInt16 _teamIndex = new(__typeInfos[1]);

    public SwapPlayerTeamData()
    {
        __members = [
            _playerId,
            _teamIndex,
        ];
    }

    public override Tdf CreateNew() => new SwapPlayerTeamData();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "SwapPlayerTeamData";
    public override string GetFullClassName() => "Blaze::GameManager::SwapPlayerTeamData";

    public long PlayerId
    {
        get => _playerId.Value;
        set => _playerId.Value = value;
    }

    public ushort TeamIndex
    {
        get => _teamIndex.Value;
        set => _teamIndex.Value = value;
    }

}

