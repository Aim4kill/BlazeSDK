using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Playgroups;

public class LookupPlaygroupInfoList : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("PlaygroupInfoList", "mPlaygroupInfoList", 0xC27C3300, TdfType.List, 0, true), // PGPS
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze2SDK.Blaze.Playgroups.PlaygroupInfo> _playgroupInfoList = new(__typeInfos[0]);

    public LookupPlaygroupInfoList()
    {
        __members = [
            _playgroupInfoList,
        ];
    }

    public override Tdf CreateNew() => new LookupPlaygroupInfoList();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "LookupPlaygroupInfoList";
    public override string GetFullClassName() => "Blaze::Playgroups::LookupPlaygroupInfoList";

    public IList<Blaze2SDK.Blaze.Playgroups.PlaygroupInfo> PlaygroupInfoList
    {
        get => _playgroupInfoList.Value;
        set => _playgroupInfoList.Value = value;
    }

}

