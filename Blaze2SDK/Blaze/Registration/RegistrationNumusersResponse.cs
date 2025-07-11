using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Registration;

public class RegistrationNumusersResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("NumUsers", "mNumUsers", 0xBB5B4000, TdfType.Int32, 0, true), // NUM
    ];
    private ITdfMember[] __members;

    private TdfInt32 _numUsers = new(__typeInfos[0]);

    public RegistrationNumusersResponse()
    {
        __members = [
            _numUsers,
        ];
    }

    public override Tdf CreateNew() => new RegistrationNumusersResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "RegistrationNumusersResponse";
    public override string GetFullClassName() => "Blaze::Registration::RegistrationNumusersResponse";

    public int NumUsers
    {
        get => _numUsers.Value;
        set => _numUsers.Value = value;
    }

}

