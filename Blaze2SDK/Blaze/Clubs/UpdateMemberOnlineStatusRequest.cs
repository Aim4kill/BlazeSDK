using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Clubs;

public class UpdateMemberOnlineStatusRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("NewStatus", "mNewStatus", 0xCF487400, TdfType.Enum, 0, true), // STAT
    ];
    private ITdfMember[] __members;

    private TdfEnum<Blaze2SDK.Blaze.Clubs.MemberOnlineStatus> _newStatus = new(__typeInfos[0]);

    public UpdateMemberOnlineStatusRequest()
    {
        __members = [
            _newStatus,
        ];
    }

    public override Tdf CreateNew() => new UpdateMemberOnlineStatusRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "UpdateMemberOnlineStatusRequest";
    public override string GetFullClassName() => "Blaze::Clubs::UpdateMemberOnlineStatusRequest";

    public Blaze2SDK.Blaze.Clubs.MemberOnlineStatus NewStatus
    {
        get => _newStatus.Value;
        set => _newStatus.Value = value;
    }

}

