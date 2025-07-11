using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Clubs;

public class CustClubSettings : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("CustOpt1", "mCustOpt1", 0x8EFC1100, TdfType.UInt32, 0, true), // COP1
        new TdfMemberInfo("CustOpt2", "mCustOpt2", 0x8EFC1200, TdfType.UInt32, 1, true), // COP2
        new TdfMemberInfo("CustOpt3", "mCustOpt3", 0x8EFC1300, TdfType.UInt32, 2, true), // COP3
        new TdfMemberInfo("CustOpt4", "mCustOpt4", 0x8EFC1400, TdfType.UInt32, 3, true), // COP4
        new TdfMemberInfo("CustOpt5", "mCustOpt5", 0x8EFC1500, TdfType.UInt32, 4, true), // COP5
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _custOpt1 = new(__typeInfos[0]);
    private TdfUInt32 _custOpt2 = new(__typeInfos[1]);
    private TdfUInt32 _custOpt3 = new(__typeInfos[2]);
    private TdfUInt32 _custOpt4 = new(__typeInfos[3]);
    private TdfUInt32 _custOpt5 = new(__typeInfos[4]);

    public CustClubSettings()
    {
        __members = [
            _custOpt1,
            _custOpt2,
            _custOpt3,
            _custOpt4,
            _custOpt5,
        ];
    }

    public override Tdf CreateNew() => new CustClubSettings();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "CustClubSettings";
    public override string GetFullClassName() => "Blaze::Clubs::CustClubSettings";

    public uint CustOpt1
    {
        get => _custOpt1.Value;
        set => _custOpt1.Value = value;
    }

    public uint CustOpt2
    {
        get => _custOpt2.Value;
        set => _custOpt2.Value = value;
    }

    public uint CustOpt3
    {
        get => _custOpt3.Value;
        set => _custOpt3.Value = value;
    }

    public uint CustOpt4
    {
        get => _custOpt4.Value;
        set => _custOpt4.Value = value;
    }

    public uint CustOpt5
    {
        get => _custOpt5.Value;
        set => _custOpt5.Value = value;
    }

}

