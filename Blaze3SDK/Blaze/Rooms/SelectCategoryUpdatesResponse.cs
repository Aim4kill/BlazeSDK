using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Rooms;

public class SelectCategoryUpdatesResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ViewId", "mViewId", 0xDB7A6400, TdfType.UInt32, 0, true), // VWID
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _viewId = new(__typeInfos[0]);

    public SelectCategoryUpdatesResponse()
    {
        __members = [
            _viewId,
        ];
    }

    public override Tdf CreateNew() => new SelectCategoryUpdatesResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "SelectCategoryUpdatesResponse";
    public override string GetFullClassName() => "Blaze::Rooms::SelectCategoryUpdatesResponse";

    public uint ViewId
    {
        get => _viewId.Value;
        set => _viewId.Value = value;
    }

}

