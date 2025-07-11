using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Clubs;

public class PostNewsRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ClubId", "mClubId", 0x8ECA6400, TdfType.UInt32, 0, true), // CLID
        new TdfMemberInfo("ClubNews", "mClubNews", 0xBB7B2900, TdfType.Struct, 1, true), // NWLI
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _clubId = new(__typeInfos[0]);
    private TdfStruct<Blaze3SDK.Blaze.Clubs.ClubNews?> _clubNews = new(__typeInfos[1]);

    public PostNewsRequest()
    {
        __members = [
            _clubId,
            _clubNews,
        ];
    }

    public override Tdf CreateNew() => new PostNewsRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "PostNewsRequest";
    public override string GetFullClassName() => "Blaze::Clubs::PostNewsRequest";

    public uint ClubId
    {
        get => _clubId.Value;
        set => _clubId.Value = value;
    }

    public Blaze3SDK.Blaze.Clubs.ClubNews? ClubNews
    {
        get => _clubNews.Value;
        set => _clubNews.Value = value;
    }

}

