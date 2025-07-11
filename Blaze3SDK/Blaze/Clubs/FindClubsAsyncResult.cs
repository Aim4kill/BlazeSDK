using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Clubs;

public class FindClubsAsyncResult : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Club", "mClub", 0x8ECD6200, TdfType.Struct, 0, true), // CLUB
        new TdfMemberInfo("SequenceID", "mSequenceID", 0xCF1A6400, TdfType.UInt32, 1, true), // SQID
    ];
    private ITdfMember[] __members;

    private TdfStruct<Blaze3SDK.Blaze.Clubs.Club?> _club = new(__typeInfos[0]);
    private TdfUInt32 _sequenceID = new(__typeInfos[1]);

    public FindClubsAsyncResult()
    {
        __members = [
            _club,
            _sequenceID,
        ];
    }

    public override Tdf CreateNew() => new FindClubsAsyncResult();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "FindClubsAsyncResult";
    public override string GetFullClassName() => "Blaze::Clubs::FindClubsAsyncResult";

    public Blaze3SDK.Blaze.Clubs.Club? Club
    {
        get => _club.Value;
        set => _club.Value = value;
    }

    public uint SequenceID
    {
        get => _sequenceID.Value;
        set => _sequenceID.Value = value;
    }

}

