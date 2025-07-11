using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.CensusData;

public class NotifyServerCensusData : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("CensusDataList", "mCensusDataList", 0xD249AC00, TdfType.List, 0, true), // TDFL
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze3SDK.Blaze.CensusData.NotifyServerCensusDataItem> _censusDataList = new(__typeInfos[0]);

    public NotifyServerCensusData()
    {
        __members = [
            _censusDataList,
        ];
    }

    public override Tdf CreateNew() => new NotifyServerCensusData();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "NotifyServerCensusData";
    public override string GetFullClassName() => "Blaze::CensusData::NotifyServerCensusData";

    public IList<Blaze3SDK.Blaze.CensusData.NotifyServerCensusDataItem> CensusDataList
    {
        get => _censusDataList.Value;
        set => _censusDataList.Value = value;
    }

}

