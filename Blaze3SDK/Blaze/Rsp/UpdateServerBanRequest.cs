using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Rsp;

public class UpdateServerBanRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Context", "mContext", 0x8EED3800, TdfType.UInt16, 0, true), // CNTX
        new TdfMemberInfo("ServerId", "mServerId", 0xCE990000, TdfType.UInt32, 1, true), // SID
        new TdfMemberInfo("UserId", "mUserId", 0xD6990000, TdfType.Int64, 2, true), // UID
    ];
    private ITdfMember[] __members;

    private TdfUInt16 _context = new(__typeInfos[0]);
    private TdfUInt32 _serverId = new(__typeInfos[1]);
    private TdfInt64 _userId = new(__typeInfos[2]);

    public UpdateServerBanRequest()
    {
        __members = [
            _context,
            _serverId,
            _userId,
        ];
    }

    public override Tdf CreateNew() => new UpdateServerBanRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "UpdateServerBanRequest";
    public override string GetFullClassName() => "Blaze::Rsp::UpdateServerBanRequest";

    public ushort Context
    {
        get => _context.Value;
        set => _context.Value = value;
    }

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

