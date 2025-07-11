using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Util;

public class UserSettingsSaveRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Data", "mData", 0x921D2100, TdfType.String, 0, true), // DATA
        new TdfMemberInfo("Key", "mKey", 0xAE5E4000, TdfType.String, 1, true), // KEY
        new TdfMemberInfo("UserId", "mUserId", 0xD6990000, TdfType.UInt32, 2, true), // UID
    ];
    private ITdfMember[] __members;

    private TdfString _data = new(__typeInfos[0]);
    private TdfString _key = new(__typeInfos[1]);
    private TdfUInt32 _userId = new(__typeInfos[2]);

    public UserSettingsSaveRequest()
    {
        __members = [
            _data,
            _key,
            _userId,
        ];
    }

    public override Tdf CreateNew() => new UserSettingsSaveRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "UserSettingsSaveRequest";
    public override string GetFullClassName() => "Blaze::Util::UserSettingsSaveRequest";

    public string Data
    {
        get => _data.Value;
        set => _data.Value = value;
    }

    public string Key
    {
        get => _key.Value;
        set => _key.Value = value;
    }

    public uint UserId
    {
        get => _userId.Value;
        set => _userId.Value = value;
    }

}

