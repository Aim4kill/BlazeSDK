using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze;

public class SetUserInfoAttributeRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("AttributeBits", "mAttributeBits", 0x874D3600, TdfType.UInt64, 0, true), // ATTV
        new TdfMemberInfo("MaskBits", "mMaskBits", 0xB61CEB00, TdfType.UInt64, 1, true), // MASK
        new TdfMemberInfo("BlazeObjectIdList", "mBlazeObjectIdList", 0xD6CCF400, TdfType.List, 2, true), // ULST
    ];
    private ITdfMember[] __members;

    private TdfUInt64 _attributeBits = new(__typeInfos[0]);
    private TdfUInt64 _maskBits = new(__typeInfos[1]);
    private TdfList<ObjectId> _blazeObjectIdList = new(__typeInfos[2]);

    public SetUserInfoAttributeRequest()
    {
        __members = [
            _attributeBits,
            _maskBits,
            _blazeObjectIdList,
        ];
    }

    public override Tdf CreateNew() => new SetUserInfoAttributeRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "SetUserInfoAttributeRequest";
    public override string GetFullClassName() => "Blaze::SetUserInfoAttributeRequest";

    public ulong AttributeBits
    {
        get => _attributeBits.Value;
        set => _attributeBits.Value = value;
    }

    public ulong MaskBits
    {
        get => _maskBits.Value;
        set => _maskBits.Value = value;
    }

    public IList<ObjectId> BlazeObjectIdList
    {
        get => _blazeObjectIdList.Value;
        set => _blazeObjectIdList.Value = value;
    }

}

