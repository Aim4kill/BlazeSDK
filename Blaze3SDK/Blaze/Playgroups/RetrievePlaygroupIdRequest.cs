using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Playgroups;

public class RetrievePlaygroupIdRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("PlaygroupKey", "mPlaygroupKey", 0xC27AF900, TdfType.String, 0, true), // PGKY
    ];
    private ITdfMember[] __members;

    private TdfString _playgroupKey = new(__typeInfos[0]);

    public RetrievePlaygroupIdRequest()
    {
        __members = [
            _playgroupKey,
        ];
    }

    public override Tdf CreateNew() => new RetrievePlaygroupIdRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "RetrievePlaygroupIdRequest";
    public override string GetFullClassName() => "Blaze::Playgroups::RetrievePlaygroupIdRequest";

    public string PlaygroupKey
    {
        get => _playgroupKey.Value;
        set => _playgroupKey.Value = value;
    }

}

