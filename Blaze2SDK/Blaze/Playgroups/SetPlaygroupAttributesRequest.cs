using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Playgroups;

public class SetPlaygroupAttributesRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("PlaygroupAttributes", "mPlaygroupAttributes", 0x874D3200, TdfType.Map, 0, true), // ATTR
        new TdfMemberInfo("PlaygroupId", "mPlaygroupId", 0xC27A6400, TdfType.UInt32, 1, true), // PGID
    ];
    private ITdfMember[] __members;

    private TdfMap<string, string> _playgroupAttributes = new(__typeInfos[0]);
    private TdfUInt32 _playgroupId = new(__typeInfos[1]);

    public SetPlaygroupAttributesRequest()
    {
        __members = [
            _playgroupAttributes,
            _playgroupId,
        ];
    }

    public override Tdf CreateNew() => new SetPlaygroupAttributesRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "SetPlaygroupAttributesRequest";
    public override string GetFullClassName() => "Blaze::Playgroups::SetPlaygroupAttributesRequest";

    public IDictionary<string, string> PlaygroupAttributes
    {
        get => _playgroupAttributes.Value;
        set => _playgroupAttributes.Value = value;
    }

    public uint PlaygroupId
    {
        get => _playgroupId.Value;
        set => _playgroupId.Value = value;
    }

}

