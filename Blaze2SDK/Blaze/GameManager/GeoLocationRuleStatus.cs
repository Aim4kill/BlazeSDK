using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.GameManager;

public class GeoLocationRuleStatus : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("MaxDistance", "mMaxDistance", 0x929CF400, TdfType.UInt32, 0, true), // DIST
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _maxDistance = new(__typeInfos[0]);

    public GeoLocationRuleStatus()
    {
        __members = [
            _maxDistance,
        ];
    }

    public override Tdf CreateNew() => new GeoLocationRuleStatus();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GeoLocationRuleStatus";
    public override string GetFullClassName() => "Blaze::GameManager::GeoLocationRuleStatus";

    public uint MaxDistance
    {
        get => _maxDistance.Value;
        set => _maxDistance.Value = value;
    }

}

