using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Util;

public class ClientData : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Locale", "mLocale", 0xB21BA700, TdfType.UInt32, 0, true), // LANG
        new TdfMemberInfo("ClientType", "mClientType", 0xD39C2500, TdfType.Enum, 1, true), // TYPE
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _locale = new(__typeInfos[0]);
    private TdfEnum<Blaze2SDK.Blaze.ClientType> _clientType = new(__typeInfos[1]);

    public ClientData()
    {
        __members = [
            _locale,
            _clientType,
        ];
    }

    public override Tdf CreateNew() => new ClientData();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ClientData";
    public override string GetFullClassName() => "Blaze::Util::ClientData";

    public uint Locale
    {
        get => _locale.Value;
        set => _locale.Value = value;
    }

    public Blaze2SDK.Blaze.ClientType ClientType
    {
        get => _clientType.Value;
        set => _clientType.Value = value;
    }

}

