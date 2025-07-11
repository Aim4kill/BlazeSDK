using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Clubs;

public class GetDivisionResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Division", "mDivision", 0x929DAE00, TdfType.UInt32, 0, true), // DIVN
        new TdfMemberInfo("StartingRank", "mStartingRank", 0xCF2BAB00, TdfType.UInt32, 1, true), // SRNK
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _division = new(__typeInfos[0]);
    private TdfUInt32 _startingRank = new(__typeInfos[1]);

    public GetDivisionResponse()
    {
        __members = [
            _division,
            _startingRank,
        ];
    }

    public override Tdf CreateNew() => new GetDivisionResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetDivisionResponse";
    public override string GetFullClassName() => "Blaze::Clubs::GetDivisionResponse";

    public uint Division
    {
        get => _division.Value;
        set => _division.Value = value;
    }

    public uint StartingRank
    {
        get => _startingRank.Value;
        set => _startingRank.Value = value;
    }

}

