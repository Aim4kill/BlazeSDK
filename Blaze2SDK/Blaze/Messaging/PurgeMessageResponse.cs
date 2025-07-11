using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Messaging;

public class PurgeMessageResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Count", "mCount", 0xB63BB400, TdfType.UInt32, 0, true), // MCNT
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _count = new(__typeInfos[0]);

    public PurgeMessageResponse()
    {
        __members = [
            _count,
        ];
    }

    public override Tdf CreateNew() => new PurgeMessageResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "PurgeMessageResponse";
    public override string GetFullClassName() => "Blaze::Messaging::PurgeMessageResponse";

    public uint Count
    {
        get => _count.Value;
        set => _count.Value = value;
    }

}

