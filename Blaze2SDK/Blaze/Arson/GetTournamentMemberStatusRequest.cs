using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Arson;

public class GetTournamentMemberStatusRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("UserId", "mUserId", 0xD6990000, TdfType.UInt32, 0, true), // UID
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _userId = new(__typeInfos[0]);

    public GetTournamentMemberStatusRequest()
    {
        __members = [
            _userId,
        ];
    }

    public override Tdf CreateNew() => new GetTournamentMemberStatusRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetTournamentMemberStatusRequest";
    public override string GetFullClassName() => "Blaze::Arson::GetTournamentMemberStatusRequest";

    public uint UserId
    {
        get => _userId.Value;
        set => _userId.Value = value;
    }

}

