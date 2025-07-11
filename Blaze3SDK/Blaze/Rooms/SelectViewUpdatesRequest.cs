using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Rooms;

public class SelectViewUpdatesRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Updates", "mUpdates", 0xD7093400, TdfType.UInt32, 0, true), // UPDT
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _updates = new(__typeInfos[0]);

    public SelectViewUpdatesRequest()
    {
        __members = [
            _updates,
        ];
    }

    public override Tdf CreateNew() => new SelectViewUpdatesRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "SelectViewUpdatesRequest";
    public override string GetFullClassName() => "Blaze::Rooms::SelectViewUpdatesRequest";

    public uint Updates
    {
        get => _updates.Value;
        set => _updates.Value = value;
    }

}

