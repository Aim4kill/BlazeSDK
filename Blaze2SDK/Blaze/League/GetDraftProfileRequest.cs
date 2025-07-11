using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.League;

public class GetDraftProfileRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Count", "mCount", 0x8EED0000, TdfType.UInt16, 0, true), // CNT
        new TdfMemberInfo("LeagueId", "mLeagueId", 0xB27A6400, TdfType.UInt32, 1, true), // LGID
        new TdfMemberInfo("StartingRank", "mStartingRank", 0xCF4CB400, TdfType.UInt16, 2, true), // STRT
    ];
    private ITdfMember[] __members;

    private TdfUInt16 _count = new(__typeInfos[0]);
    private TdfUInt32 _leagueId = new(__typeInfos[1]);
    private TdfUInt16 _startingRank = new(__typeInfos[2]);

    public GetDraftProfileRequest()
    {
        __members = [
            _count,
            _leagueId,
            _startingRank,
        ];
    }

    public override Tdf CreateNew() => new GetDraftProfileRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetDraftProfileRequest";
    public override string GetFullClassName() => "Blaze::League::GetDraftProfileRequest";

    public ushort Count
    {
        get => _count.Value;
        set => _count.Value = value;
    }

    public uint LeagueId
    {
        get => _leagueId.Value;
        set => _leagueId.Value = value;
    }

    public ushort StartingRank
    {
        get => _startingRank.Value;
        set => _startingRank.Value = value;
    }

}

