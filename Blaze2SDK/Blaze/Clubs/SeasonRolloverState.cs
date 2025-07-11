using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Clubs;

public class SeasonRolloverState : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("SeasonRolloverState", "mSeasonRolloverState", 0xCF3D2500, TdfType.Enum, 0, true), // SSTE
    ];
    private ITdfMember[] __members;

    private TdfEnum<Blaze2SDK.Blaze.Clubs.SeasonState> _seasonRolloverState = new(__typeInfos[0]);

    public SeasonRolloverState()
    {
        __members = [
            _seasonRolloverState,
        ];
    }

    public override Tdf CreateNew() => new SeasonRolloverState();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "SeasonRolloverState";
    public override string GetFullClassName() => "Blaze::Clubs::SeasonRolloverState";

    public Blaze2SDK.Blaze.Clubs.SeasonState mSeasonRolloverState
    {
        get => _seasonRolloverState.Value;
        set => _seasonRolloverState.Value = value;
    }

}

