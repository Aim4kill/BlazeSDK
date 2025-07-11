using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Messaging;

public class DynamicConfig : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("MessageAttributeLimit", "mMessageAttributeLimit", 0x86D87800, TdfType.UInt32, 0, true), // AMAX
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _messageAttributeLimit = new(__typeInfos[0]);

    public DynamicConfig()
    {
        __members = [
            _messageAttributeLimit,
        ];
    }

    public override Tdf CreateNew() => new DynamicConfig();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "DynamicConfig";
    public override string GetFullClassName() => "Blaze::Messaging::DynamicConfig";

    public uint MessageAttributeLimit
    {
        get => _messageAttributeLimit.Value;
        set => _messageAttributeLimit.Value = value;
    }

}

