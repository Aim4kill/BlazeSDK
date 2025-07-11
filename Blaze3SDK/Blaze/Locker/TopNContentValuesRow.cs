using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Locker;

public class TopNContentValuesRow : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ContentInfo", "mContentInfo", 0xA6E9AF00, TdfType.Struct, 0, true), // INFO
        new TdfMemberInfo("Rank", "mRank", 0xCA1BAB00, TdfType.Int32, 1, true), // RANK
    ];
    private ITdfMember[] __members;

    private TdfStruct<Blaze3SDK.Blaze.Locker.ContentInfo?> _contentInfo = new(__typeInfos[0]);
    private TdfInt32 _rank = new(__typeInfos[1]);

    public TopNContentValuesRow()
    {
        __members = [
            _contentInfo,
            _rank,
        ];
    }

    public override Tdf CreateNew() => new TopNContentValuesRow();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "TopNContentValuesRow";
    public override string GetFullClassName() => "Blaze::Locker::TopNContentValuesRow";

    public Blaze3SDK.Blaze.Locker.ContentInfo? ContentInfo
    {
        get => _contentInfo.Value;
        set => _contentInfo.Value = value;
    }

    public int Rank
    {
        get => _rank.Value;
        set => _rank.Value = value;
    }

}

