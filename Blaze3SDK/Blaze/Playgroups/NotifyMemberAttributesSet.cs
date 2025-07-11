using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Playgroups;

public class NotifyMemberAttributesSet : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("MemberAttributes", "mMemberAttributes", 0x874D3200, TdfType.Map, 0, true), // ATTR
        new TdfMemberInfo("BlazeId", "mBlazeId", 0x96990000, TdfType.Int64, 1, true), // EID
        new TdfMemberInfo("PlaygroupId", "mPlaygroupId", 0xC27A6400, TdfType.UInt32, 2, true), // PGID
    ];
    private ITdfMember[] __members;

    private TdfMap<string, string> _memberAttributes = new(__typeInfos[0]);
    private TdfInt64 _blazeId = new(__typeInfos[1]);
    private TdfUInt32 _playgroupId = new(__typeInfos[2]);

    public NotifyMemberAttributesSet()
    {
        __members = [
            _memberAttributes,
            _blazeId,
            _playgroupId,
        ];
    }

    public override Tdf CreateNew() => new NotifyMemberAttributesSet();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "NotifyMemberAttributesSet";
    public override string GetFullClassName() => "Blaze::Playgroups::NotifyMemberAttributesSet";

    public IDictionary<string, string> MemberAttributes
    {
        get => _memberAttributes.Value;
        set => _memberAttributes.Value = value;
    }

    public long BlazeId
    {
        get => _blazeId.Value;
        set => _blazeId.Value = value;
    }

    public uint PlaygroupId
    {
        get => _playgroupId.Value;
        set => _playgroupId.Value = value;
    }

}

