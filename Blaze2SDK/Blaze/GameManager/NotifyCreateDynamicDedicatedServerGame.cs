using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.GameManager;

public class NotifyCreateDynamicDedicatedServerGame : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("CreateGameRequest", "mCreateGameRequest", 0x9F297100, TdfType.Struct, 0, true), // GREQ
        new TdfMemberInfo("MachineId", "mMachineId", 0xB6990000, TdfType.String, 1, true), // MID
    ];
    private ITdfMember[] __members;

    private TdfStruct<Blaze2SDK.Blaze.GameManager.CreateGameRequest?> _createGameRequest = new(__typeInfos[0]);
    private TdfString _machineId = new(__typeInfos[1]);

    public NotifyCreateDynamicDedicatedServerGame()
    {
        __members = [
            _createGameRequest,
            _machineId,
        ];
    }

    public override Tdf CreateNew() => new NotifyCreateDynamicDedicatedServerGame();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "NotifyCreateDynamicDedicatedServerGame";
    public override string GetFullClassName() => "Blaze::GameManager::NotifyCreateDynamicDedicatedServerGame";

    public Blaze2SDK.Blaze.GameManager.CreateGameRequest? CreateGameRequest
    {
        get => _createGameRequest.Value;
        set => _createGameRequest.Value = value;
    }

    public string MachineId
    {
        get => _machineId.Value;
        set => _machineId.Value = value;
    }

}

