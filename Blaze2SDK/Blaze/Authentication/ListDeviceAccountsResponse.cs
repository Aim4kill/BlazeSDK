using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Authentication;

public class ListDeviceAccountsResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("UserList", "mUserList", 0xD73CAC00, TdfType.List, 0, true), // USRL
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze2SDK.Blaze.Authentication.UserDetails> _userList = new(__typeInfos[0]);

    public ListDeviceAccountsResponse()
    {
        __members = [
            _userList,
        ];
    }

    public override Tdf CreateNew() => new ListDeviceAccountsResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ListDeviceAccountsResponse";
    public override string GetFullClassName() => "Blaze::Authentication::ListDeviceAccountsResponse";

    public IList<Blaze2SDK.Blaze.Authentication.UserDetails> UserList
    {
        get => _userList.Value;
        set => _userList.Value = value;
    }

}

