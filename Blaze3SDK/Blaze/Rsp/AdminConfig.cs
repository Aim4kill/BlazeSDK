using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Rsp;

public class AdminConfig : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("MaxMapRotationEntries", "mMaxMapRotationEntries", 0xB72B7800, TdfType.UInt16, 0, true), // MRMX
        new TdfMemberInfo("MaxPurchaseQuantity", "mMaxPurchaseQuantity", 0xC31B7800, TdfType.UInt32, 1, true), // PQMX
        new TdfMemberInfo("MaxServerAdmins", "mMaxServerAdmins", 0xCE1B7800, TdfType.UInt16, 2, true), // SAMX
        new TdfMemberInfo("MaxServerBans", "mMaxServerBans", 0xCE2B7800, TdfType.UInt16, 3, true), // SBMX
        new TdfMemberInfo("ServerExpiredPeriod", "mServerExpiredPeriod", 0xCE5E3000, TdfType.TimeValue, 4, true), // SEXP
        new TdfMemberInfo("ServerExtensionPeriod", "mServerExtensionPeriod", 0xCE5E3400, TdfType.TimeValue, 5, true), // SEXT
        new TdfMemberInfo("ServerReminderPeriod", "mServerReminderPeriod", 0xCF296D00, TdfType.TimeValue, 6, true), // SREM
        new TdfMemberInfo("MaxServerVips", "mMaxServerVips", 0xCF6B7800, TdfType.UInt16, 7, true), // SVMX
        new TdfMemberInfo("MaxAdminServersPerUser", "mMaxAdminServersPerUser", 0xD61B7800, TdfType.UInt16, 8, true), // UAMX
        new TdfMemberInfo("MaxOwnedServersPerUser", "mMaxOwnedServersPerUser", 0xD6FB7800, TdfType.UInt16, 9, true), // UOMX
    ];
    private ITdfMember[] __members;

    private TdfUInt16 _maxMapRotationEntries = new(__typeInfos[0]);
    private TdfUInt32 _maxPurchaseQuantity = new(__typeInfos[1]);
    private TdfUInt16 _maxServerAdmins = new(__typeInfos[2]);
    private TdfUInt16 _maxServerBans = new(__typeInfos[3]);
    private TdfTimeValue _serverExpiredPeriod = new(__typeInfos[4]);
    private TdfTimeValue _serverExtensionPeriod = new(__typeInfos[5]);
    private TdfTimeValue _serverReminderPeriod = new(__typeInfos[6]);
    private TdfUInt16 _maxServerVips = new(__typeInfos[7]);
    private TdfUInt16 _maxAdminServersPerUser = new(__typeInfos[8]);
    private TdfUInt16 _maxOwnedServersPerUser = new(__typeInfos[9]);

    public AdminConfig()
    {
        __members = [
            _maxMapRotationEntries,
            _maxPurchaseQuantity,
            _maxServerAdmins,
            _maxServerBans,
            _serverExpiredPeriod,
            _serverExtensionPeriod,
            _serverReminderPeriod,
            _maxServerVips,
            _maxAdminServersPerUser,
            _maxOwnedServersPerUser,
        ];
    }

    public override Tdf CreateNew() => new AdminConfig();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "AdminConfig";
    public override string GetFullClassName() => "Blaze::Rsp::AdminConfig";

    public ushort MaxMapRotationEntries
    {
        get => _maxMapRotationEntries.Value;
        set => _maxMapRotationEntries.Value = value;
    }

    public uint MaxPurchaseQuantity
    {
        get => _maxPurchaseQuantity.Value;
        set => _maxPurchaseQuantity.Value = value;
    }

    public ushort MaxServerAdmins
    {
        get => _maxServerAdmins.Value;
        set => _maxServerAdmins.Value = value;
    }

    public ushort MaxServerBans
    {
        get => _maxServerBans.Value;
        set => _maxServerBans.Value = value;
    }

    public TimeValue ServerExpiredPeriod
    {
        get => _serverExpiredPeriod.Value;
        set => _serverExpiredPeriod.Value = value;
    }

    public TimeValue ServerExtensionPeriod
    {
        get => _serverExtensionPeriod.Value;
        set => _serverExtensionPeriod.Value = value;
    }

    public TimeValue ServerReminderPeriod
    {
        get => _serverReminderPeriod.Value;
        set => _serverReminderPeriod.Value = value;
    }

    public ushort MaxServerVips
    {
        get => _maxServerVips.Value;
        set => _maxServerVips.Value = value;
    }

    public ushort MaxAdminServersPerUser
    {
        get => _maxAdminServersPerUser.Value;
        set => _maxAdminServersPerUser.Value = value;
    }

    public ushort MaxOwnedServersPerUser
    {
        get => _maxOwnedServersPerUser.Value;
        set => _maxOwnedServersPerUser.Value = value;
    }

}

