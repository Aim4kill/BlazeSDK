using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Playgroups;

public class NotifyMemberRemoveFromPlaygroup : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("BlazeId", "mBlazeId", 0xB6CCF400, TdfType.Int64, 0, true), // MLST
        new TdfMemberInfo("PlaygroupId", "mPlaygroupId", 0xC27A6400, TdfType.UInt32, 1, true), // PGID
        new TdfMemberInfo("Reason", "mReason", 0xCA587300, TdfType.Enum, 2, true), // REAS
    ];
    private ITdfMember[] __members;

    private TdfInt64 _blazeId = new(__typeInfos[0]);
    private TdfUInt32 _playgroupId = new(__typeInfos[1]);
    private TdfEnum<Blaze3SDK.Blaze.Playgroups.PlaygroupMemberRemoveReason> _reason = new(__typeInfos[2]);

    public NotifyMemberRemoveFromPlaygroup()
    {
        __members = [
            _blazeId,
            _playgroupId,
            _reason,
        ];
    }

    public override Tdf CreateNew() => new NotifyMemberRemoveFromPlaygroup();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "NotifyMemberRemoveFromPlaygroup";
    public override string GetFullClassName() => "Blaze::Playgroups::NotifyMemberRemoveFromPlaygroup";

    public long BlazeId
    {
        get => _blazeId.Value;
        set => _blazeId.Value = value;
    }

    public uint PlaygroupId
    {
        get => _playgroupId.Value;
        set => _playgroupId.Value = value;
    }

    public Blaze3SDK.Blaze.Playgroups.PlaygroupMemberRemoveReason Reason
    {
        get => _reason.Value;
        set => _reason.Value = value;
    }

}

