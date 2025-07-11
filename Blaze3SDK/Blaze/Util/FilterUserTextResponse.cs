using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Util;

public class FilterUserTextResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("FilteredTextList", "mFilteredTextList", 0xD2CCF400, TdfType.List, 0, true), // TLST
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze3SDK.Blaze.Util.FilteredUserText> _filteredTextList = new(__typeInfos[0]);

    public FilterUserTextResponse()
    {
        __members = [
            _filteredTextList,
        ];
    }

    public override Tdf CreateNew() => new FilterUserTextResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "FilterUserTextResponse";
    public override string GetFullClassName() => "Blaze::Util::FilterUserTextResponse";

    public IList<Blaze3SDK.Blaze.Util.FilteredUserText> FilteredTextList
    {
        get => _filteredTextList.Value;
        set => _filteredTextList.Value = value;
    }

}

