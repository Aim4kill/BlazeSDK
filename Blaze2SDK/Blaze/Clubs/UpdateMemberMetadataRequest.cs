using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Clubs;

public class UpdateMemberMetadataRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("MetaData", "mMetaData", 0xB65D2100, TdfType.Map, 0, true), // META
    ];
    private ITdfMember[] __members;

    private TdfMap<string, string> _metaData = new(__typeInfos[0]);

    public UpdateMemberMetadataRequest()
    {
        __members = [
            _metaData,
        ];
    }

    public override Tdf CreateNew() => new UpdateMemberMetadataRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "UpdateMemberMetadataRequest";
    public override string GetFullClassName() => "Blaze::Clubs::UpdateMemberMetadataRequest";

    public IDictionary<string, string> MetaData
    {
        get => _metaData.Value;
        set => _metaData.Value = value;
    }

}

