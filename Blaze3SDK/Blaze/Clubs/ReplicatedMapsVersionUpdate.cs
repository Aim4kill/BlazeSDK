using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Clubs;

public class ReplicatedMapsVersionUpdate : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("CachedClubDataMapIsUpdated", "mCachedClubDataMapIsUpdated", 0x8E3B7500, TdfType.Bool, 0, true), // CCMU
        new TdfMemberInfo("CachedClubDataMapVersion", "mCachedClubDataMapVersion", 0x8E3B7600, TdfType.UInt32, 1, true), // CCMV
        new TdfMemberInfo("LastUpdatedClubId", "mLastUpdatedClubId", 0x8ECA6400, TdfType.UInt32, 2, true), // CLID
        new TdfMemberInfo("CachedMemberInfoMapVersion", "mCachedMemberInfoMapVersion", 0x8EDA7600, TdfType.UInt32, 3, true), // CMIV
        new TdfMemberInfo("CachedMemberOnlineStatusMapIsUpdated", "mCachedMemberOnlineStatusMapIsUpdated", 0xB6FCF500, TdfType.Bool, 4, true), // MOSU
        new TdfMemberInfo("CachedMemberOnlineStatusMapVersion", "mCachedMemberOnlineStatusMapVersion", 0xB6FCF600, TdfType.UInt32, 5, true), // MOSV
    ];
    private ITdfMember[] __members;

    private TdfBool _cachedClubDataMapIsUpdated = new(__typeInfos[0]);
    private TdfUInt32 _cachedClubDataMapVersion = new(__typeInfos[1]);
    private TdfUInt32 _lastUpdatedClubId = new(__typeInfos[2]);
    private TdfUInt32 _cachedMemberInfoMapVersion = new(__typeInfos[3]);
    private TdfBool _cachedMemberOnlineStatusMapIsUpdated = new(__typeInfos[4]);
    private TdfUInt32 _cachedMemberOnlineStatusMapVersion = new(__typeInfos[5]);

    public ReplicatedMapsVersionUpdate()
    {
        __members = [
            _cachedClubDataMapIsUpdated,
            _cachedClubDataMapVersion,
            _lastUpdatedClubId,
            _cachedMemberInfoMapVersion,
            _cachedMemberOnlineStatusMapIsUpdated,
            _cachedMemberOnlineStatusMapVersion,
        ];
    }

    public override Tdf CreateNew() => new ReplicatedMapsVersionUpdate();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ReplicatedMapsVersionUpdate";
    public override string GetFullClassName() => "Blaze::Clubs::ReplicatedMapsVersionUpdate";

    public bool CachedClubDataMapIsUpdated
    {
        get => _cachedClubDataMapIsUpdated.Value;
        set => _cachedClubDataMapIsUpdated.Value = value;
    }

    public uint CachedClubDataMapVersion
    {
        get => _cachedClubDataMapVersion.Value;
        set => _cachedClubDataMapVersion.Value = value;
    }

    public uint LastUpdatedClubId
    {
        get => _lastUpdatedClubId.Value;
        set => _lastUpdatedClubId.Value = value;
    }

    public uint CachedMemberInfoMapVersion
    {
        get => _cachedMemberInfoMapVersion.Value;
        set => _cachedMemberInfoMapVersion.Value = value;
    }

    public bool CachedMemberOnlineStatusMapIsUpdated
    {
        get => _cachedMemberOnlineStatusMapIsUpdated.Value;
        set => _cachedMemberOnlineStatusMapIsUpdated.Value = value;
    }

    public uint CachedMemberOnlineStatusMapVersion
    {
        get => _cachedMemberOnlineStatusMapVersion.Value;
        set => _cachedMemberOnlineStatusMapVersion.Value = value;
    }

}

