using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Stats;

public class LeaderboardStatValuesRow : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("EntityName", "mEntityName", 0x96E86D00, TdfType.String, 0, true), // ENAM
        new TdfMemberInfo("EntityId", "mEntityId", 0x96EA6400, TdfType.UInt32, 1, true), // ENID
        new TdfMemberInfo("Rank", "mRank", 0xCA1BAB00, TdfType.Int32, 2, true), // RANK
        new TdfMemberInfo("RankedStat", "mRankedStat", 0xCB3D2100, TdfType.String, 3, true), // RSTA
        new TdfMemberInfo("OtherStats", "mOtherStats", 0xCF487400, TdfType.List, 4, true), // STAT
        new TdfMemberInfo("Attribute", "mAttribute", 0xD61D3400, TdfType.UInt64, 5, true), // UATT
    ];
    private ITdfMember[] __members;

    private TdfString _entityName = new(__typeInfos[0]);
    private TdfUInt32 _entityId = new(__typeInfos[1]);
    private TdfInt32 _rank = new(__typeInfos[2]);
    private TdfString _rankedStat = new(__typeInfos[3]);
    private TdfList<string> _otherStats = new(__typeInfos[4]);
    private TdfUInt64 _attribute = new(__typeInfos[5]);

    public LeaderboardStatValuesRow()
    {
        __members = [
            _entityName,
            _entityId,
            _rank,
            _rankedStat,
            _otherStats,
            _attribute,
        ];
    }

    public override Tdf CreateNew() => new LeaderboardStatValuesRow();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "LeaderboardStatValuesRow";
    public override string GetFullClassName() => "Blaze::Stats::LeaderboardStatValuesRow";

    public string EntityName
    {
        get => _entityName.Value;
        set => _entityName.Value = value;
    }

    public uint EntityId
    {
        get => _entityId.Value;
        set => _entityId.Value = value;
    }

    public int Rank
    {
        get => _rank.Value;
        set => _rank.Value = value;
    }

    public string RankedStat
    {
        get => _rankedStat.Value;
        set => _rankedStat.Value = value;
    }

    public IList<string> OtherStats
    {
        get => _otherStats.Value;
        set => _otherStats.Value = value;
    }

    public ulong Attribute
    {
        get => _attribute.Value;
        set => _attribute.Value = value;
    }

}

