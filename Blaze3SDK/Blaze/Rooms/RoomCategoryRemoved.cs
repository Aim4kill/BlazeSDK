using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Rooms;

public class RoomCategoryRemoved : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("CategoryId", "mCategoryId", 0x8F4A6400, TdfType.UInt32, 0, true), // CTID
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _categoryId = new(__typeInfos[0]);

    public RoomCategoryRemoved()
    {
        __members = [
            _categoryId,
        ];
    }

    public override Tdf CreateNew() => new RoomCategoryRemoved();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "RoomCategoryRemoved";
    public override string GetFullClassName() => "Blaze::Rooms::RoomCategoryRemoved";

    public uint CategoryId
    {
        get => _categoryId.Value;
        set => _categoryId.Value = value;
    }

}

