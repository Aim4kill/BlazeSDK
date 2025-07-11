using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameManager;

public class HostInfo : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("PlayerId", "mPlayerId", 0xA30A6400, TdfType.Int64, 0, true), // HPID
        new TdfMemberInfo("SlotId", "mSlotId", 0xA33B3400, TdfType.UInt8, 1, true), // HSLT
    ];
    private ITdfMember[] __members;

    private TdfInt64 _playerId = new(__typeInfos[0]);
    private TdfUInt8 _slotId = new(__typeInfos[1]);

    public HostInfo()
    {
        __members = [
            _playerId,
            _slotId,
        ];
    }

    public override Tdf CreateNew() => new HostInfo();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "HostInfo";
    public override string GetFullClassName() => "Blaze::GameManager::HostInfo";

    public long PlayerId
    {
        get => _playerId.Value;
        set => _playerId.Value = value;
    }

    public byte SlotId
    {
        get => _slotId.Value;
        set => _slotId.Value = value;
    }

}

