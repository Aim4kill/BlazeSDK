using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Util;

public class DeleteUserSettingsRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Key", "mKey", 0xAE5E4000, TdfType.String, 0, true), // KEY
        new TdfMemberInfo("UserId", "mUserId", 0xD6990000, TdfType.Int64, 1, true), // UID
    ];
    private ITdfMember[] __members;

    private TdfString _key = new(__typeInfos[0]);
    private TdfInt64 _userId = new(__typeInfos[1]);

    public DeleteUserSettingsRequest()
    {
        __members = [
            _key,
            _userId,
        ];
    }

    public override Tdf CreateNew() => new DeleteUserSettingsRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "DeleteUserSettingsRequest";
    public override string GetFullClassName() => "Blaze::Util::DeleteUserSettingsRequest";

    public string Key
    {
        get => _key.Value;
        set => _key.Value = value;
    }

    public long UserId
    {
        get => _userId.Value;
        set => _userId.Value = value;
    }

}

