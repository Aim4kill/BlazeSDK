using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Authentication;

public class CheckLegalDocRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("LegalDocUri", "mLegalDocUri", 0xD35CA900, TdfType.String, 0, true), // TURI
    ];
    private ITdfMember[] __members;

    private TdfString _legalDocUri = new(__typeInfos[0]);

    public CheckLegalDocRequest()
    {
        __members = [
            _legalDocUri,
        ];
    }

    public override Tdf CreateNew() => new CheckLegalDocRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "CheckLegalDocRequest";
    public override string GetFullClassName() => "Blaze::Authentication::CheckLegalDocRequest";

    public string LegalDocUri
    {
        get => _legalDocUri.Value;
        set => _legalDocUri.Value = value;
    }

}

