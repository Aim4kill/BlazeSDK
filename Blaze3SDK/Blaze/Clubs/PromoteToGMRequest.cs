using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Clubs;

public class PromoteToGMRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("UserId", "mUserId", 0x8ACA6400, TdfType.Int64, 0, true), // BLID
        new TdfMemberInfo("ClubId", "mClubId", 0x8ECA6400, TdfType.UInt32, 1, true), // CLID
    ];
    private ITdfMember[] __members;

    private TdfInt64 _userId = new(__typeInfos[0]);
    private TdfUInt32 _clubId = new(__typeInfos[1]);

    public PromoteToGMRequest()
    {
        __members = [
            _userId,
            _clubId,
        ];
    }

    public override Tdf CreateNew() => new PromoteToGMRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "PromoteToGMRequest";
    public override string GetFullClassName() => "Blaze::Clubs::PromoteToGMRequest";

    public long UserId
    {
        get => _userId.Value;
        set => _userId.Value = value;
    }

    public uint ClubId
    {
        get => _clubId.Value;
        set => _clubId.Value = value;
    }

}

