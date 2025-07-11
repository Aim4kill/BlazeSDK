using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Clubs;

public class ClubTickerMessageMaster : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ClubId", "mClubId", 0x8ECA6400, TdfType.UInt32, 0, true), // CLID
        new TdfMemberInfo("Message", "mMessage", 0x8F4B7300, TdfType.Struct, 1, true), // CTMS
        new TdfMemberInfo("ExcludeUserId", "mExcludeUserId", 0x978D6900, TdfType.Int64, 2, true), // EXUI
        new TdfMemberInfo("IncludeUserId", "mIncludeUserId", 0xA6ED6900, TdfType.Int64, 3, true), // INUI
        new TdfMemberInfo("Params", "mParams", 0xC32B7300, TdfType.String, 4, true), // PRMS
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _clubId = new(__typeInfos[0]);
    private TdfStruct<Blaze3SDK.Blaze.Clubs.ClubTickerMessage?> _message = new(__typeInfos[1]);
    private TdfInt64 _excludeUserId = new(__typeInfos[2]);
    private TdfInt64 _includeUserId = new(__typeInfos[3]);
    private TdfString _params = new(__typeInfos[4]);

    public ClubTickerMessageMaster()
    {
        __members = [
            _clubId,
            _message,
            _excludeUserId,
            _includeUserId,
            _params,
        ];
    }

    public override Tdf CreateNew() => new ClubTickerMessageMaster();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ClubTickerMessageMaster";
    public override string GetFullClassName() => "Blaze::Clubs::ClubTickerMessageMaster";

    public uint ClubId
    {
        get => _clubId.Value;
        set => _clubId.Value = value;
    }

    public Blaze3SDK.Blaze.Clubs.ClubTickerMessage? Message
    {
        get => _message.Value;
        set => _message.Value = value;
    }

    public long ExcludeUserId
    {
        get => _excludeUserId.Value;
        set => _excludeUserId.Value = value;
    }

    public long IncludeUserId
    {
        get => _includeUserId.Value;
        set => _includeUserId.Value = value;
    }

    public string Params
    {
        get => _params.Value;
        set => _params.Value = value;
    }

}

