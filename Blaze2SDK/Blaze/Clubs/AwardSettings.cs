using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Clubs;

public class AwardSettings : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("AwardChecksum", "mAwardChecksum", 0x8778F300, TdfType.UInt32, 0, true), // AWCS
        new TdfMemberInfo("AwardId", "mAwardId", 0x877A6400, TdfType.UInt32, 1, true), // AWID
        new TdfMemberInfo("AwardName", "mAwardName", 0x877BA100, TdfType.String, 2, true), // AWNA
        new TdfMemberInfo("AwardURL", "mAwardURL", 0x877D7200, TdfType.String, 3, true), // AWUR
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _awardChecksum = new(__typeInfos[0]);
    private TdfUInt32 _awardId = new(__typeInfos[1]);
    private TdfString _awardName = new(__typeInfos[2]);
    private TdfString _awardURL = new(__typeInfos[3]);

    public AwardSettings()
    {
        __members = [
            _awardChecksum,
            _awardId,
            _awardName,
            _awardURL,
        ];
    }

    public override Tdf CreateNew() => new AwardSettings();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "AwardSettings";
    public override string GetFullClassName() => "Blaze::Clubs::AwardSettings";

    public uint AwardChecksum
    {
        get => _awardChecksum.Value;
        set => _awardChecksum.Value = value;
    }

    public uint AwardId
    {
        get => _awardId.Value;
        set => _awardId.Value = value;
    }

    public string AwardName
    {
        get => _awardName.Value;
        set => _awardName.Value = value;
    }

    public string AwardURL
    {
        get => _awardURL.Value;
        set => _awardURL.Value = value;
    }

}

