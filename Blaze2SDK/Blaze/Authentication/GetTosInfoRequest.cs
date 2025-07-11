using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Authentication;

public class GetTosInfoRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("IsoCountryCode", "mIsoCountryCode", 0x8F4CB900, TdfType.String, 0, true), // CTRY
        new TdfMemberInfo("Platform", "mPlatform", 0xC349AD00, TdfType.String, 1, true), // PTFM
    ];
    private ITdfMember[] __members;

    private TdfString _isoCountryCode = new(__typeInfos[0]);
    private TdfString _platform = new(__typeInfos[1]);

    public GetTosInfoRequest()
    {
        __members = [
            _isoCountryCode,
            _platform,
        ];
    }

    public override Tdf CreateNew() => new GetTosInfoRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetTosInfoRequest";
    public override string GetFullClassName() => "Blaze::Authentication::GetTosInfoRequest";

    public string IsoCountryCode
    {
        get => _isoCountryCode.Value;
        set => _isoCountryCode.Value = value;
    }

    public string Platform
    {
        get => _platform.Value;
        set => _platform.Value = value;
    }

}

