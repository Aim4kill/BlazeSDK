using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Authentication;

public class PersonaRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("PersonaId", "mPersonaId", 0xC2990000, TdfType.Int64, 0, true), // PID
    ];
    private ITdfMember[] __members;

    private TdfInt64 _personaId = new(__typeInfos[0]);

    public PersonaRequest()
    {
        __members = [
            _personaId,
        ];
    }

    public override Tdf CreateNew() => new PersonaRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "PersonaRequest";
    public override string GetFullClassName() => "Blaze::Authentication::PersonaRequest";

    public long PersonaId
    {
        get => _personaId.Value;
        set => _personaId.Value = value;
    }

}

