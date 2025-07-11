using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameManager;

public class DatalessSetupContext : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("SetupContext", "mSetupContext", 0x923D3800, TdfType.Enum, 0, true), // DCTX
    ];
    private ITdfMember[] __members;

    private TdfEnum<Blaze3SDK.Blaze.GameManager.DatalessContext> _setupContext = new(__typeInfos[0]);

    public DatalessSetupContext()
    {
        __members = [
            _setupContext,
        ];
    }

    public override Tdf CreateNew() => new DatalessSetupContext();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "DatalessSetupContext";
    public override string GetFullClassName() => "Blaze::GameManager::DatalessSetupContext";

    public Blaze3SDK.Blaze.GameManager.DatalessContext SetupContext
    {
        get => _setupContext.Value;
        set => _setupContext.Value = value;
    }

}

