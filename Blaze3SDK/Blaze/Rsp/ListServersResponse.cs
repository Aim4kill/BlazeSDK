using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Rsp;

public class ListServersResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ServerList", "mServerList", 0xCECCF400, TdfType.List, 0, true), // SLST
        new TdfMemberInfo("CurrentTime", "mCurrentTime", 0xD29B6500, TdfType.TimeValue, 1, true), // TIME
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze3SDK.Blaze.Rsp.Server> _serverList = new(__typeInfos[0]);
    private TdfTimeValue _currentTime = new(__typeInfos[1]);

    public ListServersResponse()
    {
        __members = [
            _serverList,
            _currentTime,
        ];
    }

    public override Tdf CreateNew() => new ListServersResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ListServersResponse";
    public override string GetFullClassName() => "Blaze::Rsp::ListServersResponse";

    public IList<Blaze3SDK.Blaze.Rsp.Server> ServerList
    {
        get => _serverList.Value;
        set => _serverList.Value = value;
    }

    public TimeValue CurrentTime
    {
        get => _currentTime.Value;
        set => _currentTime.Value = value;
    }

}

