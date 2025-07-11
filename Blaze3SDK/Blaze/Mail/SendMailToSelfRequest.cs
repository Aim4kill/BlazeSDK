using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Mail;

public class SendMailToSelfRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("VariableValueMap", "mVariableValueMap", 0xB6E87000, TdfType.Map, 0, true), // MNAP
        new TdfMemberInfo("Purpose", "mPurpose", 0xB74C2C00, TdfType.String, 1, true), // MTPL
    ];
    private ITdfMember[] __members;

    private TdfMap<string, string> _variableValueMap = new(__typeInfos[0]);
    private TdfString _purpose = new(__typeInfos[1]);

    public SendMailToSelfRequest()
    {
        __members = [
            _variableValueMap,
            _purpose,
        ];
    }

    public override Tdf CreateNew() => new SendMailToSelfRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "SendMailToSelfRequest";
    public override string GetFullClassName() => "Blaze::Mail::SendMailToSelfRequest";

    public IDictionary<string, string> VariableValueMap
    {
        get => _variableValueMap.Value;
        set => _variableValueMap.Value = value;
    }

    public string Purpose
    {
        get => _purpose.Value;
        set => _purpose.Value = value;
    }

}

