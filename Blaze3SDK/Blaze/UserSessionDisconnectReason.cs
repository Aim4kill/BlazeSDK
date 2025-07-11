using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze;

public class UserSessionDisconnectReason : Tdf
{
    public enum DisconnectReason : int
    {
        DUPLICATE_LOGIN = 0,
    }
    
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("DisconnectReason", "mDisconnectReason", 0xCE4C8000, TdfType.Enum, 0, true), // SDR
    ];
    private ITdfMember[] __members;

    private TdfEnum<Blaze3SDK.Blaze.UserSessionDisconnectReason.DisconnectReason> _disconnectReason = new(__typeInfos[0]);

    public UserSessionDisconnectReason()
    {
        __members = [
            _disconnectReason,
        ];
    }

    public override Tdf CreateNew() => new UserSessionDisconnectReason();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "UserSessionDisconnectReason";
    public override string GetFullClassName() => "Blaze::UserSessionDisconnectReason";

    public Blaze3SDK.Blaze.UserSessionDisconnectReason.DisconnectReason mDisconnectReason
    {
        get => _disconnectReason.Value;
        set => _disconnectReason.Value = value;
    }

}

