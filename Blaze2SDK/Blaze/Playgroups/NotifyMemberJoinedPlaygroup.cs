using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Playgroups;

public class NotifyMemberJoinedPlaygroup : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("PlaygroupMemberInfo", "mPlaygroupMemberInfo", 0xB65B6200, TdfType.Struct, 0, true), // MEMB
        new TdfMemberInfo("PlaygroupId", "mPlaygroupId", 0xC27A6400, TdfType.UInt32, 1, true), // PGID
    ];
    private ITdfMember[] __members;

    private TdfStruct<Blaze2SDK.Blaze.Playgroups.PlaygroupMemberInfo?> _playgroupMemberInfo = new(__typeInfos[0]);
    private TdfUInt32 _playgroupId = new(__typeInfos[1]);

    public NotifyMemberJoinedPlaygroup()
    {
        __members = [
            _playgroupMemberInfo,
            _playgroupId,
        ];
    }

    public override Tdf CreateNew() => new NotifyMemberJoinedPlaygroup();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "NotifyMemberJoinedPlaygroup";
    public override string GetFullClassName() => "Blaze::Playgroups::NotifyMemberJoinedPlaygroup";

    public Blaze2SDK.Blaze.Playgroups.PlaygroupMemberInfo? PlaygroupMemberInfo
    {
        get => _playgroupMemberInfo.Value;
        set => _playgroupMemberInfo.Value = value;
    }

    public uint PlaygroupId
    {
        get => _playgroupId.Value;
        set => _playgroupId.Value = value;
    }

}

