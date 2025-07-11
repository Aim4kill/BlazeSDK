using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.GameManager;

public class GetFullGameDataRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("GameIdList", "mGameIdList", 0x9E992C00, TdfType.List, 0, true), // GIDL
        new TdfMemberInfo("PersistedGameIdList", "mPersistedGameIdList", 0xC2992C00, TdfType.List, 1, true), // PIDL
    ];
    private ITdfMember[] __members;

    private TdfList<uint> _gameIdList = new(__typeInfos[0]);
    private TdfList<string> _persistedGameIdList = new(__typeInfos[1]);

    public GetFullGameDataRequest()
    {
        __members = [
            _gameIdList,
            _persistedGameIdList,
        ];
    }

    public override Tdf CreateNew() => new GetFullGameDataRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetFullGameDataRequest";
    public override string GetFullClassName() => "Blaze::GameManager::GetFullGameDataRequest";

    public IList<uint> GameIdList
    {
        get => _gameIdList.Value;
        set => _gameIdList.Value = value;
    }

    public IList<string> PersistedGameIdList
    {
        get => _persistedGameIdList.Value;
        set => _persistedGameIdList.Value = value;
    }

}

