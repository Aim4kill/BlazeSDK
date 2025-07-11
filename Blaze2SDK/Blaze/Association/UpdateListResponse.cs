using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Association;

public class UpdateListResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ListMemberInfoVector", "mListMemberInfoVector", 0x8A992C00, TdfType.List, 0, true), // BIDL
        new TdfMemberInfo("ListRemovedMemberInfoVector", "mListRemovedMemberInfoVector", 0xCA292C00, TdfType.List, 1, true), // RBDL
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze2SDK.Blaze.Association.ListMemberInfo> _listMemberInfoVector = new(__typeInfos[0]);
    private TdfList<Blaze2SDK.Blaze.Association.ListMemberInfo> _listRemovedMemberInfoVector = new(__typeInfos[1]);

    public UpdateListResponse()
    {
        __members = [
            _listMemberInfoVector,
            _listRemovedMemberInfoVector,
        ];
    }

    public override Tdf CreateNew() => new UpdateListResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "UpdateListResponse";
    public override string GetFullClassName() => "Blaze::Association::UpdateListResponse";

    public IList<Blaze2SDK.Blaze.Association.ListMemberInfo> ListMemberInfoVector
    {
        get => _listMemberInfoVector.Value;
        set => _listMemberInfoVector.Value = value;
    }

    public IList<Blaze2SDK.Blaze.Association.ListMemberInfo> ListRemovedMemberInfoVector
    {
        get => _listRemovedMemberInfoVector.Value;
        set => _listRemovedMemberInfoVector.Value = value;
    }

}

