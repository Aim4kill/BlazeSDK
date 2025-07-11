using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Registration;

public class RegistrationReturnusersResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("NumUsers", "mNumUsers", 0xBB5B4000, TdfType.Int32, 0, true), // NUM
        new TdfMemberInfo("RegisteredUsers", "mRegisteredUsers", 0xCAFDF300, TdfType.List, 1, true), // ROWS
    ];
    private ITdfMember[] __members;

    private TdfInt32 _numUsers = new(__typeInfos[0]);
    private TdfList<Blaze2SDK.Blaze.Registration.RegistrationUser> _registeredUsers = new(__typeInfos[1]);

    public RegistrationReturnusersResponse()
    {
        __members = [
            _numUsers,
            _registeredUsers,
        ];
    }

    public override Tdf CreateNew() => new RegistrationReturnusersResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "RegistrationReturnusersResponse";
    public override string GetFullClassName() => "Blaze::Registration::RegistrationReturnusersResponse";

    public int NumUsers
    {
        get => _numUsers.Value;
        set => _numUsers.Value = value;
    }

    public IList<Blaze2SDK.Blaze.Registration.RegistrationUser> RegisteredUsers
    {
        get => _registeredUsers.Value;
        set => _registeredUsers.Value = value;
    }

}

