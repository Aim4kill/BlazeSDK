using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Clubs;

public class GetPetitionsForClubsResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ClubPetitionListMap", "mClubPetitionListMap", 0xB30B7000, TdfType.Map, 0, true), // LPMP
    ];
    private ITdfMember[] __members;

    private TdfMap<uint, IList<Blaze3SDK.Blaze.Clubs.ClubMessage>> _clubPetitionListMap = new(__typeInfos[0]);

    public GetPetitionsForClubsResponse()
    {
        __members = [
            _clubPetitionListMap,
        ];
    }

    public override Tdf CreateNew() => new GetPetitionsForClubsResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetPetitionsForClubsResponse";
    public override string GetFullClassName() => "Blaze::Clubs::GetPetitionsForClubsResponse";

    public IDictionary<uint, IList<Blaze3SDK.Blaze.Clubs.ClubMessage>> ClubPetitionListMap
    {
        get => _clubPetitionListMap.Value;
        set => _clubPetitionListMap.Value = value;
    }

}

