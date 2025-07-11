using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.League;

public class GetInvitationsRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("InvitationsToGet", "mInvitationsToGet", 0xA6EDB400, TdfType.Enum, 0, true), // INVT
        new TdfMemberInfo("LeagueId", "mLeagueId", 0xB27A6400, TdfType.UInt32, 1, true), // LGID
    ];
    private ITdfMember[] __members;

    private TdfEnum<Blaze3SDK.Blaze.League.InvitationsToGetType> _invitationsToGet = new(__typeInfos[0]);
    private TdfUInt32 _leagueId = new(__typeInfos[1]);

    public GetInvitationsRequest()
    {
        __members = [
            _invitationsToGet,
            _leagueId,
        ];
    }

    public override Tdf CreateNew() => new GetInvitationsRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetInvitationsRequest";
    public override string GetFullClassName() => "Blaze::League::GetInvitationsRequest";

    public Blaze3SDK.Blaze.League.InvitationsToGetType InvitationsToGet
    {
        get => _invitationsToGet.Value;
        set => _invitationsToGet.Value = value;
    }

    public uint LeagueId
    {
        get => _leagueId.Value;
        set => _leagueId.Value = value;
    }

}

