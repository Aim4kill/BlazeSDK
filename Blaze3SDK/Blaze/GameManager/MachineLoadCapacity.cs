using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameManager;

public class MachineLoadCapacity : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("MaxPlayerCapacity", "mMaxPlayerCapacity", 0x8E1C0000, TdfType.UInt32, 0, true), // CAP
        new TdfMemberInfo("PingSiteAlias", "mPingSiteAlias", 0xC3387300, TdfType.String, 1, true), // PSAS
        new TdfMemberInfo("GameProtocolVersionString", "mGameProtocolVersionString", 0xDB3D3200, TdfType.String, 2, true), // VSTR
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _maxPlayerCapacity = new(__typeInfos[0]);
    private TdfString _pingSiteAlias = new(__typeInfos[1]);
    private TdfString _gameProtocolVersionString = new(__typeInfos[2]);

    public MachineLoadCapacity()
    {
        __members = [
            _maxPlayerCapacity,
            _pingSiteAlias,
            _gameProtocolVersionString,
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

    public string GameProtocolVersionString
    {
        get => _gameProtocolVersionString.Value;
        set => _gameProtocolVersionString.Value = value;
    }

}

