using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.League;

public class SetOptionRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("MemberId", "mMemberId", 0x9EDA6400, TdfType.Int64, 0, true), // GMID
        new TdfMemberInfo("LeagueId", "mLeagueId", 0xB27A6400, TdfType.UInt32, 1, true), // LGID
        new TdfMemberInfo("OptionId", "mOptionId", 0xBF0A6400, TdfType.UInt32, 2, true), // OPID
        new TdfMemberInfo("Value", "mValue", 0xDA1B3500, TdfType.UInt32, 3, true), // VALU
    ];
    private ITdfMember[] __members;

    private TdfInt64 _memberId = new(__typeInfos[0]);
    private TdfUInt32 _leagueId = new(__typeInfos[1]);
    private TdfUInt32 _optionId = new(__typeInfos[2]);
    private TdfUInt32 _value = new(__typeInfos[3]);

    public SetOptionRequest()
    {
        __members = [
            _memberId,
            _leagueId,
            _optionId,
            _value,
        ];
    }

    public override Tdf CreateNew() => new SetOptionRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "SetOptionRequest";
    public override string GetFullClassName() => "Blaze::League::SetOptionRequest";

    public long MemberId
    {
        get => _memberId.Value;
        set => _memberId.Value = value;
    }

    public uint LeagueId
    {
        get => _leagueId.Value;
        set => _leagueId.Value = value;
    }

    public uint OptionId
    {
        get => _optionId.Value;
        set => _optionId.Value = value;
    }

    public uint Value
    {
        get => _value.Value;
        set => _value.Value = value;
    }

}

