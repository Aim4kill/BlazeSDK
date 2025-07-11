using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Clubs;

public class UpdateMemberMetadataRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ClubId", "mClubId", 0x8ECA6400, TdfType.UInt32, 0, true), // CLID
        new TdfMemberInfo("MetaData", "mMetaData", 0xB65D2100, TdfType.Map, 1, true), // META
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _clubId = new(__typeInfos[0]);
    private TdfMap<string, string> _metaData = new(__typeInfos[1]);

    public UpdateMemberMetadataRequest()
    {
        __members = [
            _clubId,
            _metaData,
        ];
    }

    public override Tdf CreateNew() => new UpdateMemberMetadataRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "UpdateMemberMetadataRequest";
    public override string GetFullClassName() => "Blaze::Clubs::UpdateMemberMetadataRequest";

    public uint ClubId
    {
        get => _clubId.Value;
        set => _clubId.Value = value;
    }

    public IDictionary<string, string> MetaData
    {
        get => _metaData.Value;
        set => _metaData.Value = value;
    }

}

