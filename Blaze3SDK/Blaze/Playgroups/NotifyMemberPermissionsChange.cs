using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Playgroups;

public class NotifyMemberPermissionsChange : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("BlazeId", "mBlazeId", 0xB2990000, TdfType.Int64, 0, true), // LID
        new TdfMemberInfo("Permissions", "mPermissions", 0xC25CAD00, TdfType.Enum, 1, true), // PERM
        new TdfMemberInfo("PlaygroupId", "mPlaygroupId", 0xC27A6400, TdfType.UInt32, 2, true), // PGID
    ];
    private ITdfMember[] __members;

    private TdfInt64 _blazeId = new(__typeInfos[0]);
    private TdfEnum<Blaze3SDK.Blaze.Playgroups.MemberPermissions> _permissions = new(__typeInfos[1]);
    private TdfUInt32 _playgroupId = new(__typeInfos[2]);

    public NotifyMemberPermissionsChange()
    {
        __members = [
            _blazeId,
            _permissions,
            _playgroupId,
        ];
    }

    public override Tdf CreateNew() => new NotifyMemberPermissionsChange();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "NotifyMemberPermissionsChange";
    public override string GetFullClassName() => "Blaze::Playgroups::NotifyMemberPermissionsChange";

    public long BlazeId
    {
        get => _blazeId.Value;
        set => _blazeId.Value = value;
    }

    public Blaze3SDK.Blaze.Playgroups.MemberPermissions Permissions
    {
        get => _permissions.Value;
        set => _permissions.Value = value;
    }

    public uint PlaygroupId
    {
        get => _playgroupId.Value;
        set => _playgroupId.Value = value;
    }

}

