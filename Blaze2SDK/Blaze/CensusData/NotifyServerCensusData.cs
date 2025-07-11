using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.CensusData;

public class NotifyServerCensusData : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("CensusDataByIndexMap", "mCensusDataByIndexMap", 0x8E48A900, TdfType.Map, 0, true), // CDBI
    ];
    private ITdfMember[] __members;

    private TdfMap<uint, Blaze2SDK.Blaze.CensusValue> _censusDataByIndexMap = new(__typeInfos[0]);

    public NotifyServerCensusData()
    {
        __members = [
            _censusDataByIndexMap,
        ];
    }

    public override Tdf CreateNew() => new NotifyServerCensusData();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "NotifyServerCensusData";
    public override string GetFullClassName() => "Blaze::CensusData::NotifyServerCensusData";

    public IDictionary<uint, Blaze2SDK.Blaze.CensusValue> CensusDataByIndexMap
    {
        get => _censusDataByIndexMap.Value;
        set => _censusDataByIndexMap.Value = value;
    }

}

