using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameReporting;

public class UpdateMetricRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("MetricName", "mMetricName", 0xB65D3200, TdfType.String, 0, true), // METR
        new TdfMemberInfo("Value", "mValue", 0xDA1B3500, TdfType.Int64, 1, true), // VALU
    ];
    private ITdfMember[] __members;

    private TdfString _metricName = new(__typeInfos[0]);
    private TdfInt64 _value = new(__typeInfos[1]);

    public UpdateMetricRequest()
    {
        __members = [
            _metricName,
            _value,
        ];
    }

    public override Tdf CreateNew() => new UpdateMetricRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "UpdateMetricRequest";
    public override string GetFullClassName() => "Blaze::GameReporting::UpdateMetricRequest";

    public string MetricName
    {
        get => _metricName.Value;
        set => _metricName.Value = value;
    }

    public long Value
    {
        get => _value.Value;
        set => _value.Value = value;
    }

}

