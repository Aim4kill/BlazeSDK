using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Playgroups;

public class PlaygroupInfo : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("PlaygroupAttributes", "mPlaygroupAttributes", 0x874D3200, TdfType.Map, 0, true), // ATTR
        new TdfMemberInfo("EnableVoIP", "mEnableVoIP", 0x96E8B600, TdfType.Bool, 1, true), // ENBV
        new TdfMemberInfo("HostNetworkAddress", "mHostNetworkAddress", 0xA2E97400, TdfType.Union, 2, true), // HNET
        new TdfMemberInfo("HostSlotId", "mHostSlotId", 0xA33A6400, TdfType.UInt8, 3, true), // HSID
        new TdfMemberInfo("PlaygroupJoinability", "mPlaygroupJoinability", 0xAAFA6E00, TdfType.Enum, 4, true), // JOIN
        new TdfMemberInfo("MaxMembers", "mMaxMembers", 0xB6CA6D00, TdfType.UInt16, 5, true), // MLIM
        new TdfMemberInfo("Name", "mName", 0xBA1B6500, TdfType.String, 6, true), // NAME
        new TdfMemberInfo("NetworkTopology", "mNetworkTopology", 0xBB4BF000, TdfType.Enum, 7, true), // NTOP
        new TdfMemberInfo("OwnerBlazeId", "mOwnerBlazeId", 0xBF7BB200, TdfType.Int64, 8, true), // OWNR
        new TdfMemberInfo("Id", "mId", 0xC27A6400, TdfType.UInt32, 9, true), // PGID
        new TdfMemberInfo("PresenceMode", "mPresenceMode", 0xC3297300, TdfType.Enum, 10, true), // PRES
        new TdfMemberInfo("UniqueKey", "mUniqueKey", 0xD6B97900, TdfType.String, 11, true), // UKEY
        new TdfMemberInfo("HasPresence", "mHasPresence", 0xD70CB300, TdfType.Bool, 12, true), // UPRS
        new TdfMemberInfo("UUID", "mUUID", 0xD75A6400, TdfType.String, 13, true), // UUID
        new TdfMemberInfo("VoipNetwork", "mVoipNetwork", 0xDAFA7000, TdfType.Enum, 14, true), // VOIP
        new TdfMemberInfo("XnetNonce", "mXnetNonce", 0xE2EBA300, TdfType.Blob, 15, true), // XNNC
        new TdfMemberInfo("XnetSession", "mXnetSession", 0xE3397300, TdfType.Blob, 16, true), // XSES
    ];
    private ITdfMember[] __members;

    private TdfMap<string, string> _playgroupAttributes = new(__typeInfos[0]);
    private TdfBool _enableVoIP = new(__typeInfos[1]);
    private TdfUnion<Blaze3SDK.Blaze.NetworkAddress> _hostNetworkAddress = new(__typeInfos[2]);
    private TdfUInt8 _hostSlotId = new(__typeInfos[3]);
    private TdfEnum<Blaze3SDK.Blaze.Playgroups.PlaygroupJoinability> _playgroupJoinability = new(__typeInfos[4]);
    private TdfUInt16 _maxMembers = new(__typeInfos[5]);
    private TdfString _name = new(__typeInfos[6]);
    private TdfEnum<Blaze3SDK.Blaze.GameNetworkTopology> _networkTopology = new(__typeInfos[7]);
    private TdfInt64 _ownerBlazeId = new(__typeInfos[8]);
    private TdfUInt32 _id = new(__typeInfos[9]);
    private TdfEnum<Blaze3SDK.Blaze.PresenceMode> _presenceMode = new(__typeInfos[10]);
    private TdfString _uniqueKey = new(__typeInfos[11]);
    private TdfBool _hasPresence = new(__typeInfos[12]);
    private TdfString _uUID = new(__typeInfos[13]);
    private TdfEnum<Blaze3SDK.Blaze.VoipTopology> _voipNetwork = new(__typeInfos[14]);
    private TdfBlob _xnetNonce = new(__typeInfos[15]);
    private TdfBlob _xnetSession = new(__typeInfos[16]);

    public PlaygroupInfo()
    {
        __members = [
            _playgroupAttributes,
            _enableVoIP,
            _hostNetworkAddress,
            _hostSlotId,
            _playgroupJoinability,
            _maxMembers,
            _name,
            _networkTopology,
            _ownerBlazeId,
            _id,
            _presenceMode,
            _uniqueKey,
            _hasPresence,
            _uUID,
            _voipNetwork,
            _xnetNonce,
            _xnetSession,
        ];
    }

    public override Tdf CreateNew() => new PlaygroupInfo();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "PlaygroupInfo";
    public override string GetFullClassName() => "Blaze::Playgroups::PlaygroupInfo";

    public IDictionary<string, string> PlaygroupAttributes
    {
        get => _playgroupAttributes.Value;
        set => _playgroupAttributes.Value = value;
    }

    public bool EnableVoIP
    {
        get => _enableVoIP.Value;
        set => _enableVoIP.Value = value;
    }

    public Blaze3SDK.Blaze.NetworkAddress HostNetworkAddress
    {
        get => _hostNetworkAddress.Value;
        set => _hostNetworkAddress.Value = value;
    }

    public byte HostSlotId
    {
        get => _hostSlotId.Value;
        set => _hostSlotId.Value = value;
    }

    public Blaze3SDK.Blaze.Playgroups.PlaygroupJoinability PlaygroupJoinability
    {
        get => _playgroupJoinability.Value;
        set => _playgroupJoinability.Value = value;
    }

    public ushort MaxMembers
    {
        get => _maxMembers.Value;
        set => _maxMembers.Value = value;
    }

    public string Name
    {
        get => _name.Value;
        set => _name.Value = value;
    }

    public Blaze3SDK.Blaze.GameNetworkTopology NetworkTopology
    {
        get => _networkTopology.Value;
        set => _networkTopology.Value = value;
    }

    public long OwnerBlazeId
    {
        get => _ownerBlazeId.Value;
        set => _ownerBlazeId.Value = value;
    }

    public uint Id
    {
        get => _id.Value;
        set => _id.Value = value;
    }

    public Blaze3SDK.Blaze.PresenceMode PresenceMode
    {
        get => _presenceMode.Value;
        set => _presenceMode.Value = value;
    }

    public string UniqueKey
    {
        get => _uniqueKey.Value;
        set => _uniqueKey.Value = value;
    }

    public bool HasPresence
    {
        get => _hasPresence.Value;
        set => _hasPresence.Value = value;
    }

    public string UUID
    {
        get => _uUID.Value;
        set => _uUID.Value = value;
    }

    public Blaze3SDK.Blaze.VoipTopology VoipNetwork
    {
        get => _voipNetwork.Value;
        set => _voipNetwork.Value = value;
    }

    public byte[] XnetNonce
    {
        get => _xnetNonce.Value;
        set => _xnetNonce.Value = value;
    }

    public byte[] XnetSession
    {
        get => _xnetSession.Value;
        set => _xnetSession.Value = value;
    }

}

