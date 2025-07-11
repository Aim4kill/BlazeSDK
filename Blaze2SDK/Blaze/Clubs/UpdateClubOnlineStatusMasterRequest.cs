using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Clubs;

public class UpdateClubOnlineStatusMasterRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ClubId", "mClubId", 0x8ECA6400, TdfType.UInt32, 0, true), // CLID
        new TdfMemberInfo("ClubSettings", "mClubSettings", 0x8F397400, TdfType.Struct, 1, true), // CSET
        new TdfMemberInfo("Reason", "mReason", 0xCA587300, TdfType.Enum, 2, true), // REAS
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _clubId = new(__typeInfos[0]);
    private TdfStruct<Blaze2SDK.Blaze.Clubs.ClubSettings?> _clubSettings = new(__typeInfos[1]);
    private TdfEnum<Blaze2SDK.Blaze.Clubs.ClubOnlineStatusUpdateReason> _reason = new(__typeInfos[2]);

    public UpdateClubOnlineStatusMasterRequest()
    {
        __members = [
            _clubId,
            _clubSettings,
            _reason,
        ];
    }

    public override Tdf CreateNew() => new UpdateClubOnlineStatusMasterRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "UpdateClubOnlineStatusMasterRequest";
    public override string GetFullClassName() => "Blaze::Clubs::UpdateClubOnlineStatusMasterRequest";

    public uint ClubId
    {
        get => _clubId.Value;
        set => _clubId.Value = value;
    }

    public Blaze2SDK.Blaze.Clubs.ClubSettings? ClubSettings
    {
        get => _clubSettings.Value;
        set => _clubSettings.Value = value;
    }

    public Blaze2SDK.Blaze.Clubs.ClubOnlineStatusUpdateReason Reason
    {
        get => _reason.Value;
        set => _reason.Value = value;
    }

}

