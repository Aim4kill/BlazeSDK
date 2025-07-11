using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Redirector;

public class ServiceRemoveInfo : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ServiceName", "mServiceName", 0xBA1B6500, TdfType.String, 0, true), // NAME
    ];
    private ITdfMember[] __members;

    private TdfString _serviceName = new(__typeInfos[0]);

    public ServiceRemoveInfo()
    {
        __members = [
            _serviceName,
        ];
    }

    public override Tdf CreateNew() => new ServiceRemoveInfo();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ServiceRemoveInfo";
    public override string GetFullClassName() => "Blaze::Redirector::ServiceRemoveInfo";

    public string ServiceName
    {
        get => _serviceName.Value;
        set => _serviceName.Value = value;
    }

}

