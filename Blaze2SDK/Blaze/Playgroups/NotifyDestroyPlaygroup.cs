using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Playgroups;

public class NotifyDestroyPlaygroup : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Id", "mId", 0xC27A6400, TdfType.UInt32, 0, true), // PGID
        new TdfMemberInfo("Reason", "mReason", 0xCA587300, TdfType.Enum, 1, true), // REAS
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _id = new(__typeInfos[0]);
    private TdfEnum<Blaze2SDK.Blaze.Playgroups.PlaygroupDestroyReason> _reason = new(__typeInfos[1]);

    public NotifyDestroyPlaygroup()
    {
        __members = [
            _id,
            _reason,
        ];
    }

    public override Tdf CreateNew() => new NotifyDestroyPlaygroup();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "NotifyDestroyPlaygroup";
    public override string GetFullClassName() => "Blaze::Playgroups::NotifyDestroyPlaygroup";

    public uint Id
    {
        get => _id.Value;
        set => _id.Value = value;
    }

    public Blaze2SDK.Blaze.Playgroups.PlaygroupDestroyReason Reason
    {
        get => _reason.Value;
        set => _reason.Value = value;
    }

}

