using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.League;

public class SetMetadataRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("RosterCrc", "mRosterCrc", 0x8F28C000, TdfType.UInt32, 0, true), // CRC
        new TdfMemberInfo("MemberId", "mMemberId", 0x9EDA6400, TdfType.UInt32, 1, true), // GMID
        new TdfMemberInfo("LeagueId", "mLeagueId", 0xB27A6400, TdfType.UInt32, 2, true), // LGID
        new TdfMemberInfo("Metadata", "mMetadata", 0xB65D2100, TdfType.Blob, 3, true), // META
        new TdfMemberInfo("IsStringMetadata", "mIsStringMetadata", 0xCED97400, TdfType.UInt8, 4, true), // SMET
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _rosterCrc = new(__typeInfos[0]);
    private TdfUInt32 _memberId = new(__typeInfos[1]);
    private TdfUInt32 _leagueId = new(__typeInfos[2]);
    private TdfBlob _metadata = new(__typeInfos[3]);
    private TdfUInt8 _isStringMetadata = new(__typeInfos[4]);

    public SetMetadataRequest()
    {
        __members = [
            _rosterCrc,
            _memberId,
            _leagueId,
            _metadata,
            _isStringMetadata,
        ];
    }

    public override Tdf CreateNew() => new SetMetadataRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "SetMetadataRequest";
    public override string GetFullClassName() => "Blaze::League::SetMetadataRequest";

    public uint RosterCrc
    {
        get => _rosterCrc.Value;
        set => _rosterCrc.Value = value;
    }

    public uint MemberId
    {
        get => _memberId.Value;
        set => _memberId.Value = value;
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

    public byte IsStringMetadata
    {
        get => _isStringMetadata.Value;
        set => _isStringMetadata.Value = value;
    }

}

