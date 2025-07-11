using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze;

public class UpdateHardwareFlagsRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("HardwareFlags", "mHardwareFlags", 0xA379A700, TdfType.Enum, 0, true), // HWFG
    ];
    private ITdfMember[] __members;

    private TdfEnum<Blaze2SDK.Blaze.HardwareFlags> _hardwareFlags = new(__typeInfos[0]);

    public UpdateHardwareFlagsRequest()
    {
        __members = [
            _hardwareFlags,
        ];
    }

    public override Tdf CreateNew() => new UpdateHardwareFlagsRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "UpdateHardwareFlagsRequest";
    public override string GetFullClassName() => "Blaze::UpdateHardwareFlagsRequest";

    public Blaze2SDK.Blaze.HardwareFlags HardwareFlags
    {
        get => _hardwareFlags.Value;
        set => _hardwareFlags.Value = value;
    }

}

