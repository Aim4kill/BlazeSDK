using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Playgroups;

public class PlaygroupCensusData : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("NumOfPlaygroup", "mNumOfPlaygroup", 0xC27B8000, TdfType.UInt32, 0, true), // PGN
        new TdfMemberInfo("NumOfPlayersInPlaygroup", "mNumOfPlayersInPlaygroup", 0xC29C2E00, TdfType.UInt32, 1, true), // PIPN
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _numOfPlaygroup = new(__typeInfos[0]);
    private TdfUInt32 _numOfPlayersInPlaygroup = new(__typeInfos[1]);

    public PlaygroupCensusData()
    {
        __members = [
            _numOfPlaygroup,
            _numOfPlayersInPlaygroup,
        ];
    }

    public override Tdf CreateNew() => new PlaygroupCensusData();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "PlaygroupCensusData";
    public override string GetFullClassName() => "Blaze::Playgroups::PlaygroupCensusData";

    public uint NumOfPlaygroup
    {
        get => _numOfPlaygroup.Value;
        set => _numOfPlaygroup.Value = value;
    }

    public uint NumOfPlayersInPlaygroup
    {
        get => _numOfPlayersInPlaygroup.Value;
        set => _numOfPlayersInPlaygroup.Value = value;
    }

}

