using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.League;

public class FindLeaguesAsyncNotification : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("League", "mLeague", 0xB2586700, TdfType.Struct, 0, true), // LEAG
        new TdfMemberInfo("SequenceId", "mSequenceId", 0xCF1A6400, TdfType.UInt32, 1, true), // SQID
    ];
    private ITdfMember[] __members;

    private TdfStruct<Blaze2SDK.Blaze.League.League?> _league = new(__typeInfos[0]);
    private TdfUInt32 _sequenceId = new(__typeInfos[1]);

    public FindLeaguesAsyncNotification()
    {
        __members = [
            _league,
            _sequenceId,
        ];
    }

    public override Tdf CreateNew() => new FindLeaguesAsyncNotification();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "FindLeaguesAsyncNotification";
    public override string GetFullClassName() => "Blaze::League::FindLeaguesAsyncNotification";

    public Blaze2SDK.Blaze.League.League? League
    {
        get => _league.Value;
        set => _league.Value = value;
    }

    public uint SequenceId
    {
        get => _sequenceId.Value;
        set => _sequenceId.Value = value;
    }

}

