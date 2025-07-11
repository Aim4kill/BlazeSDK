using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Clubs;

public class ClubAward : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("AwardId", "mAwardId", 0x877A6400, TdfType.UInt32, 0, true), // AWID
        new TdfMemberInfo("AwardImgURL", "mAwardImgURL", 0x877A7500, TdfType.String, 1, true), // AWIU
        new TdfMemberInfo("Count", "mCount", 0x8E1DE900, TdfType.UInt32, 2, true), // CAWI
        new TdfMemberInfo("AwardImgCheckSum", "mAwardImgCheckSum", 0xA6D8F300, TdfType.Int32, 3, true), // IMCS
        new TdfMemberInfo("LastUpdateTime", "mLastUpdateTime", 0xB3593400, TdfType.UInt32, 4, true), // LUDT
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _awardId = new(__typeInfos[0]);
    private TdfString _awardImgURL = new(__typeInfos[1]);
    private TdfUInt32 _count = new(__typeInfos[2]);
    private TdfInt32 _awardImgCheckSum = new(__typeInfos[3]);
    private TdfUInt32 _lastUpdateTime = new(__typeInfos[4]);

    public ClubAward()
    {
        __members = [
            _awardId,
            _awardImgURL,
            _count,
            _awardImgCheckSum,
            _lastUpdateTime,
        ];
    }

    public override Tdf CreateNew() => new ClubAward();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ClubAward";
    public override string GetFullClassName() => "Blaze::Clubs::ClubAward";

    public uint AwardId
    {
        get => _awardId.Value;
        set => _awardId.Value = value;
    }

    public string AwardImgURL
    {
        get => _awardImgURL.Value;
        set => _awardImgURL.Value = value;
    }

    public uint Count
    {
        get => _count.Value;
        set => _count.Value = value;
    }

    public int AwardImgCheckSum
    {
        get => _awardImgCheckSum.Value;
        set => _awardImgCheckSum.Value = value;
    }

    public uint LastUpdateTime
    {
        get => _lastUpdateTime.Value;
        set => _lastUpdateTime.Value = value;
    }

}

