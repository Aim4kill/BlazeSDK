using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze;

public class UpdateUserSessionAttributeRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Key", "mKey", 0x874A6400, TdfType.UInt32, 0, true), // ATID
        new TdfMemberInfo("Remove", "mRemove", 0xBF097200, TdfType.Bool, 1, true), // OPER
        new TdfMemberInfo("Value", "mValue", 0xDA1B3500, TdfType.Int32, 2, true), // VALU
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _key = new(__typeInfos[0]);
    private TdfBool _remove = new(__typeInfos[1]);
    private TdfInt32 _value = new(__typeInfos[2]);

    public UpdateUserSessionAttributeRequest()
    {
        __members = [
            _key,
            _remove,
            _value,
        ];
    }

    public override Tdf CreateNew() => new UpdateUserSessionAttributeRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "UpdateUserSessionAttributeRequest";
    public override string GetFullClassName() => "Blaze::UpdateUserSessionAttributeRequest";

    public uint Key
    {
        get => _key.Value;
        set => _key.Value = value;
    }

    public bool Remove
    {
        get => _remove.Value;
        set => _remove.Value = value;
    }

    public int Value
    {
        get => _value.Value;
        set => _value.Value = value;
    }

}

