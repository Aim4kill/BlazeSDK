using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.League;

public class ProposeTradeRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("OriginatorPlayerId", "mOriginatorPlayerId", 0x9AFCB000, TdfType.UInt32, 0, true), // FORP
        new TdfMemberInfo("RecipientPlayerId", "mRecipientPlayerId", 0xB21D3000, TdfType.UInt32, 1, true), // LATP
        new TdfMemberInfo("RecipientId", "mRecipientId", 0xB21D3400, TdfType.UInt32, 2, true), // LATT
        new TdfMemberInfo("LeagueId", "mLeagueId", 0xB27A6400, TdfType.UInt32, 3, true), // LGID
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _originatorPlayerId = new(__typeInfos[0]);
    private TdfUInt32 _recipientPlayerId = new(__typeInfos[1]);
    private TdfUInt32 _recipientId = new(__typeInfos[2]);
    private TdfUInt32 _leagueId = new(__typeInfos[3]);

    public ProposeTradeRequest()
    {
        __members = [
            _originatorPlayerId,
            _recipientPlayerId,
            _recipientId,
            _leagueId,
        ];
    }

    public override Tdf CreateNew() => new ProposeTradeRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ProposeTradeRequest";
    public override string GetFullClassName() => "Blaze::League::ProposeTradeRequest";

    public uint OriginatorPlayerId
    {
        get => _originatorPlayerId.Value;
        set => _originatorPlayerId.Value = value;
    }

    public uint RecipientPlayerId
    {
        get => _recipientPlayerId.Value;
        set => _recipientPlayerId.Value = value;
    }

    public uint RecipientId
    {
        get => _recipientId.Value;
        set => _recipientId.Value = value;
    }

    public uint LeagueId
    {
        get => _leagueId.Value;
        set => _leagueId.Value = value;
    }

}

