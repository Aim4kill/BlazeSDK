using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.GameManager;

public class MachineLoadCapacity : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("MaxPlayerCapacity", "mMaxPlayerCapacity", 0x8E1C0000, TdfType.UInt32, 0, true), // CAP
        new TdfMemberInfo("PingSiteAlias", "mPingSiteAlias", 0xC3387300, TdfType.String, 1, true), // PSAS
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _maxPlayerCapacity = new(__typeInfos[0]);
    private TdfString _pingSiteAlias = new(__typeInfos[1]);

    public MachineLoadCapacity()
    {
        __members = [
            _maxPlayerCapacity,
            _pingSiteAlias,
        ];
    }

    public override Tdf CreateNew() => new MachineLoadCapacity();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "MachineLoadCapacity";
    public override string GetFullClassName() => "Blaze::GameManager::MachineLoadCapacity";

    public uint MaxPlayerCapacity
    {
        get => _maxPlayerCapacity.Value;
        set => _maxPlayerCapacity.Value = value;
    }

    public string PingSiteAlias
    {
        get => _pingSiteAlias.Value;
        set => _pingSiteAlias.Value = value;
    }

}

