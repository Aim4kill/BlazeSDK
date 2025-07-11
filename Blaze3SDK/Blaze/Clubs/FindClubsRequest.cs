using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Clubs;

public class FindClubsRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("AcceptanceFlags", "mAcceptanceFlags", 0x86396600, TdfType.Enum, 0, true), // ACEF
        new TdfMemberInfo("AcceptanceMask", "mAcceptanceMask", 0x863B7300, TdfType.Enum, 1, true), // ACMS
        new TdfMemberInfo("AnyDomain", "mAnyDomain", 0x864A6400, TdfType.Bool, 2, true), // ADID
        new TdfMemberInfo("AnyTeamId", "mAnyTeamId", 0x874A6400, TdfType.Bool, 3, true), // ATID
        new TdfMemberInfo("ClubFilterList", "mClubFilterList", 0x8E6B2900, TdfType.List, 4, true), // CFLI
        new TdfMemberInfo("TagList", "mTagList", 0x8ECD2700, TdfType.List, 5, true), // CLTG
        new TdfMemberInfo("IncludeClubTags", "mIncludeClubTags", 0x8ECD2900, TdfType.Bool, 6, true), // CLTI
        new TdfMemberInfo("TagSearchOperation", "mTagSearchOperation", 0x8ECD2F00, TdfType.Enum, 7, true), // CLTO
        new TdfMemberInfo("Name", "mName", 0x8EE86D00, TdfType.String, 8, true), // CNAM
        new TdfMemberInfo("ClubsOrder", "mClubsOrder", 0x8EF93200, TdfType.Enum, 9, true), // CODR
        new TdfMemberInfo("Region", "mRegion", 0x8F296700, TdfType.UInt32, 10, true), // CREG
        new TdfMemberInfo("ClubDomainId", "mClubDomainId", 0x92DA6400, TdfType.UInt32, 11, true), // DMID
        new TdfMemberInfo("Language", "mLanguage", 0xB21BA700, TdfType.String, 12, true), // LANG
        new TdfMemberInfo("LastGameTimeOffset", "mLastGameTimeOffset", 0xB27D2D00, TdfType.UInt32, 13, true), // LGTM
        new TdfMemberInfo("MaxMemberCount", "mMaxMemberCount", 0xB61B6300, TdfType.UInt32, 14, true), // MAMC
        new TdfMemberInfo("MinMemberCount", "mMinMemberCount", 0xB69B6300, TdfType.UInt32, 15, true), // MIMC
        new TdfMemberInfo("MinMemberOnlineStatusCounts", "mMinMemberOnlineStatusCounts", 0xB6DCE300, TdfType.Map, 16, true), // MMSC
        new TdfMemberInfo("MaxResultCount", "mMaxResultCount", 0xB78CA300, TdfType.UInt32, 17, true), // MXRC
        new TdfMemberInfo("NonUniqueName", "mNonUniqueName", 0xBB5C6E00, TdfType.String, 18, true), // NUQN
        new TdfMemberInfo("OrderMode", "mOrderMode", 0xBE4B6400, TdfType.Enum, 19, true), // ODMD
        new TdfMemberInfo("Offset", "mOffset", 0xBE6CA300, TdfType.UInt32, 20, true), // OFRC
        new TdfMemberInfo("PasswordOption", "mPasswordOption", 0xC33DE400, TdfType.Enum, 21, true), // PSWD
        new TdfMemberInfo("SeasonLevel", "mSeasonLevel", 0xCE586C00, TdfType.UInt32, 22, true), // SEAL
        new TdfMemberInfo("SkipCalcDbRows", "mSkipCalcDbRows", 0xCEB8F400, TdfType.Bool, 23, true), // SKCT
        new TdfMemberInfo("SkipMetadata", "mSkipMetadata", 0xCEBB6400, TdfType.UInt8, 24, true), // SKMD
        new TdfMemberInfo("TeamId", "mTeamId", 0xD2DA6400, TdfType.UInt32, 25, true), // TMID
        new TdfMemberInfo("MemberFilterList", "mMemberFilterList", 0xD66B2900, TdfType.List, 26, true), // UFLI
    ];
    private ITdfMember[] __members;

    private TdfEnum<Blaze3SDK.Blaze.Clubs.ClubAcceptanceFlags> _acceptanceFlags = new(__typeInfos[0]);
    private TdfEnum<Blaze3SDK.Blaze.Clubs.ClubAcceptanceFlags> _acceptanceMask = new(__typeInfos[1]);
    private TdfBool _anyDomain = new(__typeInfos[2]);
    private TdfBool _anyTeamId = new(__typeInfos[3]);
    private TdfList<uint> _clubFilterList = new(__typeInfos[4]);
    private TdfList<string> _tagList = new(__typeInfos[5]);
    private TdfBool _includeClubTags = new(__typeInfos[6]);
    private TdfEnum<Blaze3SDK.Blaze.Clubs.TagSearchOperation> _tagSearchOperation = new(__typeInfos[7]);
    private TdfString _name = new(__typeInfos[8]);
    private TdfEnum<Blaze3SDK.Blaze.Clubs.ClubsOrder> _clubsOrder = new(__typeInfos[9]);
    private TdfUInt32 _region = new(__typeInfos[10]);
    private TdfUInt32 _clubDomainId = new(__typeInfos[11]);
    private TdfString _language = new(__typeInfos[12]);
    private TdfUInt32 _lastGameTimeOffset = new(__typeInfos[13]);
    private TdfUInt32 _maxMemberCount = new(__typeInfos[14]);
    private TdfUInt32 _minMemberCount = new(__typeInfos[15]);
    private TdfMap<Blaze3SDK.Blaze.Clubs.MemberOnlineStatus, ushort> _minMemberOnlineStatusCounts = new(__typeInfos[16]);
    private TdfUInt32 _maxResultCount = new(__typeInfos[17]);
    private TdfString _nonUniqueName = new(__typeInfos[18]);
    private TdfEnum<Blaze3SDK.Blaze.Clubs.OrderMode> _orderMode = new(__typeInfos[19]);
    private TdfUInt32 _offset = new(__typeInfos[20]);
    private TdfEnum<Blaze3SDK.Blaze.Clubs.PasswordOption> _passwordOption = new(__typeInfos[21]);
    private TdfUInt32 _seasonLevel = new(__typeInfos[22]);
    private TdfBool _skipCalcDbRows = new(__typeInfos[23]);
    private TdfUInt8 _skipMetadata = new(__typeInfos[24]);
    private TdfUInt32 _teamId = new(__typeInfos[25]);
    private TdfList<long> _memberFilterList = new(__typeInfos[26]);

    public FindClubsRequest()
    {
        __members = [
            _acceptanceFlags,
            _acceptanceMask,
            _anyDomain,
            _anyTeamId,
            _clubFilterList,
            _tagList,
            _includeClubTags,
            _tagSearchOperation,
            _name,
            _clubsOrder,
            _region,
            _clubDomainId,
            _language,
            _lastGameTimeOffset,
            _maxMemberCount,
            _minMemberCount,
            _minMemberOnlineStatusCounts,
            _maxResultCount,
            _nonUniqueName,
            _orderMode,
            _offset,
            _passwordOption,
            _seasonLevel,
            _skipCalcDbRows,
            _skipMetadata,
            _teamId,
            _memberFilterList,
        ];
    }

    public override Tdf CreateNew() => new FindClubsRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "FindClubsRequest";
    public override string GetFullClassName() => "Blaze::Clubs::FindClubsRequest";

    public Blaze3SDK.Blaze.Clubs.ClubAcceptanceFlags AcceptanceFlags
    {
        get => _acceptanceFlags.Value;
        set => _acceptanceFlags.Value = value;
    }

    public Blaze3SDK.Blaze.Clubs.ClubAcceptanceFlags AcceptanceMask
    {
        get => _acceptanceMask.Value;
        set => _acceptanceMask.Value = value;
    }

    public bool AnyDomain
    {
        get => _anyDomain.Value;
        set => _anyDomain.Value = value;
    }

    public bool AnyTeamId
    {
        get => _anyTeamId.Value;
        set => _anyTeamId.Value = value;
    }

    public IList<uint> ClubFilterList
    {
        get => _clubFilterList.Value;
        set => _clubFilterList.Value = value;
    }

    public IList<string> TagList
    {
        get => _tagList.Value;
        set => _tagList.Value = value;
    }

    public bool IncludeClubTags
    {
        get => _includeClubTags.Value;
        set => _includeClubTags.Value = value;
    }

    public Blaze3SDK.Blaze.Clubs.TagSearchOperation TagSearchOperation
    {
        get => _tagSearchOperation.Value;
        set => _tagSearchOperation.Value = value;
    }

    public string Name
    {
        get => _name.Value;
        set => _name.Value = value;
    }

    public Blaze3SDK.Blaze.Clubs.ClubsOrder ClubsOrder
    {
        get => _clubsOrder.Value;
        set => _clubsOrder.Value = value;
    }

    public uint Region
    {
        get => _region.Value;
        set => _region.Value = value;
    }

    public uint ClubDomainId
    {
        get => _clubDomainId.Value;
        set => _clubDomainId.Value = value;
    }

    public string Language
    {
        get => _language.Value;
        set => _language.Value = value;
    }

    public uint LastGameTimeOffset
    {
        get => _lastGameTimeOffset.Value;
        set => _lastGameTimeOffset.Value = value;
    }

    public uint MaxMemberCount
    {
        get => _maxMemberCount.Value;
        set => _maxMemberCount.Value = value;
    }

    public uint MinMemberCount
    {
        get => _minMemberCount.Value;
        set => _minMemberCount.Value = value;
    }

    public IDictionary<Blaze3SDK.Blaze.Clubs.MemberOnlineStatus, ushort> MinMemberOnlineStatusCounts
    {
        get => _minMemberOnlineStatusCounts.Value;
        set => _minMemberOnlineStatusCounts.Value = value;
    }

    public uint MaxResultCount
    {
        get => _maxResultCount.Value;
        set => _maxResultCount.Value = value;
    }

    public string NonUniqueName
    {
        get => _nonUniqueName.Value;
        set => _nonUniqueName.Value = value;
    }

    public Blaze3SDK.Blaze.Clubs.OrderMode OrderMode
    {
        get => _orderMode.Value;
        set => _orderMode.Value = value;
    }

    public uint Offset
    {
        get => _offset.Value;
        set => _offset.Value = value;
    }

    public Blaze3SDK.Blaze.Clubs.PasswordOption PasswordOption
    {
        get => _passwordOption.Value;
        set => _passwordOption.Value = value;
    }

    public uint SeasonLevel
    {
        get => _seasonLevel.Value;
        set => _seasonLevel.Value = value;
    }

    public bool SkipCalcDbRows
    {
        get => _skipCalcDbRows.Value;
        set => _skipCalcDbRows.Value = value;
    }

    public byte SkipMetadata
    {
        get => _skipMetadata.Value;
        set => _skipMetadata.Value = value;
    }

    public uint TeamId
    {
        get => _teamId.Value;
        set => _teamId.Value = value;
    }

    public IList<long> MemberFilterList
    {
        get => _memberFilterList.Value;
        set => _memberFilterList.Value = value;
    }

}

