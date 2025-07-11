using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Clubs;

public class GetPetitionsRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ClubId", "mClubId", 0x8ECA6400, TdfType.UInt32, 0, true), // CLID
        new TdfMemberInfo("PetitionsType", "mPetitionsType", 0xA6EDB400, TdfType.Enum, 1, true), // INVT
        new TdfMemberInfo("SortType", "mSortType", 0xBB3BF400, TdfType.Enum, 2, true), // NSOT
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _clubId = new(__typeInfos[0]);
    private TdfEnum<Blaze2SDK.Blaze.Clubs.PetitionsType> _petitionsType = new(__typeInfos[1]);
    private TdfEnum<Blaze2SDK.Blaze.Clubs.TimeSortType> _sortType = new(__typeInfos[2]);

    public GetPetitionsRequest()
    {
        __members = [
            _clubId,
            _petitionsType,
            _sortType,
        ];
    }

    public override Tdf CreateNew() => new GetPetitionsRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetPetitionsRequest";
    public override string GetFullClassName() => "Blaze::Clubs::GetPetitionsRequest";

    public uint ClubId
    {
        get => _clubId.Value;
        set => _clubId.Value = value;
    }

    public Blaze2SDK.Blaze.Clubs.PetitionsType PetitionsType
    {
        get => _petitionsType.Value;
        set => _petitionsType.Value = value;
    }

    public Blaze2SDK.Blaze.Clubs.TimeSortType SortType
    {
        get => _sortType.Value;
        set => _sortType.Value = value;
    }

}

