using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Arson;

public class SetComponentStateRequest : Tdf
{
    public enum Action : int
    {
        ENABLE = 0,
        DISABLE = 1,
    }
    
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Action", "mAction", 0x863D2E00, TdfType.Enum, 0, true), // ACTN
        new TdfMemberInfo("ErrorCode", "mErrorCode", 0x972C8000, TdfType.UInt32, 1, true), // ERR
        new TdfMemberInfo("ComponentName", "mComponentName", 0xBA1B6500, TdfType.String, 2, true), // NAME
    ];
    private ITdfMember[] __members;

    private TdfEnum<Blaze2SDK.Blaze.Arson.SetComponentStateRequest.Action> _action = new(__typeInfos[0]);
    private TdfUInt32 _errorCode = new(__typeInfos[1]);
    private TdfString _componentName = new(__typeInfos[2]);

    public SetComponentStateRequest()
    {
        __members = [
            _action,
            _errorCode,
            _componentName,
        ];
    }

    public override Tdf CreateNew() => new SetComponentStateRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "SetComponentStateRequest";
    public override string GetFullClassName() => "Blaze::Arson::SetComponentStateRequest";

    public Blaze2SDK.Blaze.Arson.SetComponentStateRequest.Action mAction
    {
        get => _action.Value;
        set => _action.Value = value;
    }

    public uint ErrorCode
    {
        get => _errorCode.Value;
        set => _errorCode.Value = value;
    }

    public string ComponentName
    {
        get => _componentName.Value;
        set => _componentName.Value = value;
    }

}

