using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.GameManager;

public class UnregisterDynamicDedicatedServerCreatorRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("MachineIdList", "mMachineIdList", 0xB6CCF400, TdfType.List, 0, true), // MLST
    ];
    private ITdfMember[] __members;

    private TdfList<string> _machineIdList = new(__typeInfos[0]);

    public UnregisterDynamicDedicatedServerCreatorRequest()
    {
        __members = [
            _machineIdList,
        ];
    }

    public override Tdf CreateNew() => new UnregisterDynamicDedicatedServerCreatorRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "UnregisterDynamicDedicatedServerCreatorRequest";
    public override string GetFullClassName() => "Blaze::GameManager::UnregisterDynamicDedicatedServerCreatorRequest";

    public IList<string> MachineIdList
    {
        get => _machineIdList.Value;
        set => _machineIdList.Value = value;
    }

}

