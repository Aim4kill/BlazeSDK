using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Authentication;

public class ModifyEntitlement2Request : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("UseCount", "mUseCount", 0x8EFD6E00, TdfType.String, 0, true), // COUN
        new TdfMemberInfo("EntitlementId", "mEntitlementId", 0x96990000, TdfType.Int64, 1, true), // EID
        new TdfMemberInfo("Termination", "mTermination", 0x978C2900, TdfType.String, 2, true), // EXPI
        new TdfMemberInfo("Status", "mStatus", 0xCF487400, TdfType.Enum, 3, true), // STAT
        new TdfMemberInfo("StatusReasonCode", "mStatusReasonCode", 0xCF4CA300, TdfType.Enum, 4, true), // STRC
        new TdfMemberInfo("Version", "mVersion", 0xDA5CB300, TdfType.UInt32, 5, true), // VERS
    ];
    private ITdfMember[] __members;

    private TdfString _useCount = new(__typeInfos[0]);
    private TdfInt64 _entitlementId = new(__typeInfos[1]);
    private TdfString _termination = new(__typeInfos[2]);
    private TdfEnum<Blaze3SDK.Blaze.Authentication.EntitlementStatus> _status = new(__typeInfos[3]);
    private TdfEnum<Blaze3SDK.Blaze.Authentication.StatusReason> _statusReasonCode = new(__typeInfos[4]);
    private TdfUInt32 _version = new(__typeInfos[5]);

    public ModifyEntitlement2Request()
    {
        __members = [
            _useCount,
            _entitlementId,
            _termination,
            _status,
            _statusReasonCode,
            _version,
        ];
    }

    public override Tdf CreateNew() => new ModifyEntitlement2Request();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ModifyEntitlement2Request";
    public override string GetFullClassName() => "Blaze::Authentication::ModifyEntitlement2Request";

    public string UseCount
    {
        get => _useCount.Value;
        set => _useCount.Value = value;
    }

    public long EntitlementId
    {
        get => _entitlementId.Value;
        set => _entitlementId.Value = value;
    }

    public string Termination
    {
        get => _termination.Value;
        set => _termination.Value = value;
    }

    public Blaze3SDK.Blaze.Authentication.EntitlementStatus Status
    {
        get => _status.Value;
        set => _status.Value = value;
    }

    public Blaze3SDK.Blaze.Authentication.StatusReason StatusReasonCode
    {
        get => _statusReasonCode.Value;
        set => _statusReasonCode.Value = value;
    }

    public uint Version
    {
        get => _version.Value;
        set => _version.Value = value;
    }

}

