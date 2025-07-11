using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Util;

public class GetTickerServerResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Address", "mAddress", 0x864CB300, TdfType.String, 0, true), // ADRS
        new TdfMemberInfo("Port", "mPort", 0xC2FCB400, TdfType.UInt32, 1, true), // PORT
        new TdfMemberInfo("Key", "mKey", 0xCEB97900, TdfType.String, 2, true), // SKEY
    ];
    private ITdfMember[] __members;

    private TdfString _address = new(__typeInfos[0]);
    private TdfUInt32 _port = new(__typeInfos[1]);
    private TdfString _key = new(__typeInfos[2]);

    public GetTickerServerResponse()
    {
        __members = [
            _address,
            _port,
            _key,
        ];
    }

    public override Tdf CreateNew() => new GetTickerServerResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetTickerServerResponse";
    public override string GetFullClassName() => "Blaze::Util::GetTickerServerResponse";

    public string Address
    {
        get => _address.Value;
        set => _address.Value = value;
    }

    public uint Port
    {
        get => _port.Value;
        set => _port.Value = value;
    }

    public string Key
    {
        get => _key.Value;
        set => _key.Value = value;
    }

}

