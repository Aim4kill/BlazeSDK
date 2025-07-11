using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Authentication;

public class UpdateAccountResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("PCLoginToken", "mPCLoginToken", 0xC23D2B00, TdfType.String, 0, true), // PCTK
    ];
    private ITdfMember[] __members;

    private TdfString _pCLoginToken = new(__typeInfos[0]);

    public UpdateAccountResponse()
    {
        __members = [
            _pCLoginToken,
        ];
    }

    public override Tdf CreateNew() => new UpdateAccountResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "UpdateAccountResponse";
    public override string GetFullClassName() => "Blaze::Authentication::UpdateAccountResponse";

    public string PCLoginToken
    {
        get => _pCLoginToken.Value;
        set => _pCLoginToken.Value = value;
    }

}

