using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Association;

public class ListIdentification : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ListName", "mListName", 0xB2EB4000, TdfType.String, 0, true), // LNM
        new TdfMemberInfo("ListType", "mListType", 0xD39C2500, TdfType.UInt32, 1, true), // TYPE
    ];
    private ITdfMember[] __members;

    private TdfString _listName = new(__typeInfos[0]);
    private TdfUInt32 _listType = new(__typeInfos[1]);

    public ListIdentification()
    {
        __members = [
            _listName,
            _listType,
        ];
    }

    public override Tdf CreateNew() => new ListIdentification();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ListIdentification";
    public override string GetFullClassName() => "Blaze::Association::ListIdentification";

    public string ListName
    {
        get => _listName.Value;
        set => _listName.Value = value;
    }

    public uint ListType
    {
        get => _listType.Value;
        set => _listType.Value = value;
    }

}

