using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze;

public class CheckOnlineStatusRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("UserId", "mUserId", 0x8B5A6400, TdfType.UInt32, 0, true), // BUID
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _userId = new(__typeInfos[0]);

    public CheckOnlineStatusRequest()
    {
        __members = [
            _userId,
        ];
    }

    public override Tdf CreateNew() => new CheckOnlineStatusRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "CheckOnlineStatusRequest";
    public override string GetFullClassName() => "Blaze::CheckOnlineStatusRequest";

    public uint UserId
    {
        get => _userId.Value;
        set => _userId.Value = value;
    }

}

