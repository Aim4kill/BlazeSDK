using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Clubs;

public class ReplicationContext : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("UpdateReason", "mUpdateReason", 0x8F5CA500, TdfType.Enum, 0, true), // CURE
    ];
    private ITdfMember[] __members;

    private TdfEnum<Blaze3SDK.Blaze.Clubs.UpdateReason> _updateReason = new(__typeInfos[0]);

    public ReplicationContext()
    {
        __members = [
            _updateReason,
        ];
    }

    public override Tdf CreateNew() => new ReplicationContext();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ReplicationContext";
    public override string GetFullClassName() => "Blaze::Clubs::ReplicationContext";

    public Blaze3SDK.Blaze.Clubs.UpdateReason UpdateReason
    {
        get => _updateReason.Value;
        set => _updateReason.Value = value;
    }

}

