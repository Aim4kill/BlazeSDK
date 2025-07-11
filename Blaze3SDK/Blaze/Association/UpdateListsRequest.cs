using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Association;

public class UpdateListsRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ListIdentificationVector", "mListIdentificationVector", 0xB2993300, TdfType.List, 0, true), // LIDS
        new TdfMemberInfo("MutualAction", "mMutualAction", 0xB75D2100, TdfType.Bool, 1, true), // MUTA
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze3SDK.Blaze.Association.ListIdentification> _listIdentificationVector = new(__typeInfos[0]);
    private TdfBool _mutualAction = new(__typeInfos[1]);

    public UpdateListsRequest()
    {
        __members = [
            _listIdentificationVector,
            _mutualAction,
        ];
    }

    public override Tdf CreateNew() => new UpdateListsRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "UpdateListsRequest";
    public override string GetFullClassName() => "Blaze::Association::UpdateListsRequest";

    public IList<Blaze3SDK.Blaze.Association.ListIdentification> ListIdentificationVector
    {
        get => _listIdentificationVector.Value;
        set => _listIdentificationVector.Value = value;
    }

    public bool MutualAction
    {
        get => _mutualAction.Value;
        set => _mutualAction.Value = value;
    }

}

