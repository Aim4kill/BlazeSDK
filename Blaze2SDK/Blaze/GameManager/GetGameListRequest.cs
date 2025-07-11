using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.GameManager;

public class GetGameListRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ListConfigName", "mListConfigName", 0x92E86D00, TdfType.String, 0, true), // DNAM
        new TdfMemberInfo("ListCriteria", "mListCriteria", 0x9ECA6400, TdfType.Struct, 1, true), // GLID
        new TdfMemberInfo("GameProtocolVersionString", "mGameProtocolVersionString", 0x9F697200, TdfType.String, 2, true), // GVER
        new TdfMemberInfo("IgnoreGameEntryCriteria", "mIgnoreGameEntryCriteria", 0xA67BAF00, TdfType.Bool, 3, true), // IGNO
        new TdfMemberInfo("ListCapacity", "mListCapacity", 0xB2387000, TdfType.UInt32, 4, true), // LCAP
        new TdfMemberInfo("IgnoreGameJoinMethod", "mIgnoreGameJoinMethod", 0xBAFAAD00, TdfType.Bool, 5, true), // NOJM
    ];
    private ITdfMember[] __members;

    private TdfString _listConfigName = new(__typeInfos[0]);
    private TdfStruct<Blaze2SDK.Blaze.GameManager.MatchmakingCriteriaData?> _listCriteria = new(__typeInfos[1]);
    private TdfString _gameProtocolVersionString = new(__typeInfos[2]);
    private TdfBool _ignoreGameEntryCriteria = new(__typeInfos[3]);
    private TdfUInt32 _listCapacity = new(__typeInfos[4]);
    private TdfBool _ignoreGameJoinMethod = new(__typeInfos[5]);

    public GetGameListRequest()
    {
        __members = [
            _listConfigName,
            _listCriteria,
            _gameProtocolVersionString,
            _ignoreGameEntryCriteria,
            _listCapacity,
            _ignoreGameJoinMethod,
        ];
    }

    public override Tdf CreateNew() => new GetGameListRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetGameListRequest";
    public override string GetFullClassName() => "Blaze::GameManager::GetGameListRequest";

    public string ListConfigName
    {
        get => _listConfigName.Value;
        set => _listConfigName.Value = value;
    }

    public Blaze2SDK.Blaze.GameManager.MatchmakingCriteriaData? ListCriteria
    {
        get => _listCriteria.Value;
        set => _listCriteria.Value = value;
    }

    public string GameProtocolVersionString
    {
        get => _gameProtocolVersionString.Value;
        set => _gameProtocolVersionString.Value = value;
    }

    public bool IgnoreGameEntryCriteria
    {
        get => _ignoreGameEntryCriteria.Value;
        set => _ignoreGameEntryCriteria.Value = value;
    }

    public uint ListCapacity
    {
        get => _listCapacity.Value;
        set => _listCapacity.Value = value;
    }

    public bool IgnoreGameJoinMethod
    {
        get => _ignoreGameJoinMethod.Value;
        set => _ignoreGameJoinMethod.Value = value;
    }

}

