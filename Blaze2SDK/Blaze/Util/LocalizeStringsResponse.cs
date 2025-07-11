using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Util;

public class LocalizeStringsResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("LocalizedStrings", "mLocalizedStrings", 0xCED87000, TdfType.Map, 0, true), // SMAP
    ];
    private ITdfMember[] __members;

    private TdfMap<string, string> _localizedStrings = new(__typeInfos[0]);

    public LocalizeStringsResponse()
    {
        __members = [
            _localizedStrings,
        ];
    }

    public override Tdf CreateNew() => new LocalizeStringsResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "LocalizeStringsResponse";
    public override string GetFullClassName() => "Blaze::Util::LocalizeStringsResponse";

    public IDictionary<string, string> LocalizedStrings
    {
        get => _localizedStrings.Value;
        set => _localizedStrings.Value = value;
    }

}

