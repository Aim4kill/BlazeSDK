using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Messaging;

public class SlaveMessage : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Message", "mMessage", 0xB65CE700, TdfType.Struct, 0, true), // MESG
        new TdfMemberInfo("TargetUserSessionIds", "mTargetUserSessionIds", 0xD35A6400, TdfType.List, 1, true), // TUID
    ];
    private ITdfMember[] __members;

    private TdfStruct<Blaze3SDK.Blaze.Messaging.ServerMessage?> _message = new(__typeInfos[0]);
    private TdfList<uint> _targetUserSessionIds = new(__typeInfos[1]);

    public SlaveMessage()
    {
        __members = [
            _message,
            _targetUserSessionIds,
        ];
    }

    public override Tdf CreateNew() => new SlaveMessage();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "SlaveMessage";
    public override string GetFullClassName() => "Blaze::Messaging::SlaveMessage";

    public Blaze3SDK.Blaze.Messaging.ServerMessage? Message
    {
        get => _message.Value;
        set => _message.Value = value;
    }

    public IList<uint> TargetUserSessionIds
    {
        get => _targetUserSessionIds.Value;
        set => _targetUserSessionIds.Value = value;
    }

}

