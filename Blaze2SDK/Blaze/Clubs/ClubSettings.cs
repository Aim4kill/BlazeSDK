using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Clubs;

public class ClubSettings : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Abbrev", "mAbbrev", 0x862CB600, TdfType.String, 0, true), // ABRV
        new TdfMemberInfo("ArtPackageType", "mArtPackageType", 0x872C3400, TdfType.Enum, 1, true), // ARPT
        new TdfMemberInfo("BannerId", "mBannerId", 0x8AEA6400, TdfType.UInt32, 2, true), // BNID
        new TdfMemberInfo("ClubArtSettingsFlags", "mClubArtSettingsFlags", 0x8E1CE600, TdfType.Enum, 3, true), // CASF
        new TdfMemberInfo("AcceptanceFlags", "mAcceptanceFlags", 0x8EC86600, TdfType.Enum, 4, true), // CLAF
        new TdfMemberInfo("CustClubSettings", "mCustClubSettings", 0x8EC8F300, TdfType.Struct, 5, true), // CLCS
        new TdfMemberInfo("Description", "mDescription", 0x8EC93300, TdfType.String, 6, true), // CLDS
        new TdfMemberInfo("MetaData", "mMetaData", 0x8ECB6400, TdfType.String, 7, true), // CLMD
        new TdfMemberInfo("MetaDataType", "mMetaDataType", 0x8ECB7400, TdfType.Enum, 8, true), // CLMT
        new TdfMemberInfo("Region", "mRegion", 0x8ECCA700, TdfType.UInt32, 9, true), // CLRG
        new TdfMemberInfo("Language", "mLanguage", 0xB21BA700, TdfType.String, 10, true), // LANG
        new TdfMemberInfo("LogoId", "mLogoId", 0xB2FA6400, TdfType.UInt32, 11, true), // LOID
        new TdfMemberInfo("LastSeasonLevelUpdate", "mLastSeasonLevelUpdate", 0xB35C2400, TdfType.Int32, 12, true), // LUPD
        new TdfMemberInfo("PreviousSeasonLevel", "mPreviousSeasonLevel", 0xC2CDAC00, TdfType.UInt32, 13, true), // PLVL
        new TdfMemberInfo("SeasonLevel", "mSeasonLevel", 0xCECDAC00, TdfType.UInt32, 14, true), // SLVL
        new TdfMemberInfo("TeamId", "mTeamId", 0xD2DA6400, TdfType.UInt32, 15, true), // TMID
    ];
    private ITdfMember[] __members;

    private TdfString _abbrev = new(__typeInfos[0]);
    private TdfEnum<Blaze2SDK.Blaze.Clubs.ArtPackageType> _artPackageType = new(__typeInfos[1]);
    private TdfUInt32 _bannerId = new(__typeInfos[2]);
    private TdfEnum<Blaze2SDK.Blaze.Clubs.ClubArtSettingsFlags> _clubArtSettingsFlags = new(__typeInfos[3]);
    private TdfEnum<Blaze2SDK.Blaze.Clubs.ClubAcceptanceFlags> _acceptanceFlags = new(__typeInfos[4]);
    private TdfStruct<Blaze2SDK.Blaze.Clubs.CustClubSettings?> _custClubSettings = new(__typeInfos[5]);
    private TdfString _description = new(__typeInfos[6]);
    private TdfString _metaData = new(__typeInfos[7]);
    private TdfEnum<Blaze2SDK.Blaze.Clubs.MetaDataType> _metaDataType = new(__typeInfos[8]);
    private TdfUInt32 _region = new(__typeInfos[9]);
    private TdfString _language = new(__typeInfos[10]);
    private TdfUInt32 _logoId = new(__typeInfos[11]);
    private TdfInt32 _lastSeasonLevelUpdate = new(__typeInfos[12]);
    private TdfUInt32 _previousSeasonLevel = new(__typeInfos[13]);
    private TdfUInt32 _seasonLevel = new(__typeInfos[14]);
    private TdfUInt32 _teamId = new(__typeInfos[15]);

    public ClubSettings()
    {
        __members = [
            _abbrev,
            _artPackageType,
            _bannerId,
            _clubArtSettingsFlags,
            _acceptanceFlags,
            _custClubSettings,
            _description,
            _metaData,
            _metaDataType,
            _region,
            _language,
            _logoId,
            _lastSeasonLevelUpdate,
            _previousSeasonLevel,
            _seasonLevel,
            _teamId,
        ];
    }

    public override Tdf CreateNew() => new ClubSettings();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ClubSettings";
    public override string GetFullClassName() => "Blaze::Clubs::ClubSettings";

    public string Abbrev
    {
        get => _abbrev.Value;
        set => _abbrev.Value = value;
    }

    public Blaze2SDK.Blaze.Clubs.ArtPackageType ArtPackageType
    {
        get => _artPackageType.Value;
        set => _artPackageType.Value = value;
    }

    public uint BannerId
    {
        get => _bannerId.Value;
        set => _bannerId.Value = value;
    }

    public Blaze2SDK.Blaze.Clubs.ClubArtSettingsFlags ClubArtSettingsFlags
    {
        get => _clubArtSettingsFlags.Value;
        set => _clubArtSettingsFlags.Value = value;
    }

    public Blaze2SDK.Blaze.Clubs.ClubAcceptanceFlags AcceptanceFlags
    {
        get => _acceptanceFlags.Value;
        set => _acceptanceFlags.Value = value;
    }

    public Blaze2SDK.Blaze.Clubs.CustClubSettings? CustClubSettings
    {
        get => _custClubSettings.Value;
        set => _custClubSettings.Value = value;
    }

    public string Description
    {
        get => _description.Value;
        set => _description.Value = value;
    }

    public string MetaData
    {
        get => _metaData.Value;
        set => _metaData.Value = value;
    }

    public Blaze2SDK.Blaze.Clubs.MetaDataType MetaDataType
    {
        get => _metaDataType.Value;
        set => _metaDataType.Value = value;
    }

    public uint Region
    {
        get => _region.Value;
        set => _region.Value = value;
    }

    public string Language
    {
        get => _language.Value;
        set => _language.Value = value;
    }

    public uint LogoId
    {
        get => _logoId.Value;
        set => _logoId.Value = value;
    }

    public int LastSeasonLevelUpdate
    {
        get => _lastSeasonLevelUpdate.Value;
        set => _lastSeasonLevelUpdate.Value = value;
    }

    public uint PreviousSeasonLevel
    {
        get => _previousSeasonLevel.Value;
        set => _previousSeasonLevel.Value = value;
    }

    public uint SeasonLevel
    {
        get => _seasonLevel.Value;
        set => _seasonLevel.Value = value;
    }

    public uint TeamId
    {
        get => _teamId.Value;
        set => _teamId.Value = value;
    }

}

