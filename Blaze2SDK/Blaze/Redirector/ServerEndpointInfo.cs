using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Redirector;

public class ServerEndpointInfo : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Addresses", "mAddresses", 0x864CB300, TdfType.List, 0, true), // ADRS
        new TdfMemberInfo("Channel", "mChannel", 0x8E886E00, TdfType.String, 1, true), // CHAN
        new TdfMemberInfo("Decoder", "mDecoder", 0x9258C000, TdfType.String, 2, true), // DEC
        new TdfMemberInfo("Encoder", "mEncoder", 0x96E8C000, TdfType.String, 3, true), // ENC
        new TdfMemberInfo("Protocol", "mProtocol", 0xC32BF400, TdfType.String, 4, true), // PROT
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze2SDK.Blaze.Redirector.ServerAddressInfo> _addresses = new(__typeInfos[0]);
    private TdfString _channel = new(__typeInfos[1]);
    private TdfString _decoder = new(__typeInfos[2]);
    private TdfString _encoder = new(__typeInfos[3]);
    private TdfString _protocol = new(__typeInfos[4]);

    public ServerEndpointInfo()
    {
        __members = [
            _addresses,
            _channel,
            _decoder,
            _encoder,
            _protocol,
        ];
    }

    public override Tdf CreateNew() => new ServerEndpointInfo();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ServerEndpointInfo";
    public override string GetFullClassName() => "Blaze::Redirector::ServerEndpointInfo";

    public IList<Blaze2SDK.Blaze.Redirector.ServerAddressInfo> Addresses
    {
        get => _addresses.Value;
        set => _addresses.Value = value;
    }

    public string Channel
    {
        get => _channel.Value;
        set => _channel.Value = value;
    }

    public string Decoder
    {
        get => _decoder.Value;
        set => _decoder.Value = value;
    }

    public string Encoder
    {
        get => _encoder.Value;
        set => _encoder.Value = value;
    }

    public string Protocol
    {
        get => _protocol.Value;
        set => _protocol.Value = value;
    }

}

