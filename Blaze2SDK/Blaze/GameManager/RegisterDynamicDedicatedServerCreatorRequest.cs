using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.GameManager;

public class RegisterDynamicDedicatedServerCreatorRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("MachineLoadCapacityMap", "mMachineLoadCapacityMap", 0xB2D87000, TdfType.Map, 0, true), // LMAP
    ];
    private ITdfMember[] __members;

    private TdfMap<string, Blaze2SDK.Blaze.GameManager.MachineLoadCapacity> _machineLoadCapacityMap = new(__typeInfos[0]);

    public RegisterDynamicDedicatedServerCreatorRequest()
    {
        __members = [
            _machineLoadCapacityMap,
        ];
    }

    public override Tdf CreateNew() => new RegisterDynamicDedicatedServerCreatorRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "RegisterDynamicDedicatedServerCreatorRequest";
    public override string GetFullClassName() => "Blaze::GameManager::RegisterDynamicDedicatedServerCreatorRequest";

    public IDictionary<string, Blaze2SDK.Blaze.GameManager.MachineLoadCapacity> MachineLoadCapacityMap
    {
        get => _machineLoadCapacityMap.Value;
        set => _machineLoadCapacityMap.Value = value;
    }

}

