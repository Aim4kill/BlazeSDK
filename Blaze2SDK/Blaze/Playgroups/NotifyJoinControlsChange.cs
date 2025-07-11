using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Playgroups;

public class NotifyJoinControlsChange : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("PlaygroupJoinability", "mPlaygroupJoinability", 0xBF096E00, TdfType.Enum, 0, true), // OPEN
        new TdfMemberInfo("PlaygroupId", "mPlaygroupId", 0xC27A6400, TdfType.UInt32, 1, true), // PGID
    ];
    private ITdfMember[] __members;

    private TdfEnum<Blaze2SDK.Blaze.Playgroups.PlaygroupJoinability> _playgroupJoinability = new(__typeInfos[0]);
    private TdfUInt32 _playgroupId = new(__typeInfos[1]);

    public NotifyJoinControlsChange()
    {
        __members = [
            _playgroupJoinability,
            _playgroupId,
        ];
    }

    public override Tdf CreateNew() => new NotifyJoinControlsChange();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "NotifyJoinControlsChange";
    public override string GetFullClassName() => "Blaze::Playgroups::NotifyJoinControlsChange";

    public Blaze2SDK.Blaze.Playgroups.PlaygroupJoinability PlaygroupJoinability
    {
        get => _playgroupJoinability.Value;
        set => _playgroupJoinability.Value = value;
    }

    public uint PlaygroupId
    {
        get => _playgroupId.Value;
        set => _playgroupId.Value = value;
    }

}

