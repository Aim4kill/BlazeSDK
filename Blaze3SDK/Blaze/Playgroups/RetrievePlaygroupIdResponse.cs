using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Playgroups;

public class RetrievePlaygroupIdResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("PlaygroupId", "mPlaygroupId", 0xC27A6400, TdfType.UInt32, 0, true), // PGID
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _playgroupId = new(__typeInfos[0]);

    public RetrievePlaygroupIdResponse()
    {
        __members = [
            _playgroupId,
        ];
    }

    public override Tdf CreateNew() => new RetrievePlaygroupIdResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "RetrievePlaygroupIdResponse";
    public override string GetFullClassName() => "Blaze::Playgroups::RetrievePlaygroupIdResponse";

    public uint PlaygroupId
    {
        get => _playgroupId.Value;
        set => _playgroupId.Value = value;
    }

}

