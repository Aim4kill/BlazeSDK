using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.League;

public class GetLeaguesByUserRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("FindNumberOfMembersOnline", "mFindNumberOfMembersOnline", 0xBEEB2E00, TdfType.UInt8, 0, true), // ONLN
    ];
    private ITdfMember[] __members;

    private TdfUInt8 _findNumberOfMembersOnline = new(__typeInfos[0]);

    public GetLeaguesByUserRequest()
    {
        __members = [
            _findNumberOfMembersOnline,
        ];
    }

    public override Tdf CreateNew() => new GetLeaguesByUserRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetLeaguesByUserRequest";
    public override string GetFullClassName() => "Blaze::League::GetLeaguesByUserRequest";

    public byte FindNumberOfMembersOnline
    {
        get => _findNumberOfMembersOnline.Value;
        set => _findNumberOfMembersOnline.Value = value;
    }

}

