using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Rsp;

public class UpdateServerVipRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ServerId", "mServerId", 0xCE990000, TdfType.UInt32, 0, true), // SID
        new TdfMemberInfo("UserId", "mUserId", 0xD6990000, TdfType.Int64, 1, true), // UID
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _serverId = new(__typeInfos[0]);
    private TdfInt64 _userId = new(__typeInfos[1]);

    public UpdateServerVipRequest()
    {
        __members = [
            _serverId,
            _userId,
        ];
    }

    public override Tdf CreateNew() => new UpdateServerVipRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "UpdateServerVipRequest";
    public override string GetFullClassName() => "Blaze::Rsp::UpdateServerVipRequest";

    public uint ServerId
    {
        get => _serverId.Value;
        set => _serverId.Value = value;
    }

    public long UserId
    {
        get => _userId.Value;
        set => _userId.Value = value;
    }

}

