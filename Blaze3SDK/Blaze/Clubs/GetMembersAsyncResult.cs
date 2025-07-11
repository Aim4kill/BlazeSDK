using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Clubs;

public class GetMembersAsyncResult : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ClubMember", "mClubMember", 0xB6D8B200, TdfType.Struct, 0, true), // MMBR
        new TdfMemberInfo("SequenceID", "mSequenceID", 0xCF1A6400, TdfType.UInt32, 1, true), // SQID
    ];
    private ITdfMember[] __members;

    private TdfStruct<Blaze3SDK.Blaze.Clubs.ClubMember?> _clubMember = new(__typeInfos[0]);
    private TdfUInt32 _sequenceID = new(__typeInfos[1]);

    public GetMembersAsyncResult()
    {
        __members = [
            _clubMember,
            _sequenceID,
        ];
    }

    public override Tdf CreateNew() => new GetMembersAsyncResult();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetMembersAsyncResult";
    public override string GetFullClassName() => "Blaze::Clubs::GetMembersAsyncResult";

    public Blaze3SDK.Blaze.Clubs.ClubMember? ClubMember
    {
        get => _clubMember.Value;
        set => _clubMember.Value = value;
    }

    public uint SequenceID
    {
        get => _sequenceID.Value;
        set => _sequenceID.Value = value;
    }

}

