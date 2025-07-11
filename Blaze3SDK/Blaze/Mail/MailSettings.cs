using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Mail;

public class MailSettings : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("EmailFormatPref", "mEmailFormatPref", 0x966C2600, TdfType.Enum, 0, true), // EFPF
        new TdfMemberInfo("EmailOptInFlags", "mEmailOptInFlags", 0xBF0D2600, TdfType.Enum, 1, true), // OPTF
    ];
    private ITdfMember[] __members;

    private TdfEnum<Blaze3SDK.Blaze.Mail.EmailFormatPref> _emailFormatPref = new(__typeInfos[0]);
    private TdfEnum<Blaze3SDK.Blaze.Mail.EmailOptInFlags> _emailOptInFlags = new(__typeInfos[1]);

    public MailSettings()
    {
        __members = [
            _emailFormatPref,
            _emailOptInFlags,
        ];
    }

    public override Tdf CreateNew() => new MailSettings();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "MailSettings";
    public override string GetFullClassName() => "Blaze::Mail::MailSettings";

    public Blaze3SDK.Blaze.Mail.EmailFormatPref EmailFormatPref
    {
        get => _emailFormatPref.Value;
        set => _emailFormatPref.Value = value;
    }

    public Blaze3SDK.Blaze.Mail.EmailOptInFlags EmailOptInFlags
    {
        get => _emailOptInFlags.Value;
        set => _emailOptInFlags.Value = value;
    }

}

