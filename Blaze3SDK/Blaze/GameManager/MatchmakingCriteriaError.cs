using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameManager;

public class MatchmakingCriteriaError : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ErrMessage", "mErrMessage", 0xB739C000, TdfType.String, 0, true), // MSG
    ];
    private ITdfMember[] __members;

    private TdfString _errMessage = new(__typeInfos[0]);

    public MatchmakingCriteriaError()
    {
        __members = [
            _errMessage,
        ];
    }

    public override Tdf CreateNew() => new MatchmakingCriteriaError();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "MatchmakingCriteriaError";
    public override string GetFullClassName() => "Blaze::GameManager::MatchmakingCriteriaError";

    public string ErrMessage
    {
        get => _errMessage.Value;
        set => _errMessage.Value = value;
    }

}

