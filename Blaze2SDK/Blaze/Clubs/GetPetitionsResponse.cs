using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Clubs;

public class GetPetitionsResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ClubPetitionsList", "mClubPetitionsList", 0x8E9CF400, TdfType.List, 0, true), // CIST
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze2SDK.Blaze.Clubs.ClubMessage> _clubPetitionsList = new(__typeInfos[0]);

    public GetPetitionsResponse()
    {
        __members = [
            _clubPetitionsList,
        ];
    }

    public override Tdf CreateNew() => new GetPetitionsResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetPetitionsResponse";
    public override string GetFullClassName() => "Blaze::Clubs::GetPetitionsResponse";

    public IList<Blaze2SDK.Blaze.Clubs.ClubMessage> ClubPetitionsList
    {
        get => _clubPetitionsList.Value;
        set => _clubPetitionsList.Value = value;
    }

}

