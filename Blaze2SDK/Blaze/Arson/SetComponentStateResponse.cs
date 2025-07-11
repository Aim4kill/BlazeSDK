using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Arson;

public class SetComponentStateResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("DisableErrorReturnCode", "mDisableErrorReturnCode", 0x972CA300, TdfType.UInt32, 0, true), // ERRC
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _disableErrorReturnCode = new(__typeInfos[0]);

    public SetComponentStateResponse()
    {
        __members = [
            _disableErrorReturnCode,
        ];
    }

    public override Tdf CreateNew() => new SetComponentStateResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "SetComponentStateResponse";
    public override string GetFullClassName() => "Blaze::Arson::SetComponentStateResponse";

    public uint DisableErrorReturnCode
    {
        get => _disableErrorReturnCode.Value;
        set => _disableErrorReturnCode.Value = value;
    }

}

