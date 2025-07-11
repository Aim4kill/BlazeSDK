using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Authentication;

public class StressLoginRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Email", "mEmail", 0xB61A6C00, TdfType.String, 0, true), // MAIL
        new TdfMemberInfo("NucleusId", "mNucleusId", 0xBB5A6400, TdfType.UInt64, 1, true), // NUID
        new TdfMemberInfo("PersonaName", "mPersonaName", 0xC2E86D00, TdfType.String, 2, true), // PNAM
    ];
    private ITdfMember[] __members;

    private TdfString _email = new(__typeInfos[0]);
    private TdfUInt64 _nucleusId = new(__typeInfos[1]);
    private TdfString _personaName = new(__typeInfos[2]);

    public StressLoginRequest()
    {
        __members = [
            _email,
            _nucleusId,
            _personaName,
        ];
    }

    public override Tdf CreateNew() => new StressLoginRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "StressLoginRequest";
    public override string GetFullClassName() => "Blaze::Authentication::StressLoginRequest";

    public string Email
    {
        get => _email.Value;
        set => _email.Value = value;
    }

    public ulong NucleusId
    {
        get => _nucleusId.Value;
        set => _nucleusId.Value = value;
    }

    public string PersonaName
    {
        get => _personaName.Value;
        set => _personaName.Value = value;
    }

}

