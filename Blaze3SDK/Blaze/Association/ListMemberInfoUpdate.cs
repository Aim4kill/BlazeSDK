using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Association;

public class ListMemberInfoUpdate : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ListMemberInfo", "mListMemberInfo", 0xB2DA6400, TdfType.Struct, 0, true), // LMID
        new TdfMemberInfo("ListUpdateType", "mListUpdateType", 0xB35C3400, TdfType.Enum, 1, true), // LUPT
    ];
    private ITdfMember[] __members;

    private TdfStruct<Blaze3SDK.Blaze.Association.ListMemberInfo?> _listMemberInfo = new(__typeInfos[0]);
    private TdfEnum<Blaze3SDK.Blaze.Association.ListUpdateType> _listUpdateType = new(__typeInfos[1]);

    public ListMemberInfoUpdate()
    {
        __members = [
            _listMemberInfo,
            _listUpdateType,
        ];
    }

    public override Tdf CreateNew() => new ListMemberInfoUpdate();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ListMemberInfoUpdate";
    public override string GetFullClassName() => "Blaze::Association::ListMemberInfoUpdate";

    public Blaze3SDK.Blaze.Association.ListMemberInfo? ListMemberInfo
    {
        get => _listMemberInfo.Value;
        set => _listMemberInfo.Value = value;
    }

    public Blaze3SDK.Blaze.Association.ListUpdateType ListUpdateType
    {
        get => _listUpdateType.Value;
        set => _listUpdateType.Value = value;
    }

}

