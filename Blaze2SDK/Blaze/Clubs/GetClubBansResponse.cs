using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Clubs;

public class GetClubBansResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("UserIdToBanStatusMap", "mUserIdToBanStatusMap", 0x8A1BB300, TdfType.Map, 0, true), // BANS
    ];
    private ITdfMember[] __members;

    private TdfMap<uint, uint> _userIdToBanStatusMap = new(__typeInfos[0]);

    public GetClubBansResponse()
    {
        __members = [
            _userIdToBanStatusMap,
        ];
    }

    public override Tdf CreateNew() => new GetClubBansResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetClubBansResponse";
    public override string GetFullClassName() => "Blaze::Clubs::GetClubBansResponse";

    public IDictionary<uint, uint> UserIdToBanStatusMap
    {
        get => _userIdToBanStatusMap.Value;
        set => _userIdToBanStatusMap.Value = value;
    }

}

