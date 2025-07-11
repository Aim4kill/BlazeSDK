using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Association;

public class GetListForUser : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ListName", "mListName", 0x86CBAD00, TdfType.String, 0, true), // ALNM
        new TdfMemberInfo("BlazeId", "mBlazeId", 0x8A990000, TdfType.UInt32, 1, true), // BID
    ];
    private ITdfMember[] __members;

    private TdfString _listName = new(__typeInfos[0]);
    private TdfUInt32 _blazeId = new(__typeInfos[1]);

    public GetListForUser()
    {
        __members = [
            _listName,
            _blazeId,
        ];
    }

    public override Tdf CreateNew() => new GetListForUser();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetListForUser";
    public override string GetFullClassName() => "Blaze::Association::GetListForUser";

    public string ListName
    {
        get => _listName.Value;
        set => _listName.Value = value;
    }

    public uint BlazeId
    {
        get => _blazeId.Value;
        set => _blazeId.Value = value;
    }

}

