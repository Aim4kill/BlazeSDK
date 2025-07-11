using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.GameManager;

public class RegisterDynamicDedicatedServerCreatorResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("RegisteredMachineList", "mRegisteredMachineList", 0xB6CCF400, TdfType.List, 0, true), // MLST
    ];
    private ITdfMember[] __members;

    private TdfList<string> _registeredMachineList = new(__typeInfos[0]);

    public RegisterDynamicDedicatedServerCreatorResponse()
    {
        __members = [
            _registeredMachineList,
        ];
    }

    public override Tdf CreateNew() => new RegisterDynamicDedicatedServerCreatorResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "RegisterDynamicDedicatedServerCreatorResponse";
    public override string GetFullClassName() => "Blaze::GameManager::RegisterDynamicDedicatedServerCreatorResponse";

    public IList<string> RegisteredMachineList
    {
        get => _registeredMachineList.Value;
        set => _registeredMachineList.Value = value;
    }

}

