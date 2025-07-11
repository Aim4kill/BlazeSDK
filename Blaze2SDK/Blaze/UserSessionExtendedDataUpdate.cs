using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze;

public class UserSessionExtendedDataUpdate : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ExtendedData", "mExtendedData", 0x921D2100, TdfType.Struct, 0, true), // DATA
        new TdfMemberInfo("UserId", "mUserId", 0xD73A6400, TdfType.UInt32, 1, true), // USID
    ];
    private ITdfMember[] __members;

    private TdfStruct<Blaze2SDK.Blaze.UserSessionExtendedData?> _extendedData = new(__typeInfos[0]);
    private TdfUInt32 _userId = new(__typeInfos[1]);

    public UserSessionExtendedDataUpdate()
    {
        __members = [
            _extendedData,
            _userId,
        ];
    }

    public override Tdf CreateNew() => new UserSessionExtendedDataUpdate();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "UserSessionExtendedDataUpdate";
    public override string GetFullClassName() => "Blaze::UserSessionExtendedDataUpdate";

    public Blaze2SDK.Blaze.UserSessionExtendedData? ExtendedData
    {
        get => _extendedData.Value;
        set => _extendedData.Value = value;
    }

    public uint UserId
    {
        get => _userId.Value;
        set => _userId.Value = value;
    }

}

