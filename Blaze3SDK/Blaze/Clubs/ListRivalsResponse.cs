using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Clubs;

public class ListRivalsResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ClubRivalList", "mClubRivalList", 0xCA9DAC00, TdfType.List, 0, true), // RIVL
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze3SDK.Blaze.Clubs.ClubRival> _clubRivalList = new(__typeInfos[0]);

    public ListRivalsResponse()
    {
        __members = [
            _clubRivalList,
        ];
    }

    public override Tdf CreateNew() => new ListRivalsResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ListRivalsResponse";
    public override string GetFullClassName() => "Blaze::Clubs::ListRivalsResponse";

    public IList<Blaze3SDK.Blaze.Clubs.ClubRival> ClubRivalList
    {
        get => _clubRivalList.Value;
        set => _clubRivalList.Value = value;
    }

}

