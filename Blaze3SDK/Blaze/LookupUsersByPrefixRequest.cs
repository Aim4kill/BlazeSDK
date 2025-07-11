using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze;

public class LookupUsersByPrefixRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("MaxResultCount", "mMaxResultCount", 0x8E1C0000, TdfType.UInt32, 0, true), // CAP
        new TdfMemberInfo("PrefixName", "mPrefixName", 0xC3296600, TdfType.String, 1, true), // PREF
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _maxResultCount = new(__typeInfos[0]);
    private TdfString _prefixName = new(__typeInfos[1]);

    public LookupUsersByPrefixRequest()
    {
        __members = [
            _maxResultCount,
            _prefixName,
        ];
    }

    public override Tdf CreateNew() => new LookupUsersByPrefixRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "LookupUsersByPrefixRequest";
    public override string GetFullClassName() => "Blaze::LookupUsersByPrefixRequest";

    public uint MaxResultCount
    {
        get => _maxResultCount.Value;
        set => _maxResultCount.Value = value;
    }

    public string PrefixName
    {
        get => _prefixName.Value;
        set => _prefixName.Value = value;
    }

}

