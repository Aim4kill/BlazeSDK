using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.League;

public class GetMembersResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("MemberInfo", "mMemberInfo", 0xB62A6600, TdfType.List, 0, true), // MBIF
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze3SDK.Blaze.League.MemberInfo> _memberInfo = new(__typeInfos[0]);

    public GetMembersResponse()
    {
        __members = [
            _memberInfo,
        ];
    }

    public override Tdf CreateNew() => new GetMembersResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetMembersResponse";
    public override string GetFullClassName() => "Blaze::League::GetMembersResponse";

    public IList<Blaze3SDK.Blaze.League.MemberInfo> MemberInfo
    {
        get => _memberInfo.Value;
        set => _memberInfo.Value = value;
    }

}

