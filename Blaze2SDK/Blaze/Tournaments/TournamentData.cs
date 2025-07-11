using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Tournaments;

public class TournamentData : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Description", "mDescription", 0x925CE300, TdfType.String, 0, true), // DESC
        new TdfMemberInfo("Name", "mName", 0xBA1B6500, TdfType.String, 1, true), // NAME
        new TdfMemberInfo("TotalMemberCount", "mTotalMemberCount", 0xBAD96D00, TdfType.UInt32, 2, true), // NMEM
        new TdfMemberInfo("OnlineMemberCount", "mOnlineMemberCount", 0xBAFB6D00, TdfType.UInt32, 3, true), // NOMM
        new TdfMemberInfo("NumRounds", "mNumRounds", 0xCAE93300, TdfType.UInt32, 4, true), // RNDS
        new TdfMemberInfo("TrophyMetaData", "mTrophyMetaData", 0xD2D97400, TdfType.String, 5, true), // TMET
        new TdfMemberInfo("TrophyName", "mTrophyName", 0xD2E86D00, TdfType.String, 6, true), // TNAM
        new TdfMemberInfo("Id", "mId", 0xD2EA6400, TdfType.UInt32, 7, true), // TNID
    ];
    private ITdfMember[] __members;

    private TdfString _description = new(__typeInfos[0]);
    private TdfString _name = new(__typeInfos[1]);
    private TdfUInt32 _totalMemberCount = new(__typeInfos[2]);
    private TdfUInt32 _onlineMemberCount = new(__typeInfos[3]);
    private TdfUInt32 _numRounds = new(__typeInfos[4]);
    private TdfString _trophyMetaData = new(__typeInfos[5]);
    private TdfString _trophyName = new(__typeInfos[6]);
    private TdfUInt32 _id = new(__typeInfos[7]);

    public TournamentData()
    {
        __members = [
            _description,
            _name,
            _totalMemberCount,
            _onlineMemberCount,
            _numRounds,
            _trophyMetaData,
            _trophyName,
            _id,
        ];
    }

    public override Tdf CreateNew() => new TournamentData();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "TournamentData";
    public override string GetFullClassName() => "Blaze::Tournaments::TournamentData";

    public string Description
    {
        get => _description.Value;
        set => _description.Value = value;
    }

    public string Name
    {
        get => _name.Value;
        set => _name.Value = value;
    }

    public uint TotalMemberCount
    {
        get => _totalMemberCount.Value;
        set => _totalMemberCount.Value = value;
    }

    public uint OnlineMemberCount
    {
        get => _onlineMemberCount.Value;
        set => _onlineMemberCount.Value = value;
    }

    public uint NumRounds
    {
        get => _numRounds.Value;
        set => _numRounds.Value = value;
    }

    public string TrophyMetaData
    {
        get => _trophyMetaData.Value;
        set => _trophyMetaData.Value = value;
    }

    public string TrophyName
    {
        get => _trophyName.Value;
        set => _trophyName.Value = value;
    }

    public uint Id
    {
        get => _id.Value;
        set => _id.Value = value;
    }

}

