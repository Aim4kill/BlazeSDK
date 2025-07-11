using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Clubs;

public class ClubNews : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("AssociateClubId", "mAssociateClubId", 0x8ECA6400, TdfType.UInt32, 0, true), // CLID
        new TdfMemberInfo("ParamList", "mParamList", 0xBB0CAC00, TdfType.String, 1, true), // NPRL
        new TdfMemberInfo("StringId", "mStringId", 0xBB3A7300, TdfType.String, 2, true), // NSIS
        new TdfMemberInfo("Text", "mText", 0xBB4E3400, TdfType.String, 3, true), // NTXT
        new TdfMemberInfo("ContentCreator", "mContentCreator", 0xBB78E300, TdfType.Int64, 4, true), // NWCC
        new TdfMemberInfo("Type", "mType", 0xBB7D3900, TdfType.Enum, 5, true), // NWTY
        new TdfMemberInfo("Persona", "mPersona", 0xC25CB300, TdfType.String, 6, true), // PERS
        new TdfMemberInfo("Timestamp", "mTimestamp", 0xD2DCF400, TdfType.UInt32, 7, true), // TMST
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _associateClubId = new(__typeInfos[0]);
    private TdfString _paramList = new(__typeInfos[1]);
    private TdfString _stringId = new(__typeInfos[2]);
    private TdfString _text = new(__typeInfos[3]);
    private TdfInt64 _contentCreator = new(__typeInfos[4]);
    private TdfEnum<Blaze3SDK.Blaze.Clubs.NewsType> _type = new(__typeInfos[5]);
    private TdfString _persona = new(__typeInfos[6]);
    private TdfUInt32 _timestamp = new(__typeInfos[7]);

    public ClubNews()
    {
        __members = [
            _associateClubId,
            _paramList,
            _stringId,
            _text,
            _contentCreator,
            _type,
            _persona,
            _timestamp,
        ];
    }

    public override Tdf CreateNew() => new ClubNews();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ClubNews";
    public override string GetFullClassName() => "Blaze::Clubs::ClubNews";

    public uint AssociateClubId
    {
        get => _associateClubId.Value;
        set => _associateClubId.Value = value;
    }

    public string ParamList
    {
        get => _paramList.Value;
        set => _paramList.Value = value;
    }

    public string StringId
    {
        get => _stringId.Value;
        set => _stringId.Value = value;
    }

    public string Text
    {
        get => _text.Value;
        set => _text.Value = value;
    }

    public long ContentCreator
    {
        get => _contentCreator.Value;
        set => _contentCreator.Value = value;
    }

    public Blaze3SDK.Blaze.Clubs.NewsType Type
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

