using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Playgroups;

public class NotifyXboxSessionInfo : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Id", "mId", 0xC27A6400, TdfType.UInt32, 0, true), // PGID
        new TdfMemberInfo("XnetNonce", "mXnetNonce", 0xE2EBA300, TdfType.Blob, 1, true), // XNNC
        new TdfMemberInfo("XnetSession", "mXnetSession", 0xE3397300, TdfType.Blob, 2, true), // XSES
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _id = new(__typeInfos[0]);
    private TdfBlob _xnetNonce = new(__typeInfos[1]);
    private TdfBlob _xnetSession = new(__typeInfos[2]);

    public NotifyXboxSessionInfo()
    {
        __members = [
            _id,
            _xnetNonce,
            _xnetSession,
        ];
    }

    public override Tdf CreateNew() => new NotifyXboxSessionInfo();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "NotifyXboxSessionInfo";
    public override string GetFullClassName() => "Blaze::Playgroups::NotifyXboxSessionInfo";

    public uint Id
    {
        get => _id.Value;
        set => _id.Value = value;
    }

    public byte[] XnetNonce
    {
        get => _xnetNonce.Value;
        set => _xnetNonce.Value = value;
    }

    public byte[] XnetSession
    {
        get => _xnetSession.Value;
        set => _xnetSession.Value = value;
    }

}

