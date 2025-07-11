using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze;

public class UserStatus : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("StatusFlags", "mStatusFlags", 0x9AC9F300, TdfType.Enum, 0, true), // FLGS
        new TdfMemberInfo("BlazeId", "mBlazeId", 0xA6400000, TdfType.Int64, 1, true), // ID
    ];
    private ITdfMember[] __members;

    private TdfEnum<Blaze3SDK.Blaze.UserDataFlags> _statusFlags = new(__typeInfos[0]);
    private TdfInt64 _blazeId = new(__typeInfos[1]);

    public UserStatus()
    {
        __members = [
            _statusFlags,
            _blazeId,
        ];
    }

    public override Tdf CreateNew() => new UserStatus();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "UserStatus";
    public override string GetFullClassName() => "Blaze::UserStatus";

    public Blaze3SDK.Blaze.UserDataFlags StatusFlags
    {
        get => _statusFlags.Value;
        set => _statusFlags.Value = value;
    }

    public long BlazeId
    {
        get => _blazeId.Value;
        set => _blazeId.Value = value;
    }

}

