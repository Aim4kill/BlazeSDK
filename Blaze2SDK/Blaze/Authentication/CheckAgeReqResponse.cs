using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Authentication;

public class CheckAgeReqResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("mustBeAnonymous", "mustBeAnonymous", 0x86EBEE00, TdfType.Bool, 0, true), // ANON
        new TdfMemberInfo("pendingParentalConsent", "pendingParentalConsent", 0xC25BA400, TdfType.UInt8, 1, true), // PEND
        new TdfMemberInfo("isSpammable", "isSpammable", 0xCF086D00, TdfType.UInt8, 2, true), // SPAM
    ];
    private ITdfMember[] __members;

    private TdfBool _mustBeAnonymous = new(__typeInfos[0]);
    private TdfUInt8 _pendingParentalConsent = new(__typeInfos[1]);
    private TdfUInt8 _isSpammable = new(__typeInfos[2]);

    public CheckAgeReqResponse()
    {
        __members = [
            _mustBeAnonymous,
            _pendingParentalConsent,
            _isSpammable,
        ];
    }

    public override Tdf CreateNew() => new CheckAgeReqResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "CheckAgeReqResponse";
    public override string GetFullClassName() => "Blaze::Authentication::CheckAgeReqResponse";

    public bool mustBeAnonymous
    {
        get => _mustBeAnonymous.Value;
        set => _mustBeAnonymous.Value = value;
    }

    public byte pendingParentalConsent
    {
        get => _pendingParentalConsent.Value;
        set => _pendingParentalConsent.Value = value;
    }

    public byte isSpammable
    {
        get => _isSpammable.Value;
        set => _isSpammable.Value = value;
    }

}

