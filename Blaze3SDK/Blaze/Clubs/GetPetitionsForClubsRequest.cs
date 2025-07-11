using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Clubs;

public class GetPetitionsForClubsRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ClubIdList", "mClubIdList", 0x8E992C00, TdfType.List, 0, true), // CIDL
        new TdfMemberInfo("PetitionsType", "mPetitionsType", 0xA6EDB400, TdfType.Enum, 1, true), // INVT
        new TdfMemberInfo("SortType", "mSortType", 0xBB3BF400, TdfType.Enum, 2, true), // NSOT
    ];
    private ITdfMember[] __members;

    private TdfList<uint> _clubIdList = new(__typeInfos[0]);
    private TdfEnum<Blaze3SDK.Blaze.Clubs.PetitionsType> _petitionsType = new(__typeInfos[1]);
    private TdfEnum<Blaze3SDK.Blaze.Clubs.TimeSortType> _sortType = new(__typeInfos[2]);

    public GetPetitionsForClubsRequest()
    {
        __members = [
            _clubIdList,
            _petitionsType,
            _sortType,
        ];
    }

    public override Tdf CreateNew() => new GetPetitionsForClubsRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetPetitionsForClubsRequest";
    public override string GetFullClassName() => "Blaze::Clubs::GetPetitionsForClubsRequest";

    public IList<uint> ClubIdList
    {
        get => _clubIdList.Value;
        set => _clubIdList.Value = value;
    }

    public Blaze3SDK.Blaze.Clubs.PetitionsType PetitionsType
    {
        get => _petitionsType.Value;
        set => _petitionsType.Value = value;
    }

    public Blaze3SDK.Blaze.Clubs.TimeSortType SortType
    {
        get => _sortType.Value;
        set => _sortType.Value = value;
    }

}

