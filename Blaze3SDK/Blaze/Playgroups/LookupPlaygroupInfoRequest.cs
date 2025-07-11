using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Playgroups;

public class LookupPlaygroupInfoRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("PlaygroupIdList", "mPlaygroupIdList", 0xC2CCF400, TdfType.List, 0, true), // PLST
    ];
    private ITdfMember[] __members;

    private TdfList<uint> _playgroupIdList = new(__typeInfos[0]);

    public LookupPlaygroupInfoRequest()
    {
        __members = [
            _playgroupIdList,
        ];
    }

    public override Tdf CreateNew() => new LookupPlaygroupInfoRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "LookupPlaygroupInfoRequest";
    public override string GetFullClassName() => "Blaze::Playgroups::LookupPlaygroupInfoRequest";

    public IList<uint> PlaygroupIdList
    {
        get => _playgroupIdList.Value;
        set => _playgroupIdList.Value = value;
    }

}

