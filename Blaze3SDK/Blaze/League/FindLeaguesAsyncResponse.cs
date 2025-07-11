using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.League;

public class FindLeaguesAsyncResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Count", "mCount", 0x8EFBB400, TdfType.UInt32, 0, true), // CONT
        new TdfMemberInfo("SequenceId", "mSequenceId", 0xCF1A6400, TdfType.UInt32, 1, true), // SQID
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _count = new(__typeInfos[0]);
    private TdfUInt32 _sequenceId = new(__typeInfos[1]);

    public FindLeaguesAsyncResponse()
    {
        __members = [
            _count,
            _sequenceId,
        ];
    }

    public override Tdf CreateNew() => new FindLeaguesAsyncResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "FindLeaguesAsyncResponse";
    public override string GetFullClassName() => "Blaze::League::FindLeaguesAsyncResponse";

    public uint Count
    {
        get => _count.Value;
        set => _count.Value = value;
    }

    public uint SequenceId
    {
        get => _sequenceId.Value;
        set => _sequenceId.Value = value;
    }

}

