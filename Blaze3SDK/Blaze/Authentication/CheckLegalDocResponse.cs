using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Authentication;

public class CheckLegalDocResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Accepted", "mAccepted", 0x863C3400, TdfType.Bool, 0, true), // ACPT
    ];
    private ITdfMember[] __members;

    private TdfBool _accepted = new(__typeInfos[0]);

    public CheckLegalDocResponse()
    {
        __members = [
            _accepted,
        ];
    }

    public override Tdf CreateNew() => new CheckLegalDocResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "CheckLegalDocResponse";
    public override string GetFullClassName() => "Blaze::Authentication::CheckLegalDocResponse";

    public bool Accepted
    {
        get => _accepted.Value;
        set => _accepted.Value = value;
    }

}

