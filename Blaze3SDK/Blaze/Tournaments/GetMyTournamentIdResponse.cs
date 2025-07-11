using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Tournaments;

public class GetMyTournamentIdResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("IsActive", "mIsActive", 0x863D2900, TdfType.Bool, 0, true), // ACTI
        new TdfMemberInfo("Id", "mId", 0xD2EA6400, TdfType.UInt32, 1, true), // TNID
    ];
    private ITdfMember[] __members;

    private TdfBool _isActive = new(__typeInfos[0]);
    private TdfUInt32 _id = new(__typeInfos[1]);

    public GetMyTournamentIdResponse()
    {
        __members = [
            _isActive,
            _id,
        ];
    }

    public override Tdf CreateNew() => new GetMyTournamentIdResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetMyTournamentIdResponse";
    public override string GetFullClassName() => "Blaze::Tournaments::GetMyTournamentIdResponse";

    public bool IsActive
    {
        get => _isActive.Value;
        set => _isActive.Value = value;
    }

    public uint Id
    {
        get => _id.Value;
        set => _id.Value = value;
    }

}

