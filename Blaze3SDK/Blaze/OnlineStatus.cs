using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze;

public class OnlineStatus : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Online", "mOnline", 0x8B5A6400, TdfType.Bool, 0, true), // BUID
    ];
    private ITdfMember[] __members;

    private TdfBool _online = new(__typeInfos[0]);

    public OnlineStatus()
    {
        __members = [
            _online,
        ];
    }

    public override Tdf CreateNew() => new OnlineStatus();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "OnlineStatus";
    public override string GetFullClassName() => "Blaze::OnlineStatus";

    public bool Online
    {
        get => _online.Value;
        set => _online.Value = value;
    }

}

