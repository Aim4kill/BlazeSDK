using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Playgroups;

public class PlaygroupMemberInfo : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("MemberAttributes", "mMemberAttributes", 0x874D3200, TdfType.Map, 0, true), // ATTR
        new TdfMemberInfo("JoinTime", "mJoinTime", 0xAB4A6D00, TdfType.UInt32, 1, true), // JTIM
        new TdfMemberInfo("Permissions", "mPermissions", 0xC25CAD00, TdfType.Enum, 2, true), // PERM
        new TdfMemberInfo("NetworkAddress", "mNetworkAddress", 0xC2E97400, TdfType.Union, 3, true), // PNET
        new TdfMemberInfo("SlotId", "mSlotId", 0xCE990000, TdfType.UInt8, 4, true), // SID
        new TdfMemberInfo("User", "mUser", 0xD7397200, TdfType.Struct, 5, true), // USER
    ];
    private ITdfMember[] __members;

    private TdfMap<string, string> _memberAttributes = new(__typeInfos[0]);
    private TdfUInt32 _joinTime = new(__typeInfos[1]);
    private TdfEnum<Blaze3SDK.Blaze.Playgroups.MemberPermissions> _permissions = new(__typeInfos[2]);
    private TdfUnion<Blaze3SDK.Blaze.NetworkAddress> _networkAddress = new(__typeInfos[3]);
    private TdfUInt8 _slotId = new(__typeInfos[4]);
    private TdfStruct<Blaze3SDK.Blaze.UserIdentification?> _user = new(__typeInfos[5]);

    public PlaygroupMemberInfo()
    {
        __members = [
            _memberAttributes,
            _joinTime,
            _permissions,
            _networkAddress,
            _slotId,
            _user,
        ];
    }

    public override Tdf CreateNew() => new PlaygroupMemberInfo();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "PlaygroupMemberInfo";
    public override string GetFullClassName() => "Blaze::Playgroups::PlaygroupMemberInfo";

    public IDictionary<string, string> MemberAttributes
    {
        get => _memberAttributes.Value;
        set => _memberAttributes.Value = value;
    }

    public uint JoinTime
    {
        get => _joinTime.Value;
        set => _joinTime.Value = value;
    }

    public Blaze3SDK.Blaze.Playgroups.MemberPermissions Permissions
    {
        get => _permissions.Value;
        set => _permissions.Value = value;
    }

    public Blaze3SDK.Blaze.NetworkAddress NetworkAddress
    {
        get => _networkAddress.Value;
        set => _networkAddress.Value = value;
    }

    public byte SlotId
    {
        get => _slotId.Value;
        set => _slotId.Value = value;
    }

    public Blaze3SDK.Blaze.UserIdentification? User
    {
        get => _user.Value;
        set => _user.Value = value;
    }

}

