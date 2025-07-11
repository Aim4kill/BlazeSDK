using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze;

public class FetchLastLocaleUsedAndAuthErrorResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("LastAuthError", "mLastAuthError", 0xB21A2500, TdfType.String, 0, true), // LAHE
        new TdfMemberInfo("LastLocaleUsed", "mLastLocaleUsed", 0xB2CD6400, TdfType.String, 1, true), // LLUD
    ];
    private ITdfMember[] __members;

    private TdfString _lastAuthError = new(__typeInfos[0]);
    private TdfString _lastLocaleUsed = new(__typeInfos[1]);

    public FetchLastLocaleUsedAndAuthErrorResponse()
    {
        __members = [
            _lastAuthError,
            _lastLocaleUsed,
        ];
    }

    public override Tdf CreateNew() => new FetchLastLocaleUsedAndAuthErrorResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "FetchLastLocaleUsedAndAuthErrorResponse";
    public override string GetFullClassName() => "Blaze::FetchLastLocaleUsedAndAuthErrorResponse";

    public string LastAuthError
    {
        get => _lastAuthError.Value;
        set => _lastAuthError.Value = value;
    }

    public string LastLocaleUsed
    {
        get => _lastLocaleUsed.Value;
        set => _lastLocaleUsed.Value = value;
    }

}

