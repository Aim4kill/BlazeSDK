using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameManager;

public class SetNetworkQosRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("NetworkQosData", "mNetworkQosData", 0xBB1BF300, TdfType.Struct, 0, true), // NQOS
    ];
    private ITdfMember[] __members;

    private TdfStruct<Blaze3SDK.Blaze.Util.NetworkQosData?> _networkQosData = new(__typeInfos[0]);

    public SetNetworkQosRequest()
    {
        __members = [
            _networkQosData,
        ];
    }

    public override Tdf CreateNew() => new SetNetworkQosRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "SetNetworkQosRequest";
    public override string GetFullClassName() => "Blaze::GameManager::SetNetworkQosRequest";

    public Blaze3SDK.Blaze.Util.NetworkQosData? NetworkQosData
    {
        get => _networkQosData.Value;
        set => _networkQosData.Value = value;
    }

}

