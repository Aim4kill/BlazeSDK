using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Clubs;

public class GetClubsRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ClubIdList", "mClubIdList", 0x8ECA6400, TdfType.List, 0, true), // CLID
        new TdfMemberInfo("IncludeClubTags", "mIncludeClubTags", 0x8ECD2900, TdfType.Bool, 1, true), // CLTI
        new TdfMemberInfo("ClubsOrder", "mClubsOrder", 0x8EF93200, TdfType.Enum, 2, true), // CODR
        new TdfMemberInfo("MaxResultCount", "mMaxResultCount", 0xB78CA300, TdfType.UInt32, 3, true), // MXRC
        new TdfMemberInfo("OrderMode", "mOrderMode", 0xBE4B6400, TdfType.Enum, 4, true), // ODMD
        new TdfMemberInfo("Offset", "mOffset", 0xBE6CA300, TdfType.UInt32, 5, true), // OFRC
    ];
    private ITdfMember[] __members;

    private TdfList<uint> _clubIdList = new(__typeInfos[0]);
    private TdfBool _includeClubTags = new(__typeInfos[1]);
    private TdfEnum<Blaze3SDK.Blaze.Clubs.ClubsOrder> _clubsOrder = new(__typeInfos[2]);
    private TdfUInt32 _maxResultCount = new(__typeInfos[3]);
    private TdfEnum<Blaze3SDK.Blaze.Clubs.OrderMode> _orderMode = new(__typeInfos[4]);
    private TdfUInt32 _offset = new(__typeInfos[5]);

    public GetClubsRequest()
    {
        __members = [
            _clubIdList,
            _includeClubTags,
            _clubsOrder,
            _maxResultCount,
            _orderMode,
            _offset,
        ];
    }

    public override Tdf CreateNew() => new GetClubsRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetClubsRequest";
    public override string GetFullClassName() => "Blaze::Clubs::GetClubsRequest";

    public IList<uint> ClubIdList
    {
        get => _clubIdList.Value;
        set => _clubIdList.Value = value;
    }

    public bool IncludeClubTags
    {
        get => _includeClubTags.Value;
        set => _includeClubTags.Value = value;
    }

    public Blaze3SDK.Blaze.Clubs.ClubsOrder ClubsOrder
    {
        get => _clubsOrder.Value;
        set => _clubsOrder.Value = value;
    }

    public uint MaxResultCount
    {
        get => _maxResultCount.Value;
        set => _maxResultCount.Value = value;
    }

    public Blaze3SDK.Blaze.Clubs.OrderMode OrderMode
    {
        get => _orderMode.Value;
        set => _orderMode.Value = value;
    }

    public uint Offset
    {
        get => _offset.Value;
        set => _offset.Value = value;
    }

}

