using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze;

public class UserDataResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("UserDataList", "mUserDataList", 0xD6CCF400, TdfType.List, 0, true), // ULST
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze2SDK.Blaze.UserData> _userDataList = new(__typeInfos[0]);

    public UserDataResponse()
    {
        __members = [
            _userDataList,
        ];
    }

    public override Tdf CreateNew() => new UserDataResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "UserDataResponse";
    public override string GetFullClassName() => "Blaze::UserDataResponse";

    public IList<Blaze2SDK.Blaze.UserData> UserDataList
    {
        get => _userDataList.Value;
        set => _userDataList.Value = value;
    }

}

