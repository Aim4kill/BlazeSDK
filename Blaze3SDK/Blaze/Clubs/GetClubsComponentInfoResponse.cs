using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Clubs;

public class GetClubsComponentInfoResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ClubsComponentInfo", "mClubsComponentInfo", 0x8ECA6E00, TdfType.Struct, 0, true), // CLIN
    ];
    private ITdfMember[] __members;

    private TdfStruct<Blaze3SDK.Blaze.Clubs.ClubsComponentInfo?> _clubsComponentInfo = new(__typeInfos[0]);

    public GetClubsComponentInfoResponse()
    {
        __members = [
            _clubsComponentInfo,
        ];
    }

    public override Tdf CreateNew() => new GetClubsComponentInfoResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetClubsComponentInfoResponse";
    public override string GetFullClassName() => "Blaze::Clubs::GetClubsComponentInfoResponse";

    public Blaze3SDK.Blaze.Clubs.ClubsComponentInfo? ClubsComponentInfo
    {
        get => _clubsComponentInfo.Value;
        set => _clubsComponentInfo.Value = value;
    }

}

