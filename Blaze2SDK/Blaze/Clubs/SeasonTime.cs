using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Clubs;

public class SeasonTime : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("SeasonRolloverTime", "mSeasonRolloverTime", 0xCEFDB200, TdfType.Int32, 0, true), // SOVR
        new TdfMemberInfo("SeasonStartTime", "mSeasonStartTime", 0xCF4CB400, TdfType.Int32, 1, true), // STRT
    ];
    private ITdfMember[] __members;

    private TdfInt32 _seasonRolloverTime = new(__typeInfos[0]);
    private TdfInt32 _seasonStartTime = new(__typeInfos[1]);

    public SeasonTime()
    {
        __members = [
            _seasonRolloverTime,
            _seasonStartTime,
        ];
    }

    public override Tdf CreateNew() => new SeasonTime();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "SeasonTime";
    public override string GetFullClassName() => "Blaze::Clubs::SeasonTime";

    public int SeasonRolloverTime
    {
        get => _seasonRolloverTime.Value;
        set => _seasonRolloverTime.Value = value;
    }

    public int SeasonStartTime
    {
        get => _seasonStartTime.Value;
        set => _seasonStartTime.Value = value;
    }

}

