using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze;

public class XboxClientAddress : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("XnAddr", "XnAddr", 0xE2493200, TdfType.Blob, 0, true), // XDDR
        new TdfMemberInfo("Xuid", "Xuid", 0xE35A6400, TdfType.UInt64, 1, true), // XUID
    ];
    private ITdfMember[] __members;

    private TdfBlob _xnAddr = new(__typeInfos[0]);
    private TdfUInt64 _xuid = new(__typeInfos[1]);

    public XboxClientAddress()
    {
        __members = [
            _xnAddr,
            _xuid,
        ];
    }

    public override Tdf CreateNew() => new XboxClientAddress();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "XboxClientAddress";
    public override string GetFullClassName() => "Blaze::XboxClientAddress";

    public byte[] XnAddr
    {
        get => _xnAddr.Value;
        set => _xnAddr.Value = value;
    }

    public ulong Xuid
    {
        get => _xuid.Value;
        set => _xuid.Value = value;
    }

}

