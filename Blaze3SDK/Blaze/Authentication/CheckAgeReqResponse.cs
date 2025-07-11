using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Authentication;

public class CheckAgeReqResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("MustBeAnonymous", "mMustBeAnonymous", 0x86EBEE00, TdfType.Bool, 0, true), // ANON
        new TdfMemberInfo("PendingParentalConsent", "mPendingParentalConsent", 0xC25BA400, TdfType.UInt8, 1, true), // PEND
        new TdfMemberInfo("IsOfLegalContactAge", "mIsOfLegalContactAge", 0xCF086D00, TdfType.UInt8, 2, true), // SPAM
    ];
    private ITdfMember[] __members;

    private TdfBool _mustBeAnonymous = new(__typeInfos[0]);
    private TdfUInt8 _pendingParentalConsent = new(__typeInfos[1]);
    private TdfUInt8 _isOfLegalContactAge = new(__typeInfos[2]);

    public CheckAgeReqResponse()
    {
        __members = [
            _mustBeAnonymous,
            _pendingParentalConsent,
            _isOfLegalContactAge,
        ];
    }

    public override Tdf CreateNew() => new CheckAgeReqResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "CheckAgeReqResponse";
    public override string GetFullClassName() => "Blaze::Authentication::CheckAgeReqResponse";

    public bool MustBeAnonymous
    {
        get => _mustBeAnonymous.Value;
        set => _mustBeAnonymous.Value = value;
    }

    public byte PendingParentalConsent
    {
        get => _pendingParentalConsent.Value;
        set => _pendingParentalConsent.Value = value;
    }

    public byte IsOfLegalContactAge
    {
        get => _isOfLegalContactAge.Value;
        set => _isOfLegalContactAge.Value = value;
    }

}

