using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Clubs;

public class UpdateClubOnlineStatusMasterResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("StatusMapVersion", "mStatusMapVersion", 0xCEDDB200, TdfType.UInt32, 0, true), // SMVR
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _statusMapVersion = new(__typeInfos[0]);

    public UpdateClubOnlineStatusMasterResponse()
    {
        __members = [
            _statusMapVersion,
        ];
    }

    public override Tdf CreateNew() => new UpdateClubOnlineStatusMasterResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "UpdateClubOnlineStatusMasterResponse";
    public override string GetFullClassName() => "Blaze::Clubs::UpdateClubOnlineStatusMasterResponse";

    public uint StatusMapVersion
    {
        get => _statusMapVersion.Value;
        set => _statusMapVersion.Value = value;
    }

}

