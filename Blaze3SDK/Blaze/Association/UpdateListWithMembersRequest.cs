using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Association;

public class UpdateListWithMembersRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ListMemberInfoVector", "mListMemberInfoVector", 0x8A992C00, TdfType.List, 0, true), // BIDL
        new TdfMemberInfo("ListIdentification", "mListIdentification", 0xB2990000, TdfType.Struct, 1, true), // LID
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze3SDK.Blaze.Association.ListMemberInfoUpdate> _listMemberInfoVector = new(__typeInfos[0]);
    private TdfStruct<Blaze3SDK.Blaze.Association.ListIdentification?> _listIdentification = new(__typeInfos[1]);

    public UpdateListWithMembersRequest()
    {
        __members = [
            _listMemberInfoVector,
            _listIdentification,
        ];
    }

    public override Tdf CreateNew() => new UpdateListWithMembersRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "UpdateListWithMembersRequest";
    public override string GetFullClassName() => "Blaze::Association::UpdateListWithMembersRequest";

    public IList<Blaze3SDK.Blaze.Association.ListMemberInfoUpdate> ListMemberInfoVector
    {
        get => _listMemberInfoVector.Value;
        set => _listMemberInfoVector.Value = value;
    }

    public Blaze3SDK.Blaze.Association.ListIdentification? ListIdentification
    {
        get => _listIdentification.Value;
        set => _listIdentification.Value = value;
    }

}

