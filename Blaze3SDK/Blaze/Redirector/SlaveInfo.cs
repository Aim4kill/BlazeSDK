using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Redirector;

public class SlaveInfo : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Instance", "mInstance", 0xA6ECF400, TdfType.Struct, 0, true), // INST
        new TdfMemberInfo("ServiceName", "mServiceName", 0xBA1B6500, TdfType.String, 1, true), // NAME
        new TdfMemberInfo("ServiceNames", "mServiceNames", 0xCEEB7300, TdfType.List, 2, true), // SNMS
        new TdfMemberInfo("Type", "mType", 0xD39C2500, TdfType.Enum, 3, true), // TYPE
    ];
    private ITdfMember[] __members;

    private TdfStruct<Blaze3SDK.Blaze.Redirector.ServerInstance?> _instance = new(__typeInfos[0]);
    private TdfString _serviceName = new(__typeInfos[1]);
    private TdfList<string> _serviceNames = new(__typeInfos[2]);
    private TdfEnum<Blaze3SDK.Blaze.Redirector.InstanceType> _type = new(__typeInfos[3]);

    public SlaveInfo()
    {
        __members = [
            _instance,
            _serviceName,
            _serviceNames,
            _type,
        ];
    }

    public override Tdf CreateNew() => new SlaveInfo();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "SlaveInfo";
    public override string GetFullClassName() => "Blaze::Redirector::SlaveInfo";

    public Blaze3SDK.Blaze.Redirector.ServerInstance? Instance
    {
        get => _instance.Value;
        set => _instance.Value = value;
    }

    public string ServiceName
    {
        get => _serviceName.Value;
        set => _serviceName.Value = value;
    }

    public IList<string> ServiceNames
    {
        get => _serviceNames.Value;
        set => _serviceNames.Value = value;
    }

    public Blaze3SDK.Blaze.Redirector.InstanceType Type
    {
        get => _type.Value;
        set => _type.Value = value;
    }

}

