using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Clubs;

public class ClubLocalizedNews : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("AssociateClubId", "mAssociateClubId", 0x8ECA6400, TdfType.UInt32, 0, true), // CLID
        new TdfMemberInfo("Text", "mText", 0xBB4E3400, TdfType.String, 1, true), // NTXT
        new TdfMemberInfo("ContentCreator", "mContentCreator", 0xBB78E300, TdfType.UInt32, 2, true), // NWCC
        new TdfMemberInfo("Flags", "mFlags", 0xBB79AC00, TdfType.Enum, 3, true), // NWFL
        new TdfMemberInfo("NewsId", "mNewsId", 0xBB7A6400, TdfType.UInt64, 4, true), // NWID
        new TdfMemberInfo("Type", "mType", 0xBB7D3900, TdfType.Enum, 5, true), // NWTY
        new TdfMemberInfo("Persona", "mPersona", 0xC25CB300, TdfType.String, 6, true), // PERS
        new TdfMemberInfo("Timestamp", "mTimestamp", 0xD2DCF400, TdfType.UInt32, 7, true), // TMST
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _associateClubId = new(__typeInfos[0]);
    private TdfString _text = new(__typeInfos[1]);
    private TdfUInt32 _contentCreator = new(__typeInfos[2]);
    private TdfEnum<Blaze2SDK.Blaze.Clubs.ClubNewsFlags> _flags = new(__typeInfos[3]);
    private TdfUInt64 _newsId = new(__typeInfos[4]);
    private TdfEnum<Blaze2SDK.Blaze.Clubs.NewsType> _type = new(__typeInfos[5]);
    private TdfString _persona = new(__typeInfos[6]);
    private TdfUInt32 _timestamp = new(__typeInfos[7]);

    public ClubLocalizedNews()
    {
        __members = [
            _associateClubId,
            _text,
            _contentCreator,
            _flags,
            _newsId,
            _type,
            _persona,
            _timestamp,
        ];
    }

    public override Tdf CreateNew() => new ClubLocalizedNews();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ClubLocalizedNews";
    public override string GetFullClassName() => "Blaze::Clubs::ClubLocalizedNews";

    public uint AssociateClubId
    {
        get => _associateClubId.Value;
        set => _associateClubId.Value = value;
    }

    public string Text
    {
        get => _text.Value;
        set => _text.Value = value;
    }

    public uint ContentCreator
    {
        get => _contentCreator.Value;
        set => _contentCreator.Value = value;
    }

    public Blaze2SDK.Blaze.Clubs.ClubNewsFlags Flags
    {
        get => _flags.Value;
        set => _flags.Value = value;
    }

    public ulong NewsId
    {
        get => _newsId.Value;
        set => _newsId.Value = value;
    }

    public Blaze2SDK.Blaze.Clubs.NewsType Type
    {
        get => _type.Value;
        set => _type.Value = value;
    }

    public string Persona
    {
        get => _persona.Value;
        set => _persona.Value = value;
    }

    public uint Timestamp
    {
        get => _timestamp.Value;
        set => _timestamp.Value = value;
    }

}

