using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Clubs;

public class CreateClubResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ClubId", "mClubId", 0x8ECA6400, TdfType.UInt32, 0, true), // CLID
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _clubId = new(__typeInfos[0]);

    public CreateClubResponse()
    {
        __members = [
            _clubId,
        ];
    }

    public override Tdf CreateNew() => new CreateClubResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "CreateClubResponse";
    public override string GetFullClassName() => "Blaze::Clubs::CreateClubResponse";

    public uint ClubId
    {
        get => _clubId.Value;
        set => _clubId.Value = value;
    }

}

