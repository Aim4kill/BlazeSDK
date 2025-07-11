using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Redirector;

public class ServerInstanceError : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Messages", "mMessages", 0xB739F300, TdfType.List, 0, true), // MSGS
    ];
    private ITdfMember[] __members;

    private TdfList<string> _messages = new(__typeInfos[0]);

    public ServerInstanceError()
    {
        __members = [
            _messages,
        ];
    }

    public override Tdf CreateNew() => new ServerInstanceError();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ServerInstanceError";
    public override string GetFullClassName() => "Blaze::Redirector::ServerInstanceError";

    public IList<string> Messages
    {
        get => _messages.Value;
        set => _messages.Value = value;
    }

}

