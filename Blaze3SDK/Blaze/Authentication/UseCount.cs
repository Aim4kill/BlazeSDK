using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Authentication;

public class UseCount : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("UseCount", "mUseCount", 0xD63BB400, TdfType.UInt32, 0, true), // UCNT
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _useCount = new(__typeInfos[0]);

    public UseCount()
    {
        __members = [
            _useCount,
        ];
    }

    public override Tdf CreateNew() => new UseCount();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "UseCount";
    public override string GetFullClassName() => "Blaze::Authentication::UseCount";

    public uint mUseCount
    {
        get => _useCount.Value;
        set => _useCount.Value = value;
    }

}

