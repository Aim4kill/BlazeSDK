using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Rsp;

public class StartPurchaseRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ConsumableId", "mConsumableId", 0x8E990000, TdfType.UInt32, 0, true), // CID
        new TdfMemberInfo("PingSiteAlias", "mPingSiteAlias", 0xC3386C00, TdfType.String, 1, true), // PSAL
        new TdfMemberInfo("ServerId", "mServerId", 0xCE990000, TdfType.UInt32, 2, true), // SID
        new TdfMemberInfo("UserId", "mUserId", 0xD6990000, TdfType.Int64, 3, true), // UID
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _consumableId = new(__typeInfos[0]);
    private TdfString _pingSiteAlias = new(__typeInfos[1]);
    private TdfUInt32 _serverId = new(__typeInfos[2]);
    private TdfInt64 _userId = new(__typeInfos[3]);

    public StartPurchaseRequest()
    {
        __members = [
            _consumableId,
            _pingSiteAlias,
            _serverId,
            _userId,
        ];
    }

    public override Tdf CreateNew() => new StartPurchaseRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "StartPurchaseRequest";
    public override string GetFullClassName() => "Blaze::Rsp::StartPurchaseRequest";

    public uint ConsumableId
    {
        get => _consumableId.Value;
        set => _consumableId.Value = value;
    }

    public string PingSiteAlias
    {
        get => _pingSiteAlias.Value;
        set => _pingSiteAlias.Value = value;
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

