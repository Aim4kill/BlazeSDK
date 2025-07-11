using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Registration;

public class RegistrationUpdatenoteResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("IsUpdated", "mIsUpdated", 0xCA5CEC00, TdfType.UInt8, 0, true), // RESL
    ];
    private ITdfMember[] __members;

    private TdfUInt8 _isUpdated = new(__typeInfos[0]);

    public RegistrationUpdatenoteResponse()
    {
        __members = [
            _isUpdated,
        ];
    }

    public override Tdf CreateNew() => new RegistrationUpdatenoteResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "RegistrationUpdatenoteResponse";
    public override string GetFullClassName() => "Blaze::Registration::RegistrationUpdatenoteResponse";

    public byte IsUpdated
    {
        get => _isUpdated.Value;
        set => _isUpdated.Value = value;
    }

}

