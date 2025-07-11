using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Association;

public class UpdateListMembersRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ListMemberIdVector", "mListMemberIdVector", 0x8A992C00, TdfType.List, 0, true), // BIDL
        new TdfMemberInfo("ListIdentification", "mListIdentification", 0xB2990000, TdfType.Struct, 1, true), // LID
        new TdfMemberInfo("MutualAction", "mMutualAction", 0xB75D2100, TdfType.Bool, 2, true), // MUTA
        new TdfMemberInfo("ValidateAdd", "mValidateAdd", 0xDA1B2100, TdfType.Bool, 3, true), // VALA
        new TdfMemberInfo("ValidateDelete", "mValidateDelete", 0xDA1B2400, TdfType.Bool, 4, true), // VALD
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze3SDK.Blaze.Association.ListMemberId> _listMemberIdVector = new(__typeInfos[0]);
    private TdfStruct<Blaze3SDK.Blaze.Association.ListIdentification?> _listIdentification = new(__typeInfos[1]);
    private TdfBool _mutualAction = new(__typeInfos[2]);
    private TdfBool _validateAdd = new(__typeInfos[3]);
    private TdfBool _validateDelete = new(__typeInfos[4]);

    public UpdateListMembersRequest()
    {
        __members = [
            _listMemberIdVector,
            _listIdentification,
            _mutualAction,
            _validateAdd,
            _validateDelete,
        ];
    }

    public override Tdf CreateNew() => new UpdateListMembersRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "UpdateListMembersRequest";
    public override string GetFullClassName() => "Blaze::Association::UpdateListMembersRequest";

    public IList<Blaze3SDK.Blaze.Association.ListMemberId> ListMemberIdVector
    {
        get => _listMemberIdVector.Value;
        set => _listMemberIdVector.Value = value;
    }

    public Blaze3SDK.Blaze.Association.ListIdentification? ListIdentification
    {
        get => _listIdentification.Value;
        set => _listIdentification.Value = value;
    }

    public bool MutualAction
    {
        get => _mutualAction.Value;
        set => _mutualAction.Value = value;
    }

    public bool ValidateAdd
    {
        get => _validateAdd.Value;
        set => _validateAdd.Value = value;
    }

    public bool ValidateDelete
    {
        get => _validateDelete.Value;
        set => _validateDelete.Value = value;
    }

}

