using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Clubs;

public class ClubsCensusData : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("NumOfClubsByDomain", "mNumOfClubsByDomain", 0x8E290000, TdfType.Map, 0, true), // CBD
        new TdfMemberInfo("NumOfClubMembersByDomain", "mNumOfClubMembersByDomain", 0xB6290000, TdfType.Map, 1, true), // MBD
        new TdfMemberInfo("NumOfOnlineClubsByDomain", "mNumOfOnlineClubsByDomain", 0xBE390000, TdfType.Map, 2, true), // OCD
        new TdfMemberInfo("NumOfOnlineClubMembers", "mNumOfOnlineClubMembers", 0xBE3B4000, TdfType.UInt32, 3, true), // OCM
        new TdfMemberInfo("NumOfOnlineClubMembersByDomain", "mNumOfOnlineClubMembersByDomain", 0xBED90000, TdfType.Map, 4, true), // OMD
        new TdfMemberInfo("NumOfClubMembers", "mNumOfClubMembers", 0xD23B4000, TdfType.UInt32, 5, true), // TCM
        new TdfMemberInfo("NumOfClubs", "mNumOfClubs", 0xD2E8C000, TdfType.UInt32, 6, true), // TNC
        new TdfMemberInfo("NumOfOnlineClubs", "mNumOfOnlineClubs", 0xD2F8C000, TdfType.UInt32, 7, true), // TOC
    ];
    private ITdfMember[] __members;

    private TdfMap<uint, uint> _numOfClubsByDomain = new(__typeInfos[0]);
    private TdfMap<uint, uint> _numOfClubMembersByDomain = new(__typeInfos[1]);
    private TdfMap<uint, uint> _numOfOnlineClubsByDomain = new(__typeInfos[2]);
    private TdfUInt32 _numOfOnlineClubMembers = new(__typeInfos[3]);
    private TdfMap<uint, uint> _numOfOnlineClubMembersByDomain = new(__typeInfos[4]);
    private TdfUInt32 _numOfClubMembers = new(__typeInfos[5]);
    private TdfUInt32 _numOfClubs = new(__typeInfos[6]);
    private TdfUInt32 _numOfOnlineClubs = new(__typeInfos[7]);

    public ClubsCensusData()
    {
        __members = [
            _numOfClubsByDomain,
            _numOfClubMembersByDomain,
            _numOfOnlineClubsByDomain,
            _numOfOnlineClubMembers,
            _numOfOnlineClubMembersByDomain,
            _numOfClubMembers,
            _numOfClubs,
            _numOfOnlineClubs,
        ];
    }

    public override Tdf CreateNew() => new ClubsCensusData();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ClubsCensusData";
    public override string GetFullClassName() => "Blaze::Clubs::ClubsCensusData";

    public IDictionary<uint, uint> NumOfClubsByDomain
    {
        get => _numOfClubsByDomain.Value;
        set => _numOfClubsByDomain.Value = value;
    }

    public IDictionary<uint, uint> NumOfClubMembersByDomain
    {
        get => _numOfClubMembersByDomain.Value;
        set => _numOfClubMembersByDomain.Value = value;
    }

    public IDictionary<uint, uint> NumOfOnlineClubsByDomain
    {
        get => _numOfOnlineClubsByDomain.Value;
        set => _numOfOnlineClubsByDomain.Value = value;
    }

    public uint NumOfOnlineClubMembers
    {
        get => _numOfOnlineClubMembers.Value;
        set => _numOfOnlineClubMembers.Value = value;
    }

    public IDictionary<uint, uint> NumOfOnlineClubMembersByDomain
    {
        get => _numOfOnlineClubMembersByDomain.Value;
        set => _numOfOnlineClubMembersByDomain.Value = value;
    }

    public uint NumOfClubMembers
    {
        get => _numOfClubMembers.Value;
        set => _numOfClubMembers.Value = value;
    }

    public uint NumOfClubs
    {
        get => _numOfClubs.Value;
        set => _numOfClubs.Value = value;
    }

    public uint NumOfOnlineClubs
    {
        get => _numOfOnlineClubs.Value;
        set => _numOfOnlineClubs.Value = value;
    }

}

