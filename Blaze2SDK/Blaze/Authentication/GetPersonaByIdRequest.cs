using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Authentication;

public class GetPersonaByIdRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("BlazeUserId", "mBlazeUserId", 0x8B5A6400, TdfType.UInt32, 0, true), // BUID
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _blazeUserId = new(__typeInfos[0]);

    public GetPersonaByIdRequest()
    {
        __members = [
            _blazeUserId,
        ];
    }

    public override Tdf CreateNew() => new GetPersonaByIdRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetPersonaByIdRequest";
    public override string GetFullClassName() => "Blaze::Authentication::GetPersonaByIdRequest";

    public uint BlazeUserId
    {
        get => _blazeUserId.Value;
        set => _blazeUserId.Value = value;
    }

}

