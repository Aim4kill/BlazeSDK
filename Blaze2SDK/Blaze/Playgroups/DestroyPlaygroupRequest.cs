using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Playgroups;

public class DestroyPlaygroupRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Id", "mId", 0xC27A6400, TdfType.UInt32, 0, true), // PGID
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _id = new(__typeInfos[0]);

    public DestroyPlaygroupRequest()
    {
        __members = [
            _id,
        ];
    }

    public override Tdf CreateNew() => new DestroyPlaygroupRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "DestroyPlaygroupRequest";
    public override string GetFullClassName() => "Blaze::Playgroups::DestroyPlaygroupRequest";

    public uint Id
    {
        get => _id.Value;
        set => _id.Value = value;
    }

}

