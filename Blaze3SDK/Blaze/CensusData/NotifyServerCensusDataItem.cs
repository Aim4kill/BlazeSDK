using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.CensusData;

public class NotifyServerCensusDataItem : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Tdf", "mTdf", 0xD2498000, TdfType.Variable, 0, true), // TDF
    ];
    private ITdfMember[] __members;

    private TdfVariable _tdf = new(__typeInfos[0]);

    public NotifyServerCensusDataItem()
    {
        __members = [
            _tdf,
        ];
    }

    public override Tdf CreateNew() => new NotifyServerCensusDataItem();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "NotifyServerCensusDataItem";
    public override string GetFullClassName() => "Blaze::CensusData::NotifyServerCensusDataItem";

    public object? Tdf
    {
        get => _tdf.Value;
        set => _tdf.Value = value;
    }

}

