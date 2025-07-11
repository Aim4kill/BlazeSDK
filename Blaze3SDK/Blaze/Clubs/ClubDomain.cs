using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Clubs;

public class ClubDomain : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("AllowMemberToRetrievePassword", "mAllowMemberToRetrievePassword", 0x86DCB000, TdfType.Bool, 0, true), // AMRP
        new TdfMemberInfo("ClubDomainId", "mClubDomainId", 0x92DA6400, TdfType.UInt32, 1, true), // DMID
        new TdfMemberInfo("DomainName", "mDomainName", 0x92E86D00, TdfType.String, 2, true), // DNAM
        new TdfMemberInfo("TrackMembershipInUED", "mTrackMembershipInUED", 0x93596400, TdfType.Bool, 3, true), // DUED
        new TdfMemberInfo("MaxGMsPerClub", "mMaxGMsPerClub", 0x9389ED00, TdfType.UInt16, 4, true), // DXGM
        new TdfMemberInfo("MaxInactiveDaysPerClub", "mMaxInactiveDaysPerClub", 0x938A6100, TdfType.UInt16, 5, true), // DXIA
        new TdfMemberInfo("MaxInvitationsPerUserOrClub", "mMaxInvitationsPerUserOrClub", 0x938A7600, TdfType.UInt16, 6, true), // DXIV
        new TdfMemberInfo("MaxMembersPerClub", "mMaxMembersPerClub", 0x938B6200, TdfType.UInt32, 7, true), // DXMB
        new TdfMemberInfo("MaxMembershipsPerUser", "mMaxMembershipsPerUser", 0x938B7300, TdfType.UInt16, 8, true), // DXMS
        new TdfMemberInfo("MaxNewsItemsPerClub", "mMaxNewsItemsPerClub", 0x938BB700, TdfType.UInt16, 9, true), // DXNW
    ];
    private ITdfMember[] __members;

    private TdfBool _allowMemberToRetrievePassword = new(__typeInfos[0]);
    private TdfUInt32 _clubDomainId = new(__typeInfos[1]);
    private TdfString _domainName = new(__typeInfos[2]);
    private TdfBool _trackMembershipInUED = new(__typeInfos[3]);
    private TdfUInt16 _maxGMsPerClub = new(__typeInfos[4]);
    private TdfUInt16 _maxInactiveDaysPerClub = new(__typeInfos[5]);
    private TdfUInt16 _maxInvitationsPerUserOrClub = new(__typeInfos[6]);
    private TdfUInt32 _maxMembersPerClub = new(__typeInfos[7]);
    private TdfUInt16 _maxMembershipsPerUser = new(__typeInfos[8]);
    private TdfUInt16 _maxNewsItemsPerClub = new(__typeInfos[9]);

    public ClubDomain()
    {
        __members = [
            _allowMemberToRetrievePassword,
            _clubDomainId,
            _domainName,
            _trackMembershipInUED,
            _maxGMsPerClub,
            _maxInactiveDaysPerClub,
            _maxInvitationsPerUserOrClub,
            _maxMembersPerClub,
            _maxMembershipsPerUser,
            _maxNewsItemsPerClub,
        ];
    }

    public override Tdf CreateNew() => new ClubDomain();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ClubDomain";
    public override string GetFullClassName() => "Blaze::Clubs::ClubDomain";

    public bool AllowMemberToRetrievePassword
    {
        get => _allowMemberToRetrievePassword.Value;
        set => _allowMemberToRetrievePassword.Value = value;
    }

    public uint ClubDomainId
    {
        get => _clubDomainId.Value;
        set => _clubDomainId.Value = value;
    }

    public string DomainName
    {
        get => _domainName.Value;
        set => _domainName.Value = value;
    }

    public bool TrackMembershipInUED
    {
        get => _trackMembershipInUED.Value;
        set => _trackMembershipInUED.Value = value;
    }

    public ushort MaxGMsPerClub
    {
        get => _maxGMsPerClub.Value;
        set => _maxGMsPerClub.Value = value;
    }

    public ushort MaxInactiveDaysPerClub
    {
        get => _maxInactiveDaysPerClub.Value;
        set => _maxInactiveDaysPerClub.Value = value;
    }

    public ushort MaxInvitationsPerUserOrClub
    {
        get => _maxInvitationsPerUserOrClub.Value;
        set => _maxInvitationsPerUserOrClub.Value = value;
    }

    public uint MaxMembersPerClub
    {
        get => _maxMembersPerClub.Value;
        set => _maxMembersPerClub.Value = value;
    }

    public ushort MaxMembershipsPerUser
    {
        get => _maxMembershipsPerUser.Value;
        set => _maxMembershipsPerUser.Value = value;
    }

    public ushort MaxNewsItemsPerClub
    {
        get => _maxNewsItemsPerClub.Value;
        set => _maxNewsItemsPerClub.Value = value;
    }

}

