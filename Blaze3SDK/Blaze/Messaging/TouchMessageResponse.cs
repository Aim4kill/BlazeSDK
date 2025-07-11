using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Messaging;

public class TouchMessageResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Count", "mCount", 0xB63BB400, TdfType.UInt32, 0, true), // MCNT
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _count = new(__typeInfos[0]);

    public TouchMessageResponse()
    {
        __members = [
            _count,
        ];
    }

    public override Tdf CreateNew() => new TouchMessageResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "TouchMessageResponse";
    public override string GetFullClassName() => "Blaze::Messaging::TouchMessageResponse";

    public uint Count
    {
        get => _count.Value;
        set => _count.Value = value;
    }

}

