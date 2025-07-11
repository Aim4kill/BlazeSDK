using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Clubs;

public class UpdateCachedMemberOnlineStatusRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("BlazeId", "mBlazeId", 0x8ACA6400, TdfType.Int64, 0, true), // BLID
        new TdfMemberInfo("ClubId", "mClubId", 0x8ECA6400, TdfType.UInt32, 1, true), // CLID
        new TdfMemberInfo("OnlineStatus", "mOnlineStatus", 0xBADBF300, TdfType.Enum, 2, true), // NMOS
        new TdfMemberInfo("Reason", "mReason", 0xD70CB300, TdfType.Enum, 3, true), // UPRS
    ];
    private ITdfMember[] __members;

    private TdfInt64 _blazeId = new(__typeInfos[0]);
    private TdfUInt32 _clubId = new(__typeInfos[1]);
    private TdfEnum<Blaze3SDK.Blaze.Clubs.MemberOnlineStatus> _onlineStatus = new(__typeInfos[2]);
    private TdfEnum<Blaze3SDK.Blaze.Clubs.UpdateReason> _reason = new(__typeInfos[3]);

    public UpdateCachedMemberOnlineStatusRequest()
    {
        __members = [
            _blazeId,
            _clubId,
            _onlineStatus,
            _reason,
        ];
    }

    public override Tdf CreateNew() => new UpdateCachedMemberOnlineStatusRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "UpdateCachedMemberOnlineStatusRequest";
    public override string GetFullClassName() => "Blaze::Clubs::UpdateCachedMemberOnlineStatusRequest";

    public long BlazeId
    {
        get => _blazeId.Value;
        set => _blazeId.Value = value;
    }

    public uint ClubId
    {
        get => _clubId.Value;
        set => _clubId.Value = value;
    }

    public Blaze3SDK.Blaze.Clubs.MemberOnlineStatus OnlineStatus
    {
        get => _onlineStatus.Value;
        set => _onlineStatus.Value = value;
    }

    public Blaze3SDK.Blaze.Clubs.UpdateReason Reason
    {
        get => _reason.Value;
        set => _reason.Value = value;
    }

}

