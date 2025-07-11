using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.DynamicInetFilter;

public class ListResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Entries", "mEntries", 0x96ED3300, TdfType.List, 0, true), // ENTS
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze3SDK.Blaze.DynamicInetFilter.Entry> _entries = new(__typeInfos[0]);

    public ListResponse()
    {
        __members = [
            _entries,
        ];
    }

    public override Tdf CreateNew() => new ListResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ListResponse";
    public override string GetFullClassName() => "Blaze::DynamicInetFilter::ListResponse";

    public IList<Blaze3SDK.Blaze.DynamicInetFilter.Entry> Entries
    {
        get => _entries.Value;
        set => _entries.Value = value;
    }

}

