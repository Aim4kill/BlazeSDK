using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Association;

public class UpdateListMembersResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ListMemberInfoVector", "mListMemberInfoVector", 0xB2DA6400, TdfType.List, 0, true), // LMID
        new TdfMemberInfo("RemovedListMemberIdVector", "mRemovedListMemberIdVector", 0xCA5B4000, TdfType.List, 1, true), // REM
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze3SDK.Blaze.Association.ListMemberInfo> _listMemberInfoVector = new(__typeInfos[0]);
    private TdfList<Blaze3SDK.Blaze.Association.ListMemberId> _removedListMemberIdVector = new(__typeInfos[1]);

    public UpdateListMembersResponse()
    {
        __members = [
            _listMemberInfoVector,
            _removedListMemberIdVector,
        ];
    }

    public override Tdf CreateNew() => new UpdateListMembersResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "UpdateListMembersResponse";
    public override string GetFullClassName() => "Blaze::Association::UpdateListMembersResponse";

    public IList<Blaze3SDK.Blaze.Association.ListMemberInfo> ListMemberInfoVector
    {
        get => _listMemberInfoVector.Value;
        set => _listMemberInfoVector.Value = value;
    }

    public IList<Blaze3SDK.Blaze.Association.ListMemberId> RemovedListMemberIdVector
    {
        get => _removedListMemberIdVector.Value;
        set => _removedListMemberIdVector.Value = value;
    }

}

