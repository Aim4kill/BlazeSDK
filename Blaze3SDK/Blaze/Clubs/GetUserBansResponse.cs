using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Clubs;

public class GetUserBansResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ClubIdToBanStatusMap", "mClubIdToBanStatusMap", 0x8A1BB300, TdfType.Map, 0, true), // BANS
    ];
    private ITdfMember[] __members;

    private TdfMap<uint, uint> _clubIdToBanStatusMap = new(__typeInfos[0]);

    public GetUserBansResponse()
    {
        __members = [
            _clubIdToBanStatusMap,
        ];
    }

    public override Tdf CreateNew() => new GetUserBansResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetUserBansResponse";
    public override string GetFullClassName() => "Blaze::Clubs::GetUserBansResponse";

    public IDictionary<uint, uint> ClubIdToBanStatusMap
    {
        get => _clubIdToBanStatusMap.Value;
        set => _clubIdToBanStatusMap.Value = value;
    }

}

