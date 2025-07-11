using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze;

public class UserSessionExtendedData : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Address", "mAddress", 0x86493200, TdfType.Union, 0, true), // ADDR
        new TdfMemberInfo("BestPingSiteAlias", "mBestPingSiteAlias", 0x8B0CC000, TdfType.String, 1, true), // BPS
        new TdfMemberInfo("ClientAttributes", "mClientAttributes", 0x8ED87000, TdfType.Map, 2, true), // CMAP
        new TdfMemberInfo("Country", "mCountry", 0x8F4E4000, TdfType.String, 3, true), // CTY
        new TdfMemberInfo("ClientData", "mClientData", 0x8F687200, TdfType.Variable, 4, true), // CVAR
        new TdfMemberInfo("DataMap", "mDataMap", 0x92D87000, TdfType.Map, 5, true), // DMAP
        new TdfMemberInfo("HardwareFlags", "mHardwareFlags", 0xA379A700, TdfType.Enum, 6, true), // HWFG
        new TdfMemberInfo("LatencyList", "mLatencyList", 0xC33B2D00, TdfType.List, 7, true), // PSLM
        new TdfMemberInfo("QosData", "mQosData", 0xC6487400, TdfType.Struct, 8, true), // QDAT
        new TdfMemberInfo("UserInfoAttribute", "mUserInfoAttribute", 0xD61D3400, TdfType.UInt64, 9, true), // UATT
        new TdfMemberInfo("BlazeObjectIdList", "mBlazeObjectIdList", 0xD6CCF400, TdfType.List, 10, true), // ULST
    ];
    private ITdfMember[] __members;

    private TdfUnion<Blaze3SDK.Blaze.NetworkAddress> _address = new(__typeInfos[0]);
    private TdfString _bestPingSiteAlias = new(__typeInfos[1]);
    private TdfMap<uint, int> _clientAttributes = new(__typeInfos[2]);
    private TdfString _country = new(__typeInfos[3]);
    private TdfVariable _clientData = new(__typeInfos[4]);
    private TdfMap<uint, long> _dataMap = new(__typeInfos[5]);
    private TdfEnum<Blaze3SDK.Blaze.HardwareFlags> _hardwareFlags = new(__typeInfos[6]);
    private TdfList<int> _latencyList = new(__typeInfos[7]);
    private TdfStruct<Blaze3SDK.Blaze.Util.NetworkQosData?> _qosData = new(__typeInfos[8]);
    private TdfUInt64 _userInfoAttribute = new(__typeInfos[9]);
    private TdfList<ObjectId> _blazeObjectIdList = new(__typeInfos[10]);

    public UserSessionExtendedData()
    {
        __members = [
            _address,
            _bestPingSiteAlias,
            _clientAttributes,
            _country,
            _clientData,
            _dataMap,
            _hardwareFlags,
            _latencyList,
            _qosData,
            _userInfoAttribute,
            _blazeObjectIdList,
        ];
    }

    public override Tdf CreateNew() => new UserSessionExtendedData();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "UserSessionExtendedData";
    public override string GetFullClassName() => "Blaze::UserSessionExtendedData";

    public Blaze3SDK.Blaze.NetworkAddress Address
    {
        get => _address.Value;
        set => _address.Value = value;
    }

    public string BestPingSiteAlias
    {
        get => _bestPingSiteAlias.Value;
        set => _bestPingSiteAlias.Value = value;
    }

    public IDictionary<uint, int> ClientAttributes
    {
        get => _clientAttributes.Value;
        set => _clientAttributes.Value = value;
    }

    public string Country
    {
        get => _country.Value;
        set => _country.Value = value;
    }

    public object? ClientData
    {
        get => _clientData.Value;
        set => _clientData.Value = value;
    }

    public IDictionary<uint, long> DataMap
    {
        get => _dataMap.Value;
        set => _dataMap.Value = value;
    }

    public Blaze3SDK.Blaze.HardwareFlags HardwareFlags
    {
        get => _hardwareFlags.Value;
        set => _hardwareFlags.Value = value;
    }

    public IList<int> LatencyList
    {
        get => _latencyList.Value;
        set => _latencyList.Value = value;
    }

    public Blaze3SDK.Blaze.Util.NetworkQosData? QosData
    {
        get => _qosData.Value;
        set => _qosData.Value = value;
    }

    public ulong UserInfoAttribute
    {
        get => _userInfoAttribute.Value;
        set => _userInfoAttribute.Value = value;
    }

    public IList<ObjectId> BlazeObjectIdList
    {
        get => _blazeObjectIdList.Value;
        set => _blazeObjectIdList.Value = value;
    }

}

