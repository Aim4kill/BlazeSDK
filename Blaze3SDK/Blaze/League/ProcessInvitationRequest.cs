using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.League;

public class ProcessInvitationRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("InviterId", "mInviterId", 0xA6EDB200, TdfType.Int64, 0, true), // INVR
        new TdfMemberInfo("InviteeId", "mInviteeId", 0xA6EDB400, TdfType.Int64, 1, true), // INVT
        new TdfMemberInfo("LeagueId", "mLeagueId", 0xB27A6400, TdfType.UInt32, 2, true), // LGID
        new TdfMemberInfo("Operation", "mOperation", 0xBF097200, TdfType.Enum, 3, true), // OPER
    ];
    private ITdfMember[] __members;

    private TdfInt64 _inviterId = new(__typeInfos[0]);
    private TdfInt64 _inviteeId = new(__typeInfos[1]);
    private TdfUInt32 _leagueId = new(__typeInfos[2]);
    private TdfEnum<Blaze3SDK.Blaze.League.InvitationOp> _operation = new(__typeInfos[3]);

    public ProcessInvitationRequest()
    {
        __members = [
            _inviterId,
            _inviteeId,
            _leagueId,
            _operation,
        ];
    }

    public override Tdf CreateNew() => new ProcessInvitationRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ProcessInvitationRequest";
    public override string GetFullClassName() => "Blaze::League::ProcessInvitationRequest";

    public long InviterId
    {
        get => _inviterId.Value;
        set => _inviterId.Value = value;
    }

    public long InviteeId
    {
        get => _inviteeId.Value;
        set => _inviteeId.Value = value;
    }

    public uint LeagueId
    {
        get => _leagueId.Value;
        set => _leagueId.Value = value;
    }

    public Blaze3SDK.Blaze.League.InvitationOp Operation
    {
        get => _operation.Value;
        set => _operation.Value = value;
    }

}

