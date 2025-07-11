using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Authentication;

public class ConsumecodeRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("IsCdKey", "mIsCdKey", 0x8E4AF900, TdfType.Bool, 0, true), // CDKY
        new TdfMemberInfo("DeviceId", "mDeviceId", 0x925A6400, TdfType.UInt32, 1, true), // DEID
        new TdfMemberInfo("GroupName", "mGroupName", 0x9EE86D00, TdfType.String, 2, true), // GNAM
        new TdfMemberInfo("Code", "mCode", 0xAE5E4000, TdfType.String, 3, true), // KEY
        new TdfMemberInfo("ProductId", "mProductId", 0xC2990000, TdfType.String, 4, true), // PID
        new TdfMemberInfo("IsBindPersona", "mIsBindPersona", 0xC2EA6400, TdfType.Bool, 5, true), // PNID
    ];
    private ITdfMember[] __members;

    private TdfBool _isCdKey = new(__typeInfos[0]);
    private TdfUInt32 _deviceId = new(__typeInfos[1]);
    private TdfString _groupName = new(__typeInfos[2]);
    private TdfString _code = new(__typeInfos[3]);
    private TdfString _productId = new(__typeInfos[4]);
    private TdfBool _isBindPersona = new(__typeInfos[5]);

    public ConsumecodeRequest()
    {
        __members = [
            _isCdKey,
            _deviceId,
            _groupName,
            _code,
            _productId,
            _isBindPersona,
        ];
    }

    public override Tdf CreateNew() => new ConsumecodeRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ConsumecodeRequest";
    public override string GetFullClassName() => "Blaze::Authentication::ConsumecodeRequest";

    public bool IsCdKey
    {
        get => _isCdKey.Value;
        set => _isCdKey.Value = value;
    }

    public uint DeviceId
    {
        get => _deviceId.Value;
        set => _deviceId.Value = value;
    }

    public string GroupName
    {
        get => _groupName.Value;
        set => _groupName.Value = value;
    }

    public string Code
    {
        get => _code.Value;
        set => _code.Value = value;
    }

    public string ProductId
    {
        get => _productId.Value;
        set => _productId.Value = value;
    }

    public bool IsBindPersona
    {
        get => _isBindPersona.Value;
        set => _isBindPersona.Value = value;
    }

}

