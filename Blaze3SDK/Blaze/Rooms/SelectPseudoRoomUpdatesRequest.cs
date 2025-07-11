using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Rooms;

public class SelectPseudoRoomUpdatesRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("CategoryId", "mCategoryId", 0x8F4A6400, TdfType.UInt32, 0, true), // CTID
        new TdfMemberInfo("PseudoValue", "mPseudoValue", 0xC3686C00, TdfType.String, 1, true), // PVAL
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _categoryId = new(__typeInfos[0]);
    private TdfString _pseudoValue = new(__typeInfos[1]);

    public SelectPseudoRoomUpdatesRequest()
    {
        __members = [
            _categoryId,
            _pseudoValue,
        ];
    }

    public override Tdf CreateNew() => new SelectPseudoRoomUpdatesRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "SelectPseudoRoomUpdatesRequest";
    public override string GetFullClassName() => "Blaze::Rooms::SelectPseudoRoomUpdatesRequest";

    public uint CategoryId
    {
        get => _categoryId.Value;
        set => _categoryId.Value = value;
    }

    public string PseudoValue
    {
        get => _pseudoValue.Value;
        set => _pseudoValue.Value = value;
    }

}

