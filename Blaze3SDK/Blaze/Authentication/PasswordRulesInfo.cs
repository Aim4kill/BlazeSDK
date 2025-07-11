using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Authentication;

public class PasswordRulesInfo : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("MaxLength", "mMaxLength", 0xB61E3300, TdfType.UInt16, 0, true), // MAXS
        new TdfMemberInfo("MinLength", "mMinLength", 0xB69BB300, TdfType.UInt16, 1, true), // MINS
        new TdfMemberInfo("ValidCharacters", "mValidCharacters", 0xDA48E800, TdfType.String, 2, true), // VDCH
    ];
    private ITdfMember[] __members;

    private TdfUInt16 _maxLength = new(__typeInfos[0]);
    private TdfUInt16 _minLength = new(__typeInfos[1]);
    private TdfString _validCharacters = new(__typeInfos[2]);

    public PasswordRulesInfo()
    {
        __members = [
            _maxLength,
            _minLength,
            _validCharacters,
        ];
    }

    public override Tdf CreateNew() => new PasswordRulesInfo();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "PasswordRulesInfo";
    public override string GetFullClassName() => "Blaze::Authentication::PasswordRulesInfo";

    public ushort MaxLength
    {
        get => _maxLength.Value;
        set => _maxLength.Value = value;
    }

    public ushort MinLength
    {
        get => _minLength.Value;
        set => _minLength.Value = value;
    }

    public string ValidCharacters
    {
        get => _validCharacters.Value;
        set => _validCharacters.Value = value;
    }

}

