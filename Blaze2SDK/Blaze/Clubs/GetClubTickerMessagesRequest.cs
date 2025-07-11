using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Clubs;

public class GetClubTickerMessagesRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ClubId", "mClubId", 0x8ECA6400, TdfType.UInt32, 0, true), // CLID
        new TdfMemberInfo("OldestTimestamp", "mOldestTimestamp", 0xD33D2D00, TdfType.UInt32, 1, true), // TSTM
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _clubId = new(__typeInfos[0]);
    private TdfUInt32 _oldestTimestamp = new(__typeInfos[1]);

    public GetClubTickerMessagesRequest()
    {
        __members = [
            _clubId,
            _oldestTimestamp,
        ];
    }

    public override Tdf CreateNew() => new GetClubTickerMessagesRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetClubTickerMessagesRequest";
    public override string GetFullClassName() => "Blaze::Clubs::GetClubTickerMessagesRequest";

    public uint ClubId
    {
        get => _clubId.Value;
        set => _clubId.Value = value;
    }

    public uint OldestTimestamp
    {
        get => _oldestTimestamp.Value;
        set => _oldestTimestamp.Value = value;
    }

}

