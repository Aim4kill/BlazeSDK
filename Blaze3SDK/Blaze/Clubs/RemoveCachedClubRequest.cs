using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Clubs;

public class RemoveCachedClubRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ClubId", "mClubId", 0x8ECA6400, TdfType.UInt32, 0, true), // CLID
        new TdfMemberInfo("Reason", "mReason", 0xD70CB300, TdfType.Enum, 1, true), // UPRS
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _clubId = new(__typeInfos[0]);
    private TdfEnum<Blaze3SDK.Blaze.Clubs.UpdateReason> _reason = new(__typeInfos[1]);

    public RemoveCachedClubRequest()
    {
        __members = [
            _clubId,
            _reason,
        ];
    }

    public override Tdf CreateNew() => new RemoveCachedClubRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "RemoveCachedClubRequest";
    public override string GetFullClassName() => "Blaze::Clubs::RemoveCachedClubRequest";

    public uint ClubId
    {
        get => _clubId.Value;
        set => _clubId.Value = value;
    }

    public Blaze3SDK.Blaze.Clubs.UpdateReason Reason
    {
        get => _reason.Value;
        set => _reason.Value = value;
    }

}

