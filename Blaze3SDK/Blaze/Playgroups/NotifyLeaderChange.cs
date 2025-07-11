using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Playgroups;

public class NotifyLeaderChange : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("NewHostSlotId", "mNewHostSlotId", 0xA33A6400, TdfType.UInt8, 0, true), // HSID
        new TdfMemberInfo("NewLeaderId", "mNewLeaderId", 0xB2990000, TdfType.Int64, 1, true), // LID
        new TdfMemberInfo("PlaygroupId", "mPlaygroupId", 0xC27A6400, TdfType.UInt32, 2, true), // PGID
    ];
    private ITdfMember[] __members;

    private TdfUInt8 _newHostSlotId = new(__typeInfos[0]);
    private TdfInt64 _newLeaderId = new(__typeInfos[1]);
    private TdfUInt32 _playgroupId = new(__typeInfos[2]);

    public NotifyLeaderChange()
    {
        __members = [
            _newHostSlotId,
            _newLeaderId,
            _playgroupId,
        ];
    }

    public override Tdf CreateNew() => new NotifyLeaderChange();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "NotifyLeaderChange";
    public override string GetFullClassName() => "Blaze::Playgroups::NotifyLeaderChange";

    public byte NewHostSlotId
    {
        get => _newHostSlotId.Value;
        set => _newHostSlotId.Value = value;
    }

    public long NewLeaderId
    {
        get => _newLeaderId.Value;
        set => _newLeaderId.Value = value;
    }

    public uint PlaygroupId
    {
        get => _playgroupId.Value;
        set => _playgroupId.Value = value;
    }

}

