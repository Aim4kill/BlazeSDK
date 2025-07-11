using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze;

public class EntryCriteriaError : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("FailedCriteria", "mFailedCriteria", 0x9A3CB400, TdfType.String, 0, true), // FCRT
    ];
    private ITdfMember[] __members;

    private TdfString _failedCriteria = new(__typeInfos[0]);

    public EntryCriteriaError()
    {
        __members = [
            _failedCriteria,
        ];
    }

    public override Tdf CreateNew() => new EntryCriteriaError();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "EntryCriteriaError";
    public override string GetFullClassName() => "Blaze::EntryCriteriaError";

    public string FailedCriteria
    {
        get => _failedCriteria.Value;
        set => _failedCriteria.Value = value;
    }

}

