using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Authentication;

public class AcceptCustomLegalDocRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("LegalDocUri", "mLegalDocUri", 0xD35CA900, TdfType.String, 0, true), // TURI
    ];
    private ITdfMember[] __members;

    private TdfString _legalDocUri = new(__typeInfos[0]);

    public AcceptCustomLegalDocRequest()
    {
        __members = [
            _legalDocUri,
        ];
    }

    public override Tdf CreateNew() => new AcceptCustomLegalDocRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "AcceptCustomLegalDocRequest";
    public override string GetFullClassName() => "Blaze::Authentication::AcceptCustomLegalDocRequest";

    public string LegalDocUri
    {
        get => _legalDocUri.Value;
        set => _legalDocUri.Value = value;
    }

}

