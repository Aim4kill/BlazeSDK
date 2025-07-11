using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Clubs;

public class CountMessagesResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Count", "mCount", 0x8F5BB400, TdfType.UInt32, 0, true), // CUNT
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _count = new(__typeInfos[0]);

    public CountMessagesResponse()
    {
        __members = [
            _count,
        ];
    }

    public override Tdf CreateNew() => new CountMessagesResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "CountMessagesResponse";
    public override string GetFullClassName() => "Blaze::Clubs::CountMessagesResponse";

    public uint Count
    {
        get => _count.Value;
        set => _count.Value = value;
    }

}

