using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.League;

public class Invitation : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("CreationTime", "mCreationTime", 0x8F2D2D00, TdfType.UInt32, 0, true), // CRTM
        new TdfMemberInfo("Invitee", "mInvitee", 0xA6EDB400, TdfType.Struct, 1, true), // INVT
        new TdfMemberInfo("LeagueId", "mLeagueId", 0xB27A6400, TdfType.UInt32, 2, true), // LGID
        new TdfMemberInfo("Inviter", "mInviter", 0xB65B6200, TdfType.Struct, 3, true), // MEMB
        new TdfMemberInfo("Metadata", "mMetadata", 0xB65D2100, TdfType.Blob, 4, true), // META
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _creationTime = new(__typeInfos[0]);
    private TdfStruct<Blaze3SDK.Blaze.League.LeagueUser?> _invitee = new(__typeInfos[1]);
    private TdfUInt32 _leagueId = new(__typeInfos[2]);
    private TdfStruct<Blaze3SDK.Blaze.League.LeagueUser?> _inviter = new(__typeInfos[3]);
    private TdfBlob _metadata = new(__typeInfos[4]);

    public Invitation()
    {
        __members = [
            _creationTime,
            _invitee,
            _leagueId,
            _inviter,
            _metadata,
        ];
    }

    public override Tdf CreateNew() => new Invitation();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "Invitation";
    public override string GetFullClassName() => "Blaze::League::Invitation";

    public uint CreationTime
    {
        get => _creationTime.Value;
        set => _creationTime.Value = value;
    }

    public Blaze3SDK.Blaze.League.LeagueUser? Invitee
    {
        get => _invitee.Value;
        set => _invitee.Value = value;
    }

    public uint LeagueId
    {
        get => _leagueId.Value;
        set => _leagueId.Value = value;
    }

    public Blaze3SDK.Blaze.League.LeagueUser? Inviter
    {
        get => _inviter.Value;
        set => _inviter.Value = value;
    }

    public byte[] Metadata
    {
        get => _metadata.Value;
        set => _metadata.Value = value;
    }

}

