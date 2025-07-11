using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Rooms;

public class CheckEntryCriteriaResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("FailedCriteria", "mFailedCriteria", 0x9A3CA900, TdfType.String, 0, true), // FCRI
        new TdfMemberInfo("Passed", "mPassed", 0xC21CF300, TdfType.Bool, 1, true), // PASS
    ];
    private ITdfMember[] __members;

    private TdfString _failedCriteria = new(__typeInfos[0]);
    private TdfBool _passed = new(__typeInfos[1]);

    public CheckEntryCriteriaResponse()
    {
        __members = [
            _failedCriteria,
            _passed,
        ];
    }

    public override Tdf CreateNew() => new CheckEntryCriteriaResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "CheckEntryCriteriaResponse";
    public override string GetFullClassName() => "Blaze::Rooms::CheckEntryCriteriaResponse";

    public string FailedCriteria
    {
        get => _failedCriteria.Value;
        set => _failedCriteria.Value = value;
    }

    public bool Passed
    {
        get => _passed.Value;
        set => _passed.Value = value;
    }

}

