using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Clubs;

public class UpdateCachedClubRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("BlazeId", "mBlazeId", 0x8ACA6400, TdfType.Int64, 0, true), // BLID
        new TdfMemberInfo("MapClubIdToCachedClubData", "mMapClubIdToCachedClubData", 0xB63A7300, TdfType.Map, 1, true), // MCIS
        new TdfMemberInfo("MapClubIdToMemberInfo", "mMapClubIdToMemberInfo", 0xB63B6900, TdfType.Map, 2, true), // MCMI
        new TdfMemberInfo("Reason", "mReason", 0xD70CB300, TdfType.Enum, 3, true), // UPRS
    ];
    private ITdfMember[] __members;

    private TdfInt64 _blazeId = new(__typeInfos[0]);
    private TdfMap<uint, Blaze3SDK.Blaze.Clubs.ReplicatedCachedClubData> _mapClubIdToCachedClubData = new(__typeInfos[1]);
    private TdfMap<uint, Blaze3SDK.Blaze.Clubs.ReplicatedCachedMemberInfo> _mapClubIdToMemberInfo = new(__typeInfos[2]);
    private TdfEnum<Blaze3SDK.Blaze.Clubs.UpdateReason> _reason = new(__typeInfos[3]);

    public UpdateCachedClubRequest()
    {
        __members = [
            _blazeId,
            _mapClubIdToCachedClubData,
            _mapClubIdToMemberInfo,
            _reason,
        ];
    }

    public override Tdf CreateNew() => new UpdateCachedClubRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "UpdateCachedClubRequest";
    public override string GetFullClassName() => "Blaze::Clubs::UpdateCachedClubRequest";

    public long BlazeId
    {
        get => _blazeId.Value;
        set => _blazeId.Value = value;
    }

    public IDictionary<uint, Blaze3SDK.Blaze.Clubs.ReplicatedCachedClubData> MapClubIdToCachedClubData
    {
        get => _mapClubIdToCachedClubData.Value;
        set => _mapClubIdToCachedClubData.Value = value;
    }

    public IDictionary<uint, Blaze3SDK.Blaze.Clubs.ReplicatedCachedMemberInfo> MapClubIdToMemberInfo
    {
        get => _mapClubIdToMemberInfo.Value;
        set => _mapClubIdToMemberInfo.Value = value;
    }

    public Blaze3SDK.Blaze.Clubs.UpdateReason Reason
    {
        get => _reason.Value;
        set => _reason.Value = value;
    }

}

