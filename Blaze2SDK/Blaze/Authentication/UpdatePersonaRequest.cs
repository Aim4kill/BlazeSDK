using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Authentication;

public class UpdatePersonaRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("DisplayName", "mDisplayName", 0x933BAD00, TdfType.String, 0, true), // DSNM
        new TdfMemberInfo("PersonaId", "mPersonaId", 0xC2990000, TdfType.Int64, 1, true), // PID
    ];
    private ITdfMember[] __members;

    private TdfString _displayName = new(__typeInfos[0]);
    private TdfInt64 _personaId = new(__typeInfos[1]);

    public UpdatePersonaRequest()
    {
        __members = [
            _displayName,
            _personaId,
        ];
    }

    public override Tdf CreateNew() => new UpdatePersonaRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "UpdatePersonaRequest";
    public override string GetFullClassName() => "Blaze::Authentication::UpdatePersonaRequest";

    public string DisplayName
    {
        get => _displayName.Value;
        set => _displayName.Value = value;
    }

    public long PersonaId
    {
        get => _personaId.Value;
        set => _personaId.Value = value;
    }

}

