using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Authentication;

public class XboxLoginRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("GamerTag", "mGamerTag", 0x9F486700, TdfType.String, 0, true), // GTAG
        new TdfMemberInfo("Email", "mEmail", 0xB61A6C00, TdfType.String, 1, true), // MAIL
        new TdfMemberInfo("Xuid", "mXuid", 0xE35A6400, TdfType.UInt64, 2, true), // XUID
    ];
    private ITdfMember[] __members;

    private TdfString _gamerTag = new(__typeInfos[0]);
    private TdfString _email = new(__typeInfos[1]);
    private TdfUInt64 _xuid = new(__typeInfos[2]);

    public XboxLoginRequest()
    {
        __members = [
            _gamerTag,
            _email,
            _xuid,
        ];
    }

    public override Tdf CreateNew() => new XboxLoginRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "XboxLoginRequest";
    public override string GetFullClassName() => "Blaze::Authentication::XboxLoginRequest";

    public string GamerTag
    {
        get => _gamerTag.Value;
        set => _gamerTag.Value = value;
    }

    public string Email
    {
        get => _email.Value;
        set => _email.Value = value;
    }

    public ulong Xuid
    {
        get => _xuid.Value;
        set => _xuid.Value = value;
    }

}

