using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Authentication;

public class AcceptTosRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("TosUri", "mTosUri", 0xD35CA900, TdfType.String, 0, true), // TURI
    ];
    private ITdfMember[] __members;

    private TdfString _tosUri = new(__typeInfos[0]);

    public AcceptTosRequest()
    {
        __members = [
            _tosUri,
        ];
    }

    public override Tdf CreateNew() => new AcceptTosRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "AcceptTosRequest";
    public override string GetFullClassName() => "Blaze::Authentication::AcceptTosRequest";

    public string TosUri
    {
        get => _tosUri.Value;
        set => _tosUri.Value = value;
    }

}

