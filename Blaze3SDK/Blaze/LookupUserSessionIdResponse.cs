using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze;

public class LookupUserSessionIdResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("UsersessionidList", "mUsersessionidList", 0xCE990000, TdfType.List, 0, true), // SID
    ];
    private ITdfMember[] __members;

    private TdfList<uint> _usersessionidList = new(__typeInfos[0]);

    public LookupUserSessionIdResponse()
    {
        __members = [
            _usersessionidList,
        ];
    }

    public override Tdf CreateNew() => new LookupUserSessionIdResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "LookupUserSessionIdResponse";
    public override string GetFullClassName() => "Blaze::LookupUserSessionIdResponse";

    public IList<uint> UsersessionidList
    {
        get => _usersessionidList.Value;
        set => _usersessionidList.Value = value;
    }

}

