using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Authentication;

public class GetLegalDocContentRequest : Tdf
{
    public enum ContentType : int
    {
        PLAIN = 0,
        HTML = 1,
    }
    
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("IsoCountryCode", "mIsoCountryCode", 0x8F4CB900, TdfType.String, 0, true), // CTRY
        new TdfMemberInfo("IsoLanguage", "mIsoLanguage", 0xB21BA700, TdfType.String, 1, true), // LANG
        new TdfMemberInfo("Platform", "mPlatform", 0xC349AD00, TdfType.String, 2, true), // PTFM
        new TdfMemberInfo("ContentType", "mContentType", 0xD25E3400, TdfType.Enum, 3, true), // TEXT
    ];
    private ITdfMember[] __members;

    private TdfString _isoCountryCode = new(__typeInfos[0]);
    private TdfString _isoLanguage = new(__typeInfos[1]);
    private TdfString _platform = new(__typeInfos[2]);
    private TdfEnum<Blaze3SDK.Blaze.Authentication.GetLegalDocContentRequest.ContentType> _contentType = new(__typeInfos[3]);

    public GetLegalDocContentRequest()
    {
        __members = [
            _isoCountryCode,
            _isoLanguage,
            _platform,
            _contentType,
        ];
    }

    public override Tdf CreateNew() => new GetLegalDocContentRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetLegalDocContentRequest";
    public override string GetFullClassName() => "Blaze::Authentication::GetLegalDocContentRequest";

    public string IsoCountryCode
    {
        get => _isoCountryCode.Value;
        set => _isoCountryCode.Value = value;
    }

    public string IsoLanguage
    {
        get => _isoLanguage.Value;
        set => _isoLanguage.Value = value;
    }

    public string Platform
    {
        get => _platform.Value;
        set => _platform.Value = value;
    }

    public Blaze3SDK.Blaze.Authentication.GetLegalDocContentRequest.ContentType mContentType
    {
        get => _contentType.Value;
        set => _contentType.Value = value;
    }

}

