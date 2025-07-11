using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.GameManager;

public class SetPlayerCapacityRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("GameId", "mGameId", 0x9E990000, TdfType.UInt32, 0, true), // GID
        new TdfMemberInfo("SlotCapacities", "mSlotCapacities", 0xC2387000, TdfType.List, 1, true), // PCAP
        new TdfMemberInfo("TeamCapacities", "mTeamCapacities", 0xD2387000, TdfType.List, 2, true), // TCAP
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _gameId = new(__typeInfos[0]);
    private TdfList<ushort> _slotCapacities = new(__typeInfos[1]);
    private TdfList<Blaze2SDK.Blaze.GameManager.TeamCapacity> _teamCapacities = new(__typeInfos[2]);

    public SetPlayerCapacityRequest()
    {
        __members = [
            _gameId,
            _slotCapacities,
            _teamCapacities,
        ];
    }

    public override Tdf CreateNew() => new SetPlayerCapacityRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "SetPlayerCapacityRequest";
    public override string GetFullClassName() => "Blaze::GameManager::SetPlayerCapacityRequest";

    public uint GameId
    {
        get => _gameId.Value;
        set => _gameId.Value = value;
    }

    public IList<ushort> SlotCapacities
    {
        get => _slotCapacities.Value;
        set => _slotCapacities.Value = value;
    }

    public IList<Blaze2SDK.Blaze.GameManager.TeamCapacity> TeamCapacities
    {
        get => _teamCapacities.Value;
        set => _teamCapacities.Value = value;
    }

}

