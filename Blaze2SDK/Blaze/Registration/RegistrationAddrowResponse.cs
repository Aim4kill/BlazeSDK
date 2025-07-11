using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Registration;

public class RegistrationAddrowResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("AddResult", "mAddResult", 0x86490000, TdfType.UInt8, 0, true), // ADD
    ];
    private ITdfMember[] __members;

    private TdfUInt8 _addResult = new(__typeInfos[0]);

    public RegistrationAddrowResponse()
    {
        __members = [
            _addResult,
        ];
    }

    public override Tdf CreateNew() => new RegistrationAddrowResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "RegistrationAddrowResponse";
    public override string GetFullClassName() => "Blaze::Registration::RegistrationAddrowResponse";

    public byte AddResult
    {
        get => _addResult.Value;
        set => _addResult.Value = value;
    }

}

