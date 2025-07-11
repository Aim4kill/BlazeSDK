using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.League;

public class SetDraftProfileRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("LeagueId", "mLeagueId", 0xB27A6400, TdfType.UInt32, 0, true), // LGID
        new TdfMemberInfo("DraftProfile", "mDraftProfile", 0xC32BE600, TdfType.Struct, 1, true), // PROF
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _leagueId = new(__typeInfos[0]);
    private TdfStruct<Blaze2SDK.Blaze.League.DraftProfile?> _draftProfile = new(__typeInfos[1]);

    public SetDraftProfileRequest()
    {
        __members = [
            _leagueId,
            _draftProfile,
        ];
    }

    public override Tdf CreateNew() => new SetDraftProfileRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "SetDraftProfileRequest";
    public override string GetFullClassName() => "Blaze::League::SetDraftProfileRequest";

    public uint LeagueId
    {
        get => _leagueId.Value;
        set => _leagueId.Value = value;
    }

    public Blaze2SDK.Blaze.League.DraftProfile? DraftProfile
    {
        get => _draftProfile.Value;
        set => _draftProfile.Value = value;
    }

}

