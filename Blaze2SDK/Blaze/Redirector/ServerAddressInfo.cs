using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Redirector;

public class ServerAddressInfo : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Address", "mAddress", 0x86493200, TdfType.Union, 0, true), // ADDR
        new TdfMemberInfo("Type", "mType", 0xD39C2500, TdfType.Enum, 1, true), // TYPE
    ];
    private ITdfMember[] __members;

    private TdfUnion<Blaze2SDK.Blaze.Redirector.ServerAddress> _address = new(__typeInfos[0]);
    private TdfEnum<Blaze2SDK.Blaze.Redirector.ServerAddressType> _type = new(__typeInfos[1]);

    public ServerAddressInfo()
    {
        __members = [
            _address,
            _type,
        ];
    }

    public override Tdf CreateNew() => new ServerAddressInfo();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ServerAddressInfo";
    public override string GetFullClassName() => "Blaze::Redirector::ServerAddressInfo";

    public Blaze2SDK.Blaze.Redirector.ServerAddress Address
    {
        get => _address.Value;
        set => _address.Value = value;
    }

    public Blaze2SDK.Blaze.Redirector.ServerAddressType Type
    {
        get => _type.Value;
        set => _type.Value = value;
    }

}

