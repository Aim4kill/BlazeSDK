using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.League;

public class InvalidTradeError : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ReasonCode", "mReasonCode", 0xCA5CEE00, TdfType.Int32, 0, true), // RESN
    ];
    private ITdfMember[] __members;

    private TdfInt32 _reasonCode = new(__typeInfos[0]);

    public InvalidTradeError()
    {
        __members = [
            _reasonCode,
        ];
    }

    public override Tdf CreateNew() => new InvalidTradeError();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "InvalidTradeError";
    public override string GetFullClassName() => "Blaze::League::InvalidTradeError";

    public int ReasonCode
    {
        get => _reasonCode.Value;
        set => _reasonCode.Value = value;
    }

}

