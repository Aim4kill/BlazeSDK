using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Rsp;

public class UpdateServerBannerRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("BannerId", "mBannerId", 0x8A990000, TdfType.Int32, 0, true), // BID
        new TdfMemberInfo("ClearBannerId", "mClearBannerId", 0x8ECC8000, TdfType.Bool, 1, true), // CLR
        new TdfMemberInfo("ServerId", "mServerId", 0xCE990000, TdfType.UInt32, 2, true), // SID
    ];
    private ITdfMember[] __members;

    private TdfInt32 _bannerId = new(__typeInfos[0]);
    private TdfBool _clearBannerId = new(__typeInfos[1]);
    private TdfUInt32 _serverId = new(__typeInfos[2]);

    public UpdateServerBannerRequest()
    {
        __members = [
            _bannerId,
            _clearBannerId,
            _serverId,
        ];
    }

    public override Tdf CreateNew() => new UpdateServerBannerRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "UpdateServerBannerRequest";
    public override string GetFullClassName() => "Blaze::Rsp::UpdateServerBannerRequest";

    public int BannerId
    {
        get => _bannerId.Value;
        set => _bannerId.Value = value;
    }

    public bool ClearBannerId
    {
        get => _clearBannerId.Value;
        set => _clearBannerId.Value = value;
    }

    public uint ServerId
    {
        get => _serverId.Value;
        set => _serverId.Value = value;
    }

}

