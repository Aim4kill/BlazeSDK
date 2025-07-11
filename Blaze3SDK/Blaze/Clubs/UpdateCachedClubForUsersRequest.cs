using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Clubs;

public class UpdateCachedClubForUsersRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ClubId", "mClubId", 0x8ECA6400, TdfType.UInt32, 0, true), // CLID
        new TdfMemberInfo("MapBlazeIdToMemberInfo", "mMapBlazeIdToMemberInfo", 0xB62B6900, TdfType.Map, 1, true), // MBMI
        new TdfMemberInfo("Reason", "mReason", 0xD70CB300, TdfType.Enum, 2, true), // UPRS
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _clubId = new(__typeInfos[0]);
    private TdfMap<long, Blaze3SDK.Blaze.Clubs.ReplicatedCachedMemberInfo> _mapBlazeIdToMemberInfo = new(__typeInfos[1]);
    private TdfEnum<Blaze3SDK.Blaze.Clubs.UpdateReason> _reason = new(__typeInfos[2]);

    public UpdateCachedClubForUsersRequest()
    {
        __members = [
            _clubId,
            _mapBlazeIdToMemberInfo,
            _reason,
        ];
    }

    public override Tdf CreateNew() => new UpdateCachedClubForUsersRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "UpdateCachedClubForUsersRequest";
    public override string GetFullClassName() => "Blaze::Clubs::UpdateCachedClubForUsersRequest";

    public uint ClubId
    {
        get => _clubId.Value;
        set => _clubId.Value = value;
    }

    public IDictionary<long, Blaze3SDK.Blaze.Clubs.ReplicatedCachedMemberInfo> MapBlazeIdToMemberInfo
    {
        get => _mapBlazeIdToMemberInfo.Value;
        set => _mapBlazeIdToMemberInfo.Value = value;
    }

    public Blaze3SDK.Blaze.Clubs.UpdateReason Reason
    {
        get => _reason.Value;
        set => _reason.Value = value;
    }

}

