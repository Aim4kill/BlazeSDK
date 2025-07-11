using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.DynamicInetFilter;

public class ReplicatedInetFilterReplicationReason : Tdf
{
    public enum Reason : int
    {
        MAP_CREATED = 0,
        MAP_DESTROYED = 1,
        OBJECT_CREATED = 2,
        OBJECT_UPDATED = 3,
        OBJECT_DESTROYED = 4,
    }
    
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Reason", "mReason", 0xCB3B8000, TdfType.Enum, 0, true), // RSN
    ];
    private ITdfMember[] __members;

    private TdfEnum<Blaze3SDK.Blaze.DynamicInetFilter.ReplicatedInetFilterReplicationReason.Reason> _reason = new(__typeInfos[0]);

    public ReplicatedInetFilterReplicationReason()
    {
        __members = [
            _reason,
        ];
    }

    public override Tdf CreateNew() => new ReplicatedInetFilterReplicationReason();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ReplicatedInetFilterReplicationReason";
    public override string GetFullClassName() => "Blaze::DynamicInetFilter::ReplicatedInetFilterReplicationReason";

    public Blaze3SDK.Blaze.DynamicInetFilter.ReplicatedInetFilterReplicationReason.Reason mReason
    {
        get => _reason.Value;
        set => _reason.Value = value;
    }

}

