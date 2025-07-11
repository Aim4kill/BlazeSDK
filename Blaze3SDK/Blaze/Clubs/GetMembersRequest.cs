using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Clubs;

public class GetMembersRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ClubId", "mClubId", 0x8ECA6400, TdfType.UInt32, 0, true), // CLID
        new TdfMemberInfo("MemberType", "mMemberType", 0x9A9B2D00, TdfType.Enum, 1, true), // FILM
        new TdfMemberInfo("MaxResultCount", "mMaxResultCount", 0xB78CA300, TdfType.UInt32, 2, true), // MXRC
        new TdfMemberInfo("Offset", "mOffset", 0xBE6CA300, TdfType.UInt32, 3, true), // OFRC
        new TdfMemberInfo("OrderMode", "mOrderMode", 0xBF292D00, TdfType.Enum, 4, true), // ORDM
        new TdfMemberInfo("OrderType", "mOrderType", 0xBF293400, TdfType.Enum, 5, true), // ORDT
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _clubId = new(__typeInfos[0]);
    private TdfEnum<Blaze3SDK.Blaze.Clubs.MemberTypeFilter> _memberType = new(__typeInfos[1]);
    private TdfUInt32 _maxResultCount = new(__typeInfos[2]);
    private TdfUInt32 _offset = new(__typeInfos[3]);
    private TdfEnum<Blaze3SDK.Blaze.Clubs.OrderMode> _orderMode = new(__typeInfos[4]);
    private TdfEnum<Blaze3SDK.Blaze.Clubs.MemberOrder> _orderType = new(__typeInfos[5]);

    public GetMembersRequest()
    {
        __members = [
            _clubId,
            _memberType,
            _maxResultCount,
            _offset,
            _orderMode,
            _orderType,
        ];
    }

    public override Tdf CreateNew() => new GetMembersRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetMembersRequest";
    public override string GetFullClassName() => "Blaze::Clubs::GetMembersRequest";

    public uint ClubId
    {
        get => _clubId.Value;
        set => _clubId.Value = value;
    }

    public Blaze3SDK.Blaze.Clubs.MemberTypeFilter MemberType
    {
        get => _memberType.Value;
        set => _memberType.Value = value;
    }

    public uint MaxResultCount
    {
        get => _maxResultCount.Value;
        set => _maxResultCount.Value = value;
    }

    public uint Offset
    {
        get => _offset.Value;
        set => _offset.Value = value;
    }

    public Blaze3SDK.Blaze.Clubs.OrderMode OrderMode
    {
        get => _orderMode.Value;
        set => _orderMode.Value = value;
    }

    public Blaze3SDK.Blaze.Clubs.MemberOrder OrderType
    {
        get => _orderType.Value;
        set => _orderType.Value = value;
    }

}

