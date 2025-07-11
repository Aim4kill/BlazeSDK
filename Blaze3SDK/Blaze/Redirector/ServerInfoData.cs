using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Redirector;

public class ServerInfoData : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("AddressRemaps", "mAddressRemaps", 0x86D87000, TdfType.List, 0, true), // AMAP
        new TdfMemberInfo("BuildTarget", "mBuildTarget", 0x8B49F400, TdfType.String, 1, true), // BTGT
        new TdfMemberInfo("BuildTime", "mBuildTime", 0x8B4A6D00, TdfType.String, 2, true), // BTIM
        new TdfMemberInfo("ConfigVersion", "mConfigVersion", 0x8E7DB300, TdfType.String, 3, true), // CGVS
        new TdfMemberInfo("CompatibleClientVersions", "mCompatibleClientVersions", 0x8F697200, TdfType.List, 4, true), // CVER
        new TdfMemberInfo("DepotLocation", "mDepotLocation", 0x925C2F00, TdfType.String, 5, true), // DEPO
        new TdfMemberInfo("Instances", "mInstances", 0xA6ECF400, TdfType.List, 6, true), // INST
        new TdfMemberInfo("IncompatibleClientVersions", "mIncompatibleClientVersions", 0xA7697200, TdfType.List, 7, true), // IVER
        new TdfMemberInfo("BuildLocation", "mBuildLocation", 0xB2F8EE00, TdfType.String, 8, true), // LOCN
        new TdfMemberInfo("MasterInstance", "mMasterInstance", 0xB73D3200, TdfType.Struct, 9, true), // MSTR
        new TdfMemberInfo("Name", "mName", 0xBA1B6500, TdfType.String, 10, true), // NAME
        new TdfMemberInfo("PersonaNamespace", "mPersonaNamespace", 0xBA1CF000, TdfType.String, 11, true), // NASP
        new TdfMemberInfo("NameRemaps", "mNameRemaps", 0xBAD87000, TdfType.List, 12, true), // NMAP
        new TdfMemberInfo("Platform", "mPlatform", 0xC2C87400, TdfType.String, 13, true), // PLAT
        new TdfMemberInfo("ServiceNames", "mServiceNames", 0xCEEB7300, TdfType.List, 14, true), // SNMS
        new TdfMemberInfo("DefaultServiceId", "mDefaultServiceId", 0xCF6A6400, TdfType.UInt32, 15, true), // SVID
        new TdfMemberInfo("Version", "mVersion", 0xDA5CB300, TdfType.String, 16, true), // VERS
        new TdfMemberInfo("DefaultDnsAddress", "mDefaultDnsAddress", 0xE24BB300, TdfType.UInt32, 17, true), // XDNS
        new TdfMemberInfo("AuxMasters", "mAuxMasters", 0xE2DCF400, TdfType.List, 18, true), // XMST
        new TdfMemberInfo("AuxSlaves", "mAuxSlaves", 0xE33B3600, TdfType.List, 19, true), // XSLV
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze3SDK.Blaze.Redirector.AddressRemapEntry> _addressRemaps = new(__typeInfos[0]);
    private TdfString _buildTarget = new(__typeInfos[1]);
    private TdfString _buildTime = new(__typeInfos[2]);
    private TdfString _configVersion = new(__typeInfos[3]);
    private TdfList<string> _compatibleClientVersions = new(__typeInfos[4]);
    private TdfString _depotLocation = new(__typeInfos[5]);
    private TdfList<Blaze3SDK.Blaze.Redirector.ServerInstance> _instances = new(__typeInfos[6]);
    private TdfList<string> _incompatibleClientVersions = new(__typeInfos[7]);
    private TdfString _buildLocation = new(__typeInfos[8]);
    private TdfStruct<Blaze3SDK.Blaze.Redirector.ServerInstance?> _masterInstance = new(__typeInfos[9]);
    private TdfString _name = new(__typeInfos[10]);
    private TdfString _personaNamespace = new(__typeInfos[11]);
    private TdfList<Blaze3SDK.Blaze.Redirector.NameRemapEntry> _nameRemaps = new(__typeInfos[12]);
    private TdfString _platform = new(__typeInfos[13]);
    private TdfList<string> _serviceNames = new(__typeInfos[14]);
    private TdfUInt32 _defaultServiceId = new(__typeInfos[15]);
    private TdfString _version = new(__typeInfos[16]);
    private TdfUInt32 _defaultDnsAddress = new(__typeInfos[17]);
    private TdfList<Blaze3SDK.Blaze.Redirector.ServerInstance> _auxMasters = new(__typeInfos[18]);
    private TdfList<Blaze3SDK.Blaze.Redirector.ServerInstance> _auxSlaves = new(__typeInfos[19]);

    public ServerInfoData()
    {
        __members = [
            _addressRemaps,
            _buildTarget,
            _buildTime,
            _configVersion,
            _compatibleClientVersions,
            _depotLocation,
            _instances,
            _incompatibleClientVersions,
            _buildLocation,
            _masterInstance,
            _name,
            _personaNamespace,
            _nameRemaps,
            _platform,
            _serviceNames,
            _defaultServiceId,
            _version,
            _defaultDnsAddress,
            _auxMasters,
            _auxSlaves,
        ];
    }

    public override Tdf CreateNew() => new ServerInfoData();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ServerInfoData";
    public override string GetFullClassName() => "Blaze::Redirector::ServerInfoData";

    public IList<Blaze3SDK.Blaze.Redirector.AddressRemapEntry> AddressRemaps
    {
        get => _addressRemaps.Value;
        set => _addressRemaps.Value = value;
    }

    public string BuildTarget
    {
        get => _buildTarget.Value;
        set => _buildTarget.Value = value;
    }

    public string BuildTime
    {
        get => _buildTime.Value;
        set => _buildTime.Value = value;
    }

    public string ConfigVersion
    {
        get => _configVersion.Value;
        set => _configVersion.Value = value;
    }

    public IList<string> CompatibleClientVersions
    {
        get => _compatibleClientVersions.Value;
        set => _compatibleClientVersions.Value = value;
    }

    public string DepotLocation
    {
        get => _depotLocation.Value;
        set => _depotLocation.Value = value;
    }

    public IList<Blaze3SDK.Blaze.Redirector.ServerInstance> Instances
    {
        get => _instances.Value;
        set => _instances.Value = value;
    }

    public IList<string> IncompatibleClientVersions
    {
        get => _incompatibleClientVersions.Value;
        set => _incompatibleClientVersions.Value = value;
    }

    public string BuildLocation
    {
        get => _buildLocation.Value;
        set => _buildLocation.Value = value;
    }

    public Blaze3SDK.Blaze.Redirector.ServerInstance? MasterInstance
    {
        get => _masterInstance.Value;
        set => _masterInstance.Value = value;
    }

    public string Name
    {
        get => _name.Value;
        set => _name.Value = value;
    }

    public string PersonaNamespace
    {
        get => _personaNamespace.Value;
        set => _personaNamespace.Value = value;
    }

    public IList<Blaze3SDK.Blaze.Redirector.NameRemapEntry> NameRemaps
    {
        get => _nameRemaps.Value;
        set => _nameRemaps.Value = value;
    }

    public string Platform
    {
        get => _platform.Value;
        set => _platform.Value = value;
    }

    public IList<string> ServiceNames
    {
        get => _serviceNames.Value;
        set => _serviceNames.Value = value;
    }

    public uint DefaultServiceId
    {
        get => _defaultServiceId.Value;
        set => _defaultServiceId.Value = value;
    }

    public string Version
    {
        get => _version.Value;
        set => _version.Value = value;
    }

    public uint DefaultDnsAddress
    {
        get => _defaultDnsAddress.Value;
        set => _defaultDnsAddress.Value = value;
    }

    public IList<Blaze3SDK.Blaze.Redirector.ServerInstance> AuxMasters
    {
        get => _auxMasters.Value;
        set => _auxMasters.Value = value;
    }

    public IList<Blaze3SDK.Blaze.Redirector.ServerInstance> AuxSlaves
    {
        get => _auxSlaves.Value;
        set => _auxSlaves.Value = value;
    }

}

