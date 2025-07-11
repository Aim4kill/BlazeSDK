using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Authentication;

public class DecrementUseCount : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("UseCountConsumed", "mUseCountConsumed", 0xD63D2300, TdfType.UInt32, 0, true), // UCTC
        new TdfMemberInfo("UseCountRemain", "mUseCountRemain", 0xD63D3200, TdfType.UInt32, 1, true), // UCTR
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _useCountConsumed = new(__typeInfos[0]);
    private TdfUInt32 _useCountRemain = new(__typeInfos[1]);

    public DecrementUseCount()
    {
        __members = [
            _useCountConsumed,
            _useCountRemain,
        ];
    }

    public override Tdf CreateNew() => new DecrementUseCount();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "DecrementUseCount";
    public override string GetFullClassName() => "Blaze::Authentication::DecrementUseCount";

    public uint UseCountConsumed
    {
        get => _useCountConsumed.Value;
        set => _useCountConsumed.Value = value;
    }

    public uint UseCountRemain
    {
        get => _useCountRemain.Value;
        set => _useCountRemain.Value = value;
    }

}

