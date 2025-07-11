using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.League;

public class UpdateLeagueSettingsRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Abbrev", "mAbbrev", 0x8628B200, TdfType.String, 0, true), // ABBR
        new TdfMemberInfo("Description", "mDescription", 0x925CE300, TdfType.String, 1, true), // DESC
        new TdfMemberInfo("LeagueFlags", "mLeagueFlags", 0xB26B2700, TdfType.Enum, 2, true), // LFLG
        new TdfMemberInfo("LeagueId", "mLeagueId", 0xB27A6400, TdfType.UInt32, 3, true), // LGID
        new TdfMemberInfo("Logo", "mLogo", 0xB2F9EF00, TdfType.UInt16, 4, true), // LOGO
        new TdfMemberInfo("Options", "mOptions", 0xBF0D3300, TdfType.List, 5, true), // OPTS
        new TdfMemberInfo("Password", "mPassword", 0xC21CF300, TdfType.String, 6, true), // PASS
        new TdfMemberInfo("Trophy", "mTrophy", 0xD32C2800, TdfType.UInt32, 7, true), // TRPH
    ];
    private ITdfMember[] __members;

    private TdfString _abbrev = new(__typeInfos[0]);
    private TdfString _description = new(__typeInfos[1]);
    private TdfEnum<Blaze2SDK.Blaze.League.LeagueFlags> _leagueFlags = new(__typeInfos[2]);
    private TdfUInt32 _leagueId = new(__typeInfos[3]);
    private TdfUInt16 _logo = new(__typeInfos[4]);
    private TdfList<uint> _options = new(__typeInfos[5]);
    private TdfString _password = new(__typeInfos[6]);
    private TdfUInt32 _trophy = new(__typeInfos[7]);

    public UpdateLeagueSettingsRequest()
    {
        __members = [
            _abbrev,
            _description,
            _leagueFlags,
            _leagueId,
            _logo,
            _options,
            _password,
            _trophy,
        ];
    }

    public override Tdf CreateNew() => new UpdateLeagueSettingsRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "UpdateLeagueSettingsRequest";
    public override string GetFullClassName() => "Blaze::League::UpdateLeagueSettingsRequest";

    public string Abbrev
    {
        get => _abbrev.Value;
        set => _abbrev.Value = value;
    }

    public string Description
    {
        get => _description.Value;
        set => _description.Value = value;
    }

    public Blaze2SDK.Blaze.League.LeagueFlags LeagueFlags
    {
        get => _leagueFlags.Value;
        set => _leagueFlags.Value = value;
    }

    public uint LeagueId
    {
        get => _leagueId.Value;
        set => _leagueId.Value = value;
    }

    public ushort Logo
    {
        get => _logo.Value;
        set => _logo.Value = value;
    }

    public IList<uint> Options
    {
        get => _options.Value;
        set => _options.Value = value;
    }

    public string Password
    {
        get => _password.Value;
        set => _password.Value = value;
    }

    public uint Trophy
    {
        get => _trophy.Value;
        set => _trophy.Value = value;
    }

}

