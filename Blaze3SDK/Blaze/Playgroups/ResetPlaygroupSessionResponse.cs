using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Playgroups;

public class ResetPlaygroupSessionResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Id", "mId", 0xC27A6400, TdfType.UInt32, 0, true), // PGID
        new TdfMemberInfo("SessionChanging", "mSessionChanging", 0xC3297300, TdfType.Bool, 1, true), // PRES
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _id = new(__typeInfos[0]);
    private TdfBool _sessionChanging = new(__typeInfos[1]);

    public ResetPlaygroupSessionResponse()
    {
        __members = [
            _id,
            _sessionChanging,
        ];
    }

    public override Tdf CreateNew() => new ResetPlaygroupSessionResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ResetPlaygroupSessionResponse";
    public override string GetFullClassName() => "Blaze::Playgroups::ResetPlaygroupSessionResponse";

    public uint Id
    {
        get => _id.Value;
        set => _id.Value = value;
    }

    public bool SessionChanging
    {
        get => _sessionChanging.Value;
        set => _sessionChanging.Value = value;
    }

}

