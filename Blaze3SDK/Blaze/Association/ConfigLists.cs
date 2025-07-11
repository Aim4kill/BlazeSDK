using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Association;

public class ConfigLists : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ListsInfo", "mListsInfo", 0xB3393400, TdfType.List, 0, true), // LSDT
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze3SDK.Blaze.Association.ListData> _listsInfo = new(__typeInfos[0]);

    public ConfigLists()
    {
        __members = [
            _listsInfo,
        ];
    }

    public override Tdf CreateNew() => new ConfigLists();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ConfigLists";
    public override string GetFullClassName() => "Blaze::Association::ConfigLists";

    public IList<Blaze3SDK.Blaze.Association.ListData> ListsInfo
    {
        get => _listsInfo.Value;
        set => _listsInfo.Value = value;
    }

}

