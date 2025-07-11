using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze;

public class ResumeSessionRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("SessionKey", "mSessionKey", 0xCEB97900, TdfType.String, 0, true), // SKEY
    ];
    private ITdfMember[] __members;

    private TdfString _sessionKey = new(__typeInfos[0]);

    public ResumeSessionRequest()
    {
        __members = [
            _sessionKey,
        ];
    }

    public override Tdf CreateNew() => new ResumeSessionRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ResumeSessionRequest";
    public override string GetFullClassName() => "Blaze::ResumeSessionRequest";

    public string SessionKey
    {
        get => _sessionKey.Value;
        set => _sessionKey.Value = value;
    }

}

