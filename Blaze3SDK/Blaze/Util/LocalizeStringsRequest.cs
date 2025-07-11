using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Util;

public class LocalizeStringsRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Locale", "mLocale", 0xB21BA700, TdfType.UInt32, 0, true), // LANG
        new TdfMemberInfo("StringIds", "mStringIds", 0xB33A6400, TdfType.List, 1, true), // LSID
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _locale = new(__typeInfos[0]);
    private TdfList<string> _stringIds = new(__typeInfos[1]);

    public LocalizeStringsRequest()
    {
        __members = [
            _locale,
            _stringIds,
        ];
    }

    public override Tdf CreateNew() => new LocalizeStringsRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "LocalizeStringsRequest";
    public override string GetFullClassName() => "Blaze::Util::LocalizeStringsRequest";

    public uint Locale
    {
        get => _locale.Value;
        set => _locale.Value = value;
    }

    public IList<string> StringIds
    {
        get => _stringIds.Value;
        set => _stringIds.Value = value;
    }

}

