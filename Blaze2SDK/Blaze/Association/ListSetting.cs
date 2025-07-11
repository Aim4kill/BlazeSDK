using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Association;

public class ListSetting : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ListName", "mListName", 0x86CBAD00, TdfType.String, 0, true), // ALNM
        new TdfMemberInfo("Subscribe", "mSubscribe", 0xCF58A600, TdfType.Bool, 1, true), // SUBF
    ];
    private ITdfMember[] __members;

    private TdfString _listName = new(__typeInfos[0]);
    private TdfBool _subscribe = new(__typeInfos[1]);

    public ListSetting()
    {
        __members = [
            _listName,
            _subscribe,
        ];
    }

    public override Tdf CreateNew() => new ListSetting();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ListSetting";
    public override string GetFullClassName() => "Blaze::Association::ListSetting";

    public string ListName
    {
        get => _listName.Value;
        set => _listName.Value = value;
    }

    public bool Subscribe
    {
        get => _subscribe.Value;
        set => _subscribe.Value = value;
    }

}

