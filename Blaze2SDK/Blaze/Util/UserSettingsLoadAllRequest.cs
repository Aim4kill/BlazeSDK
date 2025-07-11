using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Util;

public class UserSettingsLoadAllRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("UserId", "mUserId", 0xD6990000, TdfType.UInt32, 0, true), // UID
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _userId = new(__typeInfos[0]);

    public UserSettingsLoadAllRequest()
    {
        __members = [
            _userId,
        ];
    }

    public override Tdf CreateNew() => new UserSettingsLoadAllRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "UserSettingsLoadAllRequest";
    public override string GetFullClassName() => "Blaze::Util::UserSettingsLoadAllRequest";

    public uint UserId
    {
        get => _userId.Value;
        set => _userId.Value = value;
    }

}

