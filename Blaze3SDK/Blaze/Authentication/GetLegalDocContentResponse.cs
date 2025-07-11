using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Authentication;

public class GetLegalDocContentResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("LegalDocVersion", "mLegalDocVersion", 0xB24DA300, TdfType.String, 0, true), // LDVC
        new TdfMemberInfo("LegalDocContentLength", "mLegalDocContentLength", 0xD23BEC00, TdfType.UInt32, 1, true), // TCOL
        new TdfMemberInfo("LegalDocContent", "mLegalDocContent", 0xD23BF400, TdfType.String, 2, true), // TCOT
    ];
    private ITdfMember[] __members;

    private TdfString _legalDocVersion = new(__typeInfos[0]);
    private TdfUInt32 _legalDocContentLength = new(__typeInfos[1]);
    private TdfString _legalDocContent = new(__typeInfos[2]);

    public GetLegalDocContentResponse()
    {
        __members = [
            _legalDocVersion,
            _legalDocContentLength,
            _legalDocContent,
        ];
    }

    public override Tdf CreateNew() => new GetLegalDocContentResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetLegalDocContentResponse";
    public override string GetFullClassName() => "Blaze::Authentication::GetLegalDocContentResponse";

    public string LegalDocVersion
    {
        get => _legalDocVersion.Value;
        set => _legalDocVersion.Value = value;
    }

    public uint LegalDocContentLength
    {
        get => _legalDocContentLength.Value;
        set => _legalDocContentLength.Value = value;
    }

    public string LegalDocContent
    {
        get => _legalDocContent.Value;
        set => _legalDocContent.Value = value;
    }

}

