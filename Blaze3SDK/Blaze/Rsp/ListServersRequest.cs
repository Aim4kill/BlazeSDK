using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Rsp;

public class ListServersRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("IncludeHistory", "mIncludeHistory", 0xA29CF400, TdfType.Bool, 0, true), // HIST
        new TdfMemberInfo("IncludeAdminServers", "mIncludeAdminServers", 0xA6192D00, TdfType.Bool, 1, true), // IADM
        new TdfMemberInfo("UserId", "mUserId", 0xD6990000, TdfType.Int64, 2, true), // UID
    ];
    private ITdfMember[] __members;

    private TdfBool _includeHistory = new(__typeInfos[0]);
    private TdfBool _includeAdminServers = new(__typeInfos[1]);
    private TdfInt64 _userId = new(__typeInfos[2]);

    public ListServersRequest()
    {
        __members = [
            _includeHistory,
            _includeAdminServers,
            _userId,
        ];
    }

    public override Tdf CreateNew() => new ListServersRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ListServersRequest";
    public override string GetFullClassName() => "Blaze::Rsp::ListServersRequest";

    public bool IncludeHistory
    {
        get => _includeHistory.Value;
        set => _includeHistory.Value = value;
    }

    public bool IncludeAdminServers
    {
        get => _includeAdminServers.Value;
        set => _includeAdminServers.Value = value;
    }

    public long UserId
    {
        get => _userId.Value;
        set => _userId.Value = value;
    }

}

