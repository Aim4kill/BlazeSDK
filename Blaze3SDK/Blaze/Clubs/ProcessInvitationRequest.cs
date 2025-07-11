using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Clubs;

public class ProcessInvitationRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("InvitationId", "mInvitationId", 0xA6EA6400, TdfType.UInt32, 0, true), // INID
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _invitationId = new(__typeInfos[0]);

    public ProcessInvitationRequest()
    {
        __members = [
            _invitationId,
        ];
    }

    public override Tdf CreateNew() => new ProcessInvitationRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ProcessInvitationRequest";
    public override string GetFullClassName() => "Blaze::Clubs::ProcessInvitationRequest";

    public uint InvitationId
    {
        get => _invitationId.Value;
        set => _invitationId.Value = value;
    }

}

