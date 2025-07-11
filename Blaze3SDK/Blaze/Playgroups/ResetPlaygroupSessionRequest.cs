using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Playgroups;

public class ResetPlaygroupSessionRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Id", "mId", 0xC27A6400, TdfType.UInt32, 0, true), // PGID
        new TdfMemberInfo("UsesPresence", "mUsesPresence", 0xC3297300, TdfType.Bool, 1, true), // PRES
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _id = new(__typeInfos[0]);
    private TdfBool _usesPresence = new(__typeInfos[1]);

    public ResetPlaygroupSessionRequest()
    {
        __members = [
            _id,
            _usesPresence,
        ];
    }

    public override Tdf CreateNew() => new ResetPlaygroupSessionRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ResetPlaygroupSessionRequest";
    public override string GetFullClassName() => "Blaze::Playgroups::ResetPlaygroupSessionRequest";

    public uint Id
    {
        get => _id.Value;
        set => _id.Value = value;
    }

    public bool UsesPresence
    {
        get => _usesPresence.Value;
        set => _usesPresence.Value = value;
    }

}

