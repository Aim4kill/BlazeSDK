using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Clubs;

public class GetNewsRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ClubId", "mClubId", 0x8ECA6400, TdfType.UInt32, 0, true), // CLID
        new TdfMemberInfo("MaxResultCount", "mMaxResultCount", 0xB63BB400, TdfType.UInt32, 1, true), // MCNT
        new TdfMemberInfo("SortType", "mSortType", 0xBB3BF400, TdfType.Enum, 2, true), // NSOT
        new TdfMemberInfo("OffSet", "mOffSet", 0xBE6CF400, TdfType.UInt32, 3, true), // OFST
        new TdfMemberInfo("TypeFilters", "mTypeFilters", 0xD26A6C00, TdfType.List, 4, true), // TFIL
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _clubId = new(__typeInfos[0]);
    private TdfUInt32 _maxResultCount = new(__typeInfos[1]);
    private TdfEnum<Blaze2SDK.Blaze.Clubs.TimeSortType> _sortType = new(__typeInfos[2]);
    private TdfUInt32 _offSet = new(__typeInfos[3]);
    private TdfList<Blaze2SDK.Blaze.Clubs.NewsType> _typeFilters = new(__typeInfos[4]);

    public GetNewsRequest()
    {
        __members = [
            _clubId,
            _maxResultCount,
            _sortType,
            _offSet,
            _typeFilters,
        ];
    }

    public override Tdf CreateNew() => new GetNewsRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetNewsRequest";
    public override string GetFullClassName() => "Blaze::Clubs::GetNewsRequest";

    public uint ClubId
    {
        get => _clubId.Value;
        set => _clubId.Value = value;
    }

    public uint MaxResultCount
    {
        get => _maxResultCount.Value;
        set => _maxResultCount.Value = value;
    }

    public Blaze2SDK.Blaze.Clubs.TimeSortType SortType
    {
        get => _sortType.Value;
        set => _sortType.Value = value;
    }

    public uint OffSet
    {
        get => _offSet.Value;
        set => _offSet.Value = value;
    }

    public IList<Blaze2SDK.Blaze.Clubs.NewsType> TypeFilters
    {
        get => _typeFilters.Value;
        set => _typeFilters.Value = value;
    }

}

