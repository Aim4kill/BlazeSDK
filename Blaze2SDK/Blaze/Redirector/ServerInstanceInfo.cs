using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Redirector;

public class ServerInstanceInfo : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Address", "mAddress", 0x86493200, TdfType.Union, 0, true), // ADDR
        new TdfMemberInfo("AddressRemaps", "mAddressRemaps", 0x86D87000, TdfType.List, 1, true), // AMAP
        new TdfMemberInfo("Messages", "mMessages", 0xB739F300, TdfType.List, 2, true), // MSGS
        new TdfMemberInfo("NameRemaps", "mNameRemaps", 0xBAD87000, TdfType.List, 3, true), // NMAP
        new TdfMemberInfo("Secure", "mSecure", 0xCE58F500, TdfType.Bool, 4, true), // SECU
        new TdfMemberInfo("DefaultDnsAddress", "mDefaultDnsAddress", 0xE24BB300, TdfType.UInt32, 5, true), // XDNS
    ];
    private ITdfMember[] __members;

    private TdfUnion<Blaze2SDK.Blaze.Redirector.ServerAddress> _address = new(__typeInfos[0]);
    private TdfList<Blaze2SDK.Blaze.Redirector.AddressRemapEntry> _addressRemaps = new(__typeInfos[1]);
    private TdfList<string> _messages = new(__typeInfos[2]);
    private TdfList<Blaze2SDK.Blaze.Redirector.NameRemapEntry> _nameRemaps = new(__typeInfos[3]);
    private TdfBool _secure = new(__typeInfos[4]);
    private TdfUInt32 _defaultDnsAddress = new(__typeInfos[5]);

    public ServerInstanceInfo()
    {
        __members = [
            _address,
            _addressRemaps,
            _messages,
            _nameRemaps,
            _secure,
            _defaultDnsAddress,
        ];
    }

    public override Tdf CreateNew() => new ServerInstanceInfo();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ServerInstanceInfo";
    public override string GetFullClassName() => "Blaze::Redirector::ServerInstanceInfo";

    public Blaze2SDK.Blaze.Redirector.ServerAddress Address
    {
        get => _address.Value;
        set => _address.Value = value;
    }

    public IList<Blaze2SDK.Blaze.Redirector.AddressRemapEntry> AddressRemaps
    {
        get => _addressRemaps.Value;
        set => _addressRemaps.Value = value;
    }

    public IList<string> Messages
    {
        get => _messages.Value;
        set => _messages.Value = value;
    }

    public IList<Blaze2SDK.Blaze.Redirector.NameRemapEntry> NameRemaps
    {
        get => _nameRemaps.Value;
        set => _nameRemaps.Value = value;
    }

    public bool Secure
    {
        get => _secure.Value;
        set => _secure.Value = value;
    }

    public uint DefaultDnsAddress
    {
        get => _defaultDnsAddress.Value;
        set => _defaultDnsAddress.Value = value;
    }

}

