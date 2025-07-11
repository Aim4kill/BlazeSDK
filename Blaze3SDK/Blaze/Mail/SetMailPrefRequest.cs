using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Mail;

public class SetMailPrefRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("EmailFormatPref", "mEmailFormatPref", 0x966C2600, TdfType.Enum, 0, true), // EFPF
        new TdfMemberInfo("UserId", "mUserId", 0xD6990000, TdfType.Int64, 1, true), // UID
    ];
    private ITdfMember[] __members;

    private TdfEnum<Blaze3SDK.Blaze.Mail.EmailFormatPref> _emailFormatPref = new(__typeInfos[0]);
    private TdfInt64 _userId = new(__typeInfos[1]);

    public SetMailPrefRequest()
    {
        __members = [
            _emailFormatPref,
            _userId,
        ];
    }

    public override Tdf CreateNew() => new SetMailPrefRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "SetMailPrefRequest";
    public override string GetFullClassName() => "Blaze::Mail::SetMailPrefRequest";

    public Blaze3SDK.Blaze.Mail.EmailFormatPref EmailFormatPref
    {
        get => _emailFormatPref.Value;
        set => _emailFormatPref.Value = value;
    }

    public long UserId
    {
        get => _userId.Value;
        set => _userId.Value = value;
    }

}

