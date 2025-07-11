using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze;

public class SetUserInfoAttributeRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Attribute", "mAttribute", 0x874D3600, TdfType.UInt64, 0, true), // ATTV
        new TdfMemberInfo("Mask", "mMask", 0xB61CEB00, TdfType.UInt64, 1, true), // MASK
        new TdfMemberInfo("BlazeObjectIdList", "mBlazeObjectIdList", 0xD6CCF400, TdfType.List, 2, true), // ULST
    ];
    private ITdfMember[] __members;

    private TdfUInt64 _attribute = new(__typeInfos[0]);
    private TdfUInt64 _mask = new(__typeInfos[1]);
    private TdfList<ulong> _blazeObjectIdList = new(__typeInfos[2]);

    public SetUserInfoAttributeRequest()
    {
        __members = [
            _attribute,
            _mask,
            _blazeObjectIdList,
        ];
    }

    public override Tdf CreateNew() => new SetUserInfoAttributeRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "SetUserInfoAttributeRequest";
    public override string GetFullClassName() => "Blaze::SetUserInfoAttributeRequest";

    public ulong Attribute
    {
        get => _attribute.Value;
        set => _attribute.Value = value;
    }

    public ulong Mask
    {
        get => _mask.Value;
        set => _mask.Value = value;
    }

    public IList<ulong> BlazeObjectIdList
    {
        get => _blazeObjectIdList.Value;
        set => _blazeObjectIdList.Value = value;
    }

}

