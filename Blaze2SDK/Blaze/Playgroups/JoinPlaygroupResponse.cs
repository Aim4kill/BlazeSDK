using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Playgroups;

public class JoinPlaygroupResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("PlaygroupInfo", "mPlaygroupInfo", 0xA6E9AF00, TdfType.Struct, 0, true), // INFO
    ];
    private ITdfMember[] __members;

    private TdfStruct<Blaze2SDK.Blaze.Playgroups.PlaygroupInfo?> _playgroupInfo = new(__typeInfos[0]);

    public JoinPlaygroupResponse()
    {
        __members = [
            _playgroupInfo,
        ];
    }

    public override Tdf CreateNew() => new JoinPlaygroupResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "JoinPlaygroupResponse";
    public override string GetFullClassName() => "Blaze::Playgroups::JoinPlaygroupResponse";

    public Blaze2SDK.Blaze.Playgroups.PlaygroupInfo? PlaygroupInfo
    {
        get => _playgroupInfo.Value;
        set => _playgroupInfo.Value = value;
    }

}

