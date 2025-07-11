using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.CommerceInfo;

public class LocaleAttributesMap : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("LocaleAttributeMap", "mLocaleAttributeMap", 0xB21B7000, TdfType.Map, 0, true), // LAMP
    ];
    private ITdfMember[] __members;

    private TdfMap<string, string> _localeAttributeMap = new(__typeInfos[0]);

    public LocaleAttributesMap()
    {
        __members = [
            _localeAttributeMap,
        ];
    }

    public override Tdf CreateNew() => new LocaleAttributesMap();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "LocaleAttributesMap";
    public override string GetFullClassName() => "Blaze::CommerceInfo::LocaleAttributesMap";

    public IDictionary<string, string> LocaleAttributeMap
    {
        get => _localeAttributeMap.Value;
        set => _localeAttributeMap.Value = value;
    }

}

