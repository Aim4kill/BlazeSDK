using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Association;

public class ExternalMemberId : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ExternalId", "mExternalId", 0x96990000, TdfType.String, 0, true), // EID
        new TdfMemberInfo("Persona", "mPersona", 0xC2EB4000, TdfType.String, 1, true), // PNM
    ];
    private ITdfMember[] __members;

    private TdfString _externalId = new(__typeInfos[0]);
    private TdfString _persona = new(__typeInfos[1]);

    public ExternalMemberId()
    {
        __members = [
            _externalId,
            _persona,
        ];
    }

    public override Tdf CreateNew() => new ExternalMemberId();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ExternalMemberId";
    public override string GetFullClassName() => "Blaze::Association::ExternalMemberId";

    public string ExternalId
    {
        get => _externalId.Value;
        set => _externalId.Value = value;
    }

    public string Persona
    {
        get => _persona.Value;
        set => _persona.Value = value;
    }

}

