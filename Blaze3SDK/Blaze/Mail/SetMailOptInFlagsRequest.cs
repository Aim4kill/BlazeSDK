using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Mail;

public class SetMailOptInFlagsRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("EmailOptInFlags", "mEmailOptInFlags", 0xBF0D2600, TdfType.Enum, 0, true), // OPTF
        new TdfMemberInfo("UserId", "mUserId", 0xD6990000, TdfType.Int64, 1, true), // UID
    ];
    private ITdfMember[] __members;

    private TdfEnum<Blaze3SDK.Blaze.Mail.EmailOptInFlags> _emailOptInFlags = new(__typeInfos[0]);
    private TdfInt64 _userId = new(__typeInfos[1]);

    public SetMailOptInFlagsRequest()
    {
        __members = [
            _emailOptInFlags,
            _userId,
        ];
    }

    public override Tdf CreateNew() => new SetMailOptInFlagsRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "SetMailOptInFlagsRequest";
    public override string GetFullClassName() => "Blaze::Mail::SetMailOptInFlagsRequest";

    public Blaze3SDK.Blaze.Mail.EmailOptInFlags EmailOptInFlags
    {
        get => _emailOptInFlags.Value;
        set => _emailOptInFlags.Value = value;
    }

    public long UserId
    {
        get => _userId.Value;
        set => _userId.Value = value;
    }

}

