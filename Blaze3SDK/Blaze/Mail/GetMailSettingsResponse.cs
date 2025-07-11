using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Mail;

public class GetMailSettingsResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("MailSettings", "mMailSettings", 0xB7397400, TdfType.Struct, 0, true), // MSET
    ];
    private ITdfMember[] __members;

    private TdfStruct<Blaze3SDK.Blaze.Mail.MailSettings?> _mailSettings = new(__typeInfos[0]);

    public GetMailSettingsResponse()
    {
        __members = [
            _mailSettings,
        ];
    }

    public override Tdf CreateNew() => new GetMailSettingsResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetMailSettingsResponse";
    public override string GetFullClassName() => "Blaze::Mail::GetMailSettingsResponse";

    public Blaze3SDK.Blaze.Mail.MailSettings? MailSettings
    {
        get => _mailSettings.Value;
        set => _mailSettings.Value = value;
    }

}

