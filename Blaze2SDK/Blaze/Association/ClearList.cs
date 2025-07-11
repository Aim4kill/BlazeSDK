using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Association;

public class ClearList : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ListName", "mListName", 0x86CBAD00, TdfType.String, 0, true), // ALNM
    ];
    private ITdfMember[] __members;

    private TdfString _listName = new(__typeInfos[0]);

    public ClearList()
    {
        __members = [
            _listName,
        ];
    }

    public override Tdf CreateNew() => new ClearList();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ClearList";
    public override string GetFullClassName() => "Blaze::Association::ClearList";

    public string ListName
    {
        get => _listName.Value;
        set => _listName.Value = value;
    }

}

