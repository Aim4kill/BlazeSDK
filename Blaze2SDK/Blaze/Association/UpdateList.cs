using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Association;

public class UpdateList : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ListName", "mListName", 0x86CBAD00, TdfType.String, 0, true), // ALNM
        new TdfMemberInfo("UserListMemberIdList", "mUserListMemberIdList", 0x8A992C00, TdfType.List, 1, true), // BIDL
    ];
    private ITdfMember[] __members;

    private TdfString _listName = new(__typeInfos[0]);
    private TdfList<Blaze2SDK.Blaze.Association.ListMemberId> _userListMemberIdList = new(__typeInfos[1]);

    public UpdateList()
    {
        __members = [
            _listName,
            _userListMemberIdList,
        ];
    }

    public override Tdf CreateNew() => new UpdateList();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "UpdateList";
    public override string GetFullClassName() => "Blaze::Association::UpdateList";

    public string ListName
    {
        get => _listName.Value;
        set => _listName.Value = value;
    }

    public IList<Blaze2SDK.Blaze.Association.ListMemberId> UserListMemberIdList
    {
        get => _userListMemberIdList.Value;
        set => _userListMemberIdList.Value = value;
    }

}

