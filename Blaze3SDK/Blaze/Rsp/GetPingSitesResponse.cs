using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Rsp;

public class GetPingSitesResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("PingSites", "mPingSites", 0xC2CCF400, TdfType.List, 0, true), // PLST
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze3SDK.Blaze.Rsp.RspPingSiteInfo> _pingSites = new(__typeInfos[0]);

    public GetPingSitesResponse()
    {
        __members = [
            _pingSites,
        ];
    }

    public override Tdf CreateNew() => new GetPingSitesResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetPingSitesResponse";
    public override string GetFullClassName() => "Blaze::Rsp::GetPingSitesResponse";

    public IList<Blaze3SDK.Blaze.Rsp.RspPingSiteInfo> PingSites
    {
        get => _pingSites.Value;
        set => _pingSites.Value = value;
    }

}

