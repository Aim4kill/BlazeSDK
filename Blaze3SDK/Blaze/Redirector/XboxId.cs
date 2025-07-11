using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Redirector;

public class XboxId : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Gamertag", "mGamertag", 0x9F486700, TdfType.String, 0, true), // GTAG
        new TdfMemberInfo("Xuid", "mXuid", 0xE35A6400, TdfType.UInt64, 1, true), // XUID
    ];
    private ITdfMember[] __members;

    private TdfString _gamertag = new(__typeInfos[0]);
    private TdfUInt64 _xuid = new(__typeInfos[1]);

    public XboxId()
    {
        __members = [
            _gamertag,
            _xuid,
        ];
    }

    public override Tdf CreateNew() => new XboxId();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "XboxId";
    public override string GetFullClassName() => "Blaze::Redirector::XboxId";

    public string Gamertag
    {
        get => _gamertag.Value;
        set => _gamertag.Value = value;
    }

    public ulong Xuid
    {
        get => _xuid.Value;
        set => _xuid.Value = value;
    }

}

