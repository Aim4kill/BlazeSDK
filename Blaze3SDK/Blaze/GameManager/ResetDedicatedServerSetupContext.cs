using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameManager;

public class ResetDedicatedServerSetupContext : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("JoinErr", "mJoinErr", 0x972C8000, TdfType.UInt32, 0, true), // ERR
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _joinErr = new(__typeInfos[0]);

    public ResetDedicatedServerSetupContext()
    {
        __members = [
            _joinErr,
        ];
    }

    public override Tdf CreateNew() => new ResetDedicatedServerSetupContext();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ResetDedicatedServerSetupContext";
    public override string GetFullClassName() => "Blaze::GameManager::ResetDedicatedServerSetupContext";

    public uint JoinErr
    {
        get => _joinErr.Value;
        set => _joinErr.Value = value;
    }

}

