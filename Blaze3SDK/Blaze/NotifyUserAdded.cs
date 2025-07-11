using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze;

public class NotifyUserAdded : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ExtendedData", "mExtendedData", 0x921D2100, TdfType.Struct, 0, true), // DATA
        new TdfMemberInfo("UserInfo", "mUserInfo", 0xD7397200, TdfType.Struct, 1, true), // USER
    ];
    private ITdfMember[] __members;

    private TdfStruct<Blaze3SDK.Blaze.UserSessionExtendedData?> _extendedData = new(__typeInfos[0]);
    private TdfStruct<Blaze3SDK.Blaze.UserIdentification?> _userInfo = new(__typeInfos[1]);

    public NotifyUserAdded()
    {
        __members = [
            _extendedData,
            _userInfo,
        ];
    }

    public override Tdf CreateNew() => new NotifyUserAdded();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "NotifyUserAdded";
    public override string GetFullClassName() => "Blaze::NotifyUserAdded";

    public Blaze3SDK.Blaze.UserSessionExtendedData? ExtendedData
    {
        get => _extendedData.Value;
        set => _extendedData.Value = value;
    }

    public Blaze3SDK.Blaze.UserIdentification? UserInfo
    {
        get => _userInfo.Value;
        set => _userInfo.Value = value;
    }

}

