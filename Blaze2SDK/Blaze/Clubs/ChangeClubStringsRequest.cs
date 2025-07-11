using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Clubs;

public class ChangeClubStringsRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Abbrev", "mAbbrev", 0x8E18B200, TdfType.String, 0, true), // CABR
        new TdfMemberInfo("Description", "mDescription", 0x8E4CE300, TdfType.String, 1, true), // CDSC
        new TdfMemberInfo("ClubId", "mClubId", 0x8ECA6400, TdfType.UInt32, 2, true), // CLID
        new TdfMemberInfo("Name", "mName", 0x8EE86D00, TdfType.String, 3, true), // CNAM
    ];
    private ITdfMember[] __members;

    private TdfString _abbrev = new(__typeInfos[0]);
    private TdfString _description = new(__typeInfos[1]);
    private TdfUInt32 _clubId = new(__typeInfos[2]);
    private TdfString _name = new(__typeInfos[3]);

    public ChangeClubStringsRequest()
    {
        __members = [
            _abbrev,
            _description,
            _clubId,
            _name,
        ];
    }

    public override Tdf CreateNew() => new ChangeClubStringsRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ChangeClubStringsRequest";
    public override string GetFullClassName() => "Blaze::Clubs::ChangeClubStringsRequest";

    public string Abbrev
    {
        get => _abbrev.Value;
        set => _abbrev.Value = value;
    }

    public string Description
    {
        get => _description.Value;
        set => _description.Value = value;
    }

    public uint ClubId
    {
        get => _clubId.Value;
        set => _clubId.Value = value;
    }

    public string Name
    {
        get => _name.Value;
        set => _name.Value = value;
    }

}

