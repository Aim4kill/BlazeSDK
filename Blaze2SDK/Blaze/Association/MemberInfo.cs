using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Association;

public class MemberInfo : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("BlazeId", "mBlazeId", 0x8ACA6400, TdfType.UInt32, 0, true), // BLID
        new TdfMemberInfo("IsOnline", "mIsOnline", 0xBEEB2E00, TdfType.Bool, 1, true), // ONLN
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _blazeId = new(__typeInfos[0]);
    private TdfBool _isOnline = new(__typeInfos[1]);

    public MemberInfo()
    {
        __members = [
            _blazeId,
            _isOnline,
        ];
    }

    public override Tdf CreateNew() => new MemberInfo();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "MemberInfo";
    public override string GetFullClassName() => "Blaze::Association::MemberInfo";

    public uint BlazeId
    {
        get => _blazeId.Value;
        set => _blazeId.Value = value;
    }

    public bool IsOnline
    {
        get => _isOnline.Value;
        set => _isOnline.Value = value;
    }

}

