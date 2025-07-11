using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Clubs;

public class SetMetadataRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ClubId", "mClubId", 0x8ECA6400, TdfType.UInt32, 0, true), // CLID
        new TdfMemberInfo("MetaDataType", "mMetaDataType", 0xB64D3900, TdfType.Enum, 1, true), // MDTY
        new TdfMemberInfo("MetaData", "mMetaData", 0xB65D2400, TdfType.String, 2, true), // METD
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _clubId = new(__typeInfos[0]);
    private TdfEnum<Blaze3SDK.Blaze.Clubs.MetaDataType> _metaDataType = new(__typeInfos[1]);
    private TdfString _metaData = new(__typeInfos[2]);

    public SetMetadataRequest()
    {
        __members = [
            _clubId,
            _metaDataType,
            _metaData,
        ];
    }

    public override Tdf CreateNew() => new SetMetadataRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "SetMetadataRequest";
    public override string GetFullClassName() => "Blaze::Clubs::SetMetadataRequest";

    public uint ClubId
    {
        get => _clubId.Value;
        set => _clubId.Value = value;
    }

    public Blaze3SDK.Blaze.Clubs.MetaDataType MetaDataType
    {
        get => _metaDataType.Value;
        set => _metaDataType.Value = value;
    }

    public string MetaData
    {
        get => _metaData.Value;
        set => _metaData.Value = value;
    }

}

