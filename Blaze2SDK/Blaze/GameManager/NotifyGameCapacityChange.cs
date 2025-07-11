using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.GameManager;

public class NotifyGameCapacityChange : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("SlotCapacities", "mSlotCapacities", 0x8E1C0000, TdfType.List, 0, true), // CAP
        new TdfMemberInfo("GameId", "mGameId", 0x9E990000, TdfType.UInt32, 1, true), // GID
        new TdfMemberInfo("TeamCapacities", "mTeamCapacities", 0xD2586D00, TdfType.List, 2, true), // TEAM
    ];
    private ITdfMember[] __members;

    private TdfList<ushort> _slotCapacities = new(__typeInfos[0]);
    private TdfUInt32 _gameId = new(__typeInfos[1]);
    private TdfList<Blaze2SDK.Blaze.GameManager.TeamCapacity> _teamCapacities = new(__typeInfos[2]);

    public NotifyGameCapacityChange()
    {
        __members = [
            _slotCapacities,
            _gameId,
            _teamCapacities,
        ];
    }

    public override Tdf CreateNew() => new NotifyGameCapacityChange();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "NotifyGameCapacityChange";
    public override string GetFullClassName() => "Blaze::GameManager::NotifyGameCapacityChange";

    public IList<ushort> SlotCapacities
    {
        get => _slotCapacities.Value;
        set => _slotCapacities.Value = value;
    }

    public uint GameId
    {
        get => _gameId.Value;
        set => _gameId.Value = value;
    }

    public IList<Blaze2SDK.Blaze.GameManager.TeamCapacity> TeamCapacities
    {
        get => _teamCapacities.Value;
        set => _teamCapacities.Value = value;
    }

}

