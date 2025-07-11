using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze;

public class UpdateUserSessionClientDataRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ClientData", "mClientData", 0x8F687200, TdfType.Variable, 0, true), // CVAR
    ];
    private ITdfMember[] __members;

    private TdfVariable _clientData = new(__typeInfos[0]);

    public UpdateUserSessionClientDataRequest()
    {
        __members = [
            _clientData,
        ];
    }

    public override Tdf CreateNew() => new UpdateUserSessionClientDataRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "UpdateUserSessionClientDataRequest";
    public override string GetFullClassName() => "Blaze::UpdateUserSessionClientDataRequest";

    public object? ClientData
    {
        get => _clientData.Value;
        set => _clientData.Value = value;
    }

}

