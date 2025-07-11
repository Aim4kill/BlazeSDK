using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Authentication;

public class CreateAccountResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("PersonaName", "mPersonaName", 0xC2E86D00, TdfType.String, 0, true), // PNAM
        new TdfMemberInfo("UserId", "mUserId", 0xD6990000, TdfType.Int64, 1, true), // UID
    ];
    private ITdfMember[] __members;

    private TdfString _personaName = new(__typeInfos[0]);
    private TdfInt64 _userId = new(__typeInfos[1]);

    public CreateAccountResponse()
    {
        __members = [
            _personaName,
            _userId,
        ];
    }

    public override Tdf CreateNew() => new CreateAccountResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "CreateAccountResponse";
    public override string GetFullClassName() => "Blaze::Authentication::CreateAccountResponse";

    public string PersonaName
    {
        get => _personaName.Value;
        set => _personaName.Value = value;
    }

    public long UserId
    {
        get => _userId.Value;
        set => _userId.Value = value;
    }

}

