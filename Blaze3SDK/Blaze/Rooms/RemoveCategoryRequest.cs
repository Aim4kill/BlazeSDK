using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Rooms;

public class RemoveCategoryRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("CategoryId", "mCategoryId", 0x8F4A6400, TdfType.UInt32, 0, true), // CTID
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _categoryId = new(__typeInfos[0]);

    public RemoveCategoryRequest()
    {
        __members = [
            _categoryId,
        ];
    }

    public override Tdf CreateNew() => new RemoveCategoryRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "RemoveCategoryRequest";
    public override string GetFullClassName() => "Blaze::Rooms::RemoveCategoryRequest";

    public uint CategoryId
    {
        get => _categoryId.Value;
        set => _categoryId.Value = value;
    }

}

