using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.CensusData;

public class RegionCounts : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("NumOfUsersByRegion", "mNumOfUsersByRegion", 0x8EEBF500, TdfType.Map, 0, true), // CNOU
    ];
    private ITdfMember[] __members;

    private TdfMap<string, uint> _numOfUsersByRegion = new(__typeInfos[0]);

    public RegionCounts()
    {
        __members = [
            _numOfUsersByRegion,
        ];
    }

    public override Tdf CreateNew() => new RegionCounts();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "RegionCounts";
    public override string GetFullClassName() => "Blaze::CensusData::RegionCounts";

    public IDictionary<string, uint> NumOfUsersByRegion
    {
        get => _numOfUsersByRegion.Value;
        set => _numOfUsersByRegion.Value = value;
    }

}

