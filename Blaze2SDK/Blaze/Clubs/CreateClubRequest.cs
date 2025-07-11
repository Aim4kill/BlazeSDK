using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Clubs;

public class CreateClubRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Name", "mName", 0x8EE86D00, TdfType.String, 0, true), // CNAM
        new TdfMemberInfo("ClubSettings", "mClubSettings", 0x8F397400, TdfType.Struct, 1, true), // CSET
    ];
    private ITdfMember[] __members;

    private TdfString _name = new(__typeInfos[0]);
    private TdfStruct<Blaze2SDK.Blaze.Clubs.ClubSettings?> _clubSettings = new(__typeInfos[1]);

    public CreateClubRequest()
    {
        __members = [
            _name,
            _clubSettings,
        ];
    }

    public override Tdf CreateNew() => new CreateClubRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "CreateClubRequest";
    public override string GetFullClassName() => "Blaze::Clubs::CreateClubRequest";

    public string Name
    {
        get => _name.Value;
        set => _name.Value = value;
    }

    public Blaze2SDK.Blaze.Clubs.ClubSettings? ClubSettings
    {
        get => _clubSettings.Value;
        set => _clubSettings.Value = value;
    }

}

