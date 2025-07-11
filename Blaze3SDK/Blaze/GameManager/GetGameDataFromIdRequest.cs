using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameManager;

public class GetGameDataFromIdRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ListConfigName", "mListConfigName", 0x92E86D00, TdfType.String, 0, true), // DNAM
        new TdfMemberInfo("GameIds", "mGameIds", 0x9ECCF400, TdfType.List, 1, true), // GLST
        new TdfMemberInfo("PersistedGameIdList", "mPersistedGameIdList", 0xC2992C00, TdfType.List, 2, true), // PIDL
    ];
    private ITdfMember[] __members;

    private TdfString _listConfigName = new(__typeInfos[0]);
    private TdfList<uint> _gameIds = new(__typeInfos[1]);
    private TdfList<string> _persistedGameIdList = new(__typeInfos[2]);

    public GetGameDataFromIdRequest()
    {
        __members = [
            _listConfigName,
            _gameIds,
            _persistedGameIdList,
        ];
    }

    public override Tdf CreateNew() => new GetGameDataFromIdRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetGameDataFromIdRequest";
    public override string GetFullClassName() => "Blaze::GameManager::GetGameDataFromIdRequest";

    public string ListConfigName
    {
        get => _listConfigName.Value;
        set => _listConfigName.Value = value;
    }

    public IList<uint> GameIds
    {
        get => _gameIds.Value;
        set => _gameIds.Value = value;
    }

    public IList<string> PersistedGameIdList
    {
        get => _persistedGameIdList.Value;
        set => _persistedGameIdList.Value = value;
    }

}

