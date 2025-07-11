using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.League;

public class SendInvitationRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("InviteeId", "mInviteeId", 0xA6EDB400, TdfType.Int64, 0, true), // INVT
        new TdfMemberInfo("LeagueId", "mLeagueId", 0xB27A6400, TdfType.UInt32, 1, true), // LGID
        new TdfMemberInfo("Metadata", "mMetadata", 0xB65D2100, TdfType.Blob, 2, true), // META
    ];
    private ITdfMember[] __members;

    private TdfInt64 _inviteeId = new(__typeInfos[0]);
    private TdfUInt32 _leagueId = new(__typeInfos[1]);
    private TdfBlob _metadata = new(__typeInfos[2]);

    public SendInvitationRequest()
    {
        __members = [
            _inviteeId,
            _leagueId,
            _metadata,
        ];
    }

    public override Tdf CreateNew() => new SendInvitationRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "SendInvitationRequest";
    public override string GetFullClassName() => "Blaze::League::SendInvitationRequest";

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

    public byte[] Metadata
    {
        get => _metadata.Value;
        set => _metadata.Value = value;
    }

}

