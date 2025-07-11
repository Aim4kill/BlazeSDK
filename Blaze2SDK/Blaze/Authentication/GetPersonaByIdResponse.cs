using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Authentication;

public class GetPersonaByIdResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("BlazeUserId", "mBlazeUserId", 0x8B5A6400, TdfType.UInt32, 0, true), // BUID
        new TdfMemberInfo("PersonaId", "mPersonaId", 0xC2990000, TdfType.Int64, 1, true), // PID
        new TdfMemberInfo("PersonaName", "mPersonaName", 0xC2E86D00, TdfType.String, 2, true), // PNAM
        new TdfMemberInfo("UserId", "mUserId", 0xD6990000, TdfType.Int64, 3, true), // UID
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _blazeUserId = new(__typeInfos[0]);
    private TdfInt64 _personaId = new(__typeInfos[1]);
    private TdfString _personaName = new(__typeInfos[2]);
    private TdfInt64 _userId = new(__typeInfos[3]);

    public GetPersonaByIdResponse()
    {
        __members = [
            _blazeUserId,
            _personaId,
            _personaName,
            _userId,
        ];
    }

    public override Tdf CreateNew() => new GetPersonaByIdResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetPersonaByIdResponse";
    public override string GetFullClassName() => "Blaze::Authentication::GetPersonaByIdResponse";

    public uint BlazeUserId
    {
        get => _blazeUserId.Value;
        set => _blazeUserId.Value = value;
    }

    public long PersonaId
    {
        get => _personaId.Value;
        set => _personaId.Value = value;
    }

    public string PersonaName
    {
        get => _personaName.Value;
        set => _personaName.Value = value;
    }

    public long UserId
    {
        get => _userId.Value;
        set => _userId.Value = value;
    }

}

