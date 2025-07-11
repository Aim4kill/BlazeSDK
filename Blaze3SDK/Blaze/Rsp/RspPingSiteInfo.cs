using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Rsp;

public class RspPingSiteInfo : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Alias", "mAlias", 0x86CA6100, TdfType.String, 0, true), // ALIA
        new TdfMemberInfo("Capacity", "mCapacity", 0x8E1C0000, TdfType.UInt32, 1, true), // CAP
        new TdfMemberInfo("Name", "mName", 0xBA1B6500, TdfType.String, 2, true), // NAME
    ];
    private ITdfMember[] __members;

    private TdfString _alias = new(__typeInfos[0]);
    private TdfUInt32 _capacity = new(__typeInfos[1]);
    private TdfString _name = new(__typeInfos[2]);

    public RspPingSiteInfo()
    {
        __members = [
            _alias,
            _capacity,
            _name,
        ];
    }

    public override Tdf CreateNew() => new RspPingSiteInfo();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "RspPingSiteInfo";
    public override string GetFullClassName() => "Blaze::Rsp::RspPingSiteInfo";

    public string Alias
    {
        get => _alias.Value;
        set => _alias.Value = value;
    }

    public uint Capacity
    {
        get => _capacity.Value;
        set => _capacity.Value = value;
    }

    public string Name
    {
        get => _name.Value;
        set => _name.Value = value;
    }

}

