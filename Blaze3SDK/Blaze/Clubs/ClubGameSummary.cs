using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Clubs;

public class ClubGameSummary : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Loss", "mLoss", 0xBACBF300, TdfType.UInt32, 0, true), // NLOS
        new TdfMemberInfo("LastUpdateTime", "mLastUpdateTime", 0xBACD7000, TdfType.UInt32, 1, true), // NLUP
        new TdfMemberInfo("Tie", "mTie", 0xBB4A6500, TdfType.UInt32, 2, true), // NTIE
        new TdfMemberInfo("Win", "mWin", 0xBB7A6E00, TdfType.UInt32, 3, true), // NWIN
        new TdfMemberInfo("OppoClubId", "mOppoClubId", 0xBF0A6400, TdfType.UInt32, 4, true), // OPID
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _loss = new(__typeInfos[0]);
    private TdfUInt32 _lastUpdateTime = new(__typeInfos[1]);
    private TdfUInt32 _tie = new(__typeInfos[2]);
    private TdfUInt32 _win = new(__typeInfos[3]);
    private TdfUInt32 _oppoClubId = new(__typeInfos[4]);

    public ClubGameSummary()
    {
        __members = [
            _loss,
            _lastUpdateTime,
            _tie,
            _win,
            _oppoClubId,
        ];
    }

    public override Tdf CreateNew() => new ClubGameSummary();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ClubGameSummary";
    public override string GetFullClassName() => "Blaze::Clubs::ClubGameSummary";

    public uint Loss
    {
        get => _loss.Value;
        set => _loss.Value = value;
    }

    public uint LastUpdateTime
    {
        get => _lastUpdateTime.Value;
        set => _lastUpdateTime.Value = value;
    }

    public uint Tie
    {
        get => _tie.Value;
        set => _tie.Value = value;
    }

    public uint Win
    {
        get => _win.Value;
        set => _win.Value = value;
    }

    public uint OppoClubId
    {
        get => _oppoClubId.Value;
        set => _oppoClubId.Value = value;
    }

}

