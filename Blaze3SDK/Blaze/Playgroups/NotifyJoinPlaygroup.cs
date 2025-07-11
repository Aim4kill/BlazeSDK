using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Playgroups;

public class NotifyJoinPlaygroup : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("PlaygroupInfo", "mPlaygroupInfo", 0xA6E9AF00, TdfType.Struct, 0, true), // INFO
        new TdfMemberInfo("PlaygroupMemberInfos", "mPlaygroupMemberInfos", 0xB6CCF400, TdfType.List, 1, true), // MLST
        new TdfMemberInfo("JoiningBlazeId", "mJoiningBlazeId", 0xD7397200, TdfType.Int64, 2, true), // USER
    ];
    private ITdfMember[] __members;

    private TdfStruct<Blaze3SDK.Blaze.Playgroups.PlaygroupInfo?> _playgroupInfo = new(__typeInfos[0]);
    private TdfList<Blaze3SDK.Blaze.Playgroups.PlaygroupMemberInfo> _playgroupMemberInfos = new(__typeInfos[1]);
    private TdfInt64 _joiningBlazeId = new(__typeInfos[2]);

    public NotifyJoinPlaygroup()
    {
        __members = [
            _playgroupInfo,
            _playgroupMemberInfos,
            _joiningBlazeId,
        ];
    }

    public override Tdf CreateNew() => new NotifyJoinPlaygroup();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "NotifyJoinPlaygroup";
    public override string GetFullClassName() => "Blaze::Playgroups::NotifyJoinPlaygroup";

    public Blaze3SDK.Blaze.Playgroups.PlaygroupInfo? PlaygroupInfo
    {
        get => _playgroupInfo.Value;
        set => _playgroupInfo.Value = value;
    }

    public IList<Blaze3SDK.Blaze.Playgroups.PlaygroupMemberInfo> PlaygroupMemberInfos
    {
        get => _playgroupMemberInfos.Value;
        set => _playgroupMemberInfos.Value = value;
    }

    public long JoiningBlazeId
    {
        get => _joiningBlazeId.Value;
        set => _joiningBlazeId.Value = value;
    }

}

