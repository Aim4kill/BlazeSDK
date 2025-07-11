using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Clubs;

public class RemoveMemberOnlineStatusMasterRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ClubId", "mClubId", 0x8ECA6400, TdfType.UInt32, 0, true), // CLID
        new TdfMemberInfo("Reason", "mReason", 0xCA587300, TdfType.Enum, 1, true), // REAS
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _clubId = new(__typeInfos[0]);
    private TdfEnum<Blaze2SDK.Blaze.Clubs.ClubOnlineStatusUpdateReason> _reason = new(__typeInfos[1]);

    public RemoveMemberOnlineStatusMasterRequest()
    {
        __members = [
            _clubId,
            _reason,
        ];
    }

    public override Tdf CreateNew() => new RemoveMemberOnlineStatusMasterRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "RemoveMemberOnlineStatusMasterRequest";
    public override string GetFullClassName() => "Blaze::Clubs::RemoveMemberOnlineStatusMasterRequest";

    public uint ClubId
    {
        get => _clubId.Value;
        set => _clubId.Value = value;
    }

    public Blaze2SDK.Blaze.Clubs.ClubOnlineStatusUpdateReason Reason
    {
        get => _reason.Value;
        set => _reason.Value = value;
    }

}

