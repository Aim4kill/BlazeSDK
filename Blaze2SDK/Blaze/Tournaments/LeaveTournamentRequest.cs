using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Tournaments;

public class LeaveTournamentRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Id", "mId", 0xD2EA6400, TdfType.UInt32, 0, true), // TNID
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _id = new(__typeInfos[0]);

    public LeaveTournamentRequest()
    {
        __members = [
            _id,
        ];
    }

    public override Tdf CreateNew() => new LeaveTournamentRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "LeaveTournamentRequest";
    public override string GetFullClassName() => "Blaze::Tournaments::LeaveTournamentRequest";

    public uint Id
    {
        get => _id.Value;
        set => _id.Value = value;
    }

}

