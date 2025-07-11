using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Clubs;

public class SetNewsItemHiddenRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("NewsId", "mNewsId", 0x8ACA6400, TdfType.ObjectId, 0, true), // BLID
        new TdfMemberInfo("ClubId", "mClubId", 0x8ECA6400, TdfType.UInt32, 1, true), // CLID
        new TdfMemberInfo("IsHidden", "mIsHidden", 0xA73A2400, TdfType.Bool, 2, true), // ISHD
    ];
    private ITdfMember[] __members;

    private TdfObjectId _newsId = new(__typeInfos[0]);
    private TdfUInt32 _clubId = new(__typeInfos[1]);
    private TdfBool _isHidden = new(__typeInfos[2]);

    public SetNewsItemHiddenRequest()
    {
        __members = [
            _newsId,
            _clubId,
            _isHidden,
        ];
    }

    public override Tdf CreateNew() => new SetNewsItemHiddenRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "SetNewsItemHiddenRequest";
    public override string GetFullClassName() => "Blaze::Clubs::SetNewsItemHiddenRequest";

    public ObjectId NewsId
    {
        get => _newsId.Value;
        set => _newsId.Value = value;
    }

    public uint ClubId
    {
        get => _clubId.Value;
        set => _clubId.Value = value;
    }

    public bool IsHidden
    {
        get => _isHidden.Value;
        set => _isHidden.Value = value;
    }

}

