using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Locker;

public class GetContentTopNResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("TopNList", "mTopNList", 0xB22CB700, TdfType.List, 0, true), // LBRW
        new TdfMemberInfo("Size", "mSize", 0xCE9EA500, TdfType.Int32, 1, true), // SIZE
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze3SDK.Blaze.Locker.LeaderboardValuesRow> _topNList = new(__typeInfos[0]);
    private TdfInt32 _size = new(__typeInfos[1]);

    public GetContentTopNResponse()
    {
        __members = [
            _topNList,
            _size,
        ];
    }

    public override Tdf CreateNew() => new GetContentTopNResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetContentTopNResponse";
    public override string GetFullClassName() => "Blaze::Locker::GetContentTopNResponse";

    public IList<Blaze3SDK.Blaze.Locker.LeaderboardValuesRow> TopNList
    {
        get => _topNList.Value;
        set => _topNList.Value = value;
    }

    public int Size
    {
        get => _size.Value;
        set => _size.Value = value;
    }

}

