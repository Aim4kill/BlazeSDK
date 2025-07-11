using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.DynamicInetFilter;

public class CidrBlock : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Ip", "mIp", 0xA7000000, TdfType.String, 0, true), // IP
        new TdfMemberInfo("PrefixLength", "mPrefixLength", 0xC2C96E00, TdfType.UInt32, 1, true), // PLEN
    ];
    private ITdfMember[] __members;

    private TdfString _ip = new(__typeInfos[0]);
    private TdfUInt32 _prefixLength = new(__typeInfos[1]);

    public CidrBlock()
    {
        __members = [
            _ip,
            _prefixLength,
        ];
    }

    public override Tdf CreateNew() => new CidrBlock();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "CidrBlock";
    public override string GetFullClassName() => "Blaze::DynamicInetFilter::CidrBlock";

    public string Ip
    {
        get => _ip.Value;
        set => _ip.Value = value;
    }

    public uint PrefixLength
    {
        get => _prefixLength.Value;
        set => _prefixLength.Value = value;
    }

}

