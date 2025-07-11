using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Authentication;

public class ConsumecodeResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ExtRef", "mExtRef", 0x978CA600, TdfType.String, 0, true), // EXRF
        new TdfMemberInfo("KeyCode", "mKeyCode", 0xAE5E4000, TdfType.String, 1, true), // KEY
        new TdfMemberInfo("MultiUseCount", "mMultiUseCount", 0xB63BB400, TdfType.Int64, 2, true), // MCNT
        new TdfMemberInfo("MultiUseFlag", "mMultiUseFlag", 0xB66B2700, TdfType.UInt8, 3, true), // MFLG
        new TdfMemberInfo("MultiUseLimit", "mMultiUseLimit", 0xB6CB7400, TdfType.Int64, 4, true), // MLMT
        new TdfMemberInfo("ProductId", "mProductId", 0xC32A6400, TdfType.String, 5, true), // PRID
        new TdfMemberInfo("ProductName", "mProductName", 0xC32B6E00, TdfType.String, 6, true), // PRMN
        new TdfMemberInfo("Status", "mStatus", 0xCF487400, TdfType.Enum, 7, true), // STAT
        new TdfMemberInfo("UserId", "mUserId", 0xD6990000, TdfType.Int64, 8, true), // UID
    ];
    private ITdfMember[] __members;

    private TdfString _extRef = new(__typeInfos[0]);
    private TdfString _keyCode = new(__typeInfos[1]);
    private TdfInt64 _multiUseCount = new(__typeInfos[2]);
    private TdfUInt8 _multiUseFlag = new(__typeInfos[3]);
    private TdfInt64 _multiUseLimit = new(__typeInfos[4]);
    private TdfString _productId = new(__typeInfos[5]);
    private TdfString _productName = new(__typeInfos[6]);
    private TdfEnum<Blaze3SDK.Blaze.Authentication.KeymasterCodeStatus> _status = new(__typeInfos[7]);
    private TdfInt64 _userId = new(__typeInfos[8]);

    public ConsumecodeResponse()
    {
        __members = [
            _extRef,
            _keyCode,
            _multiUseCount,
            _multiUseFlag,
            _multiUseLimit,
            _productId,
            _productName,
            _status,
            _userId,
        ];
    }

    public override Tdf CreateNew() => new ConsumecodeResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ConsumecodeResponse";
    public override string GetFullClassName() => "Blaze::Authentication::ConsumecodeResponse";

    public string ExtRef
    {
        get => _extRef.Value;
        set => _extRef.Value = value;
    }

    public string KeyCode
    {
        get => _keyCode.Value;
        set => _keyCode.Value = value;
    }

    public long MultiUseCount
    {
        get => _multiUseCount.Value;
        set => _multiUseCount.Value = value;
    }

    public byte MultiUseFlag
    {
        get => _multiUseFlag.Value;
        set => _multiUseFlag.Value = value;
    }

    public long MultiUseLimit
    {
        get => _multiUseLimit.Value;
        set => _multiUseLimit.Value = value;
    }

    public string ProductId
    {
        get => _productId.Value;
        set => _productId.Value = value;
    }

    public string ProductName
    {
        get => _productName.Value;
        set => _productName.Value = value;
    }

    public Blaze3SDK.Blaze.Authentication.KeymasterCodeStatus Status
    {
        get => _status.Value;
        set => _status.Value = value;
    }

    public long UserId
    {
        get => _userId.Value;
        set => _userId.Value = value;
    }

}

