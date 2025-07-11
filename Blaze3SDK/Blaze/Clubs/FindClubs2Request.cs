using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Clubs;

public class FindClubs2Request : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("MemberOnlineStatusSum", "mMemberOnlineStatusSum", 0xB6FCE300, TdfType.UInt32, 0, true), // MOSC
        new TdfMemberInfo("MemberOnlineStatusFilter", "mMemberOnlineStatusFilter", 0xB6FCEC00, TdfType.List, 1, true), // MOSL
        new TdfMemberInfo("Params", "mParams", 0xCB1CF400, TdfType.Struct, 2, true), // RQST
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _memberOnlineStatusSum = new(__typeInfos[0]);
    private TdfList<Blaze3SDK.Blaze.Clubs.MemberOnlineStatus> _memberOnlineStatusFilter = new(__typeInfos[1]);
    private TdfStruct<Blaze3SDK.Blaze.Clubs.FindClubsRequest?> _params = new(__typeInfos[2]);

    public FindClubs2Request()
    {
        __members = [
            _memberOnlineStatusSum,
            _memberOnlineStatusFilter,
            _params,
        ];
    }

    public override Tdf CreateNew() => new FindClubs2Request();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "FindClubs2Request";
    public override string GetFullClassName() => "Blaze::Clubs::FindClubs2Request";

    public uint MemberOnlineStatusSum
    {
        get => _memberOnlineStatusSum.Value;
        set => _memberOnlineStatusSum.Value = value;
    }

    public IList<Blaze3SDK.Blaze.Clubs.MemberOnlineStatus> MemberOnlineStatusFilter
    {
        get => _memberOnlineStatusFilter.Value;
        set => _memberOnlineStatusFilter.Value = value;
    }

    public Blaze3SDK.Blaze.Clubs.FindClubsRequest? Params
    {
        get => _params.Value;
        set => _params.Value = value;
    }

}

