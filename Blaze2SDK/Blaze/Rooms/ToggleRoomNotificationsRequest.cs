using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Rooms;

public class ToggleRoomNotificationsRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ReceiveNotifications", "mReceiveNotifications", 0x96E8AC00, TdfType.Bool, 0, true), // ENBL
    ];
    private ITdfMember[] __members;

    private TdfBool _receiveNotifications = new(__typeInfos[0]);

    public ToggleRoomNotificationsRequest()
    {
        __members = [
            _receiveNotifications,
        ];
    }

    public override Tdf CreateNew() => new ToggleRoomNotificationsRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ToggleRoomNotificationsRequest";
    public override string GetFullClassName() => "Blaze::Rooms::ToggleRoomNotificationsRequest";

    public bool ReceiveNotifications
    {
        get => _receiveNotifications.Value;
        set => _receiveNotifications.Value = value;
    }

}

