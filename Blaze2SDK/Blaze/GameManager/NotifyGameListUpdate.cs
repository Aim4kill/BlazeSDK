using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.GameManager;

public class NotifyGameListUpdate : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("IsFinalUpdate", "mIsFinalUpdate", 0x92FBA500, TdfType.UInt8, 0, true), // DONE
        new TdfMemberInfo("ListId", "mListId", 0x9ECA6400, TdfType.UInt32, 1, true), // GLID
        new TdfMemberInfo("RemovedGameList", "mRemovedGameList", 0xCA5B7600, TdfType.List, 2, true), // REMV
        new TdfMemberInfo("UpdatedGames", "mUpdatedGames", 0xD7093400, TdfType.List, 3, true), // UPDT
    ];
    private ITdfMember[] __members;

    private TdfUInt8 _isFinalUpdate = new(__typeInfos[0]);
    private TdfUInt32 _listId = new(__typeInfos[1]);
    private TdfList<uint> _removedGameList = new(__typeInfos[2]);
    private TdfList<Blaze2SDK.Blaze.GameManager.GameBrowserGameData> _updatedGames = new(__typeInfos[3]);

    public NotifyGameListUpdate()
    {
        __members = [
            _isFinalUpdate,
            _listId,
            _removedGameList,
            _updatedGames,
        ];
    }

    public override Tdf CreateNew() => new NotifyGameListUpdate();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "NotifyGameListUpdate";
    public override string GetFullClassName() => "Blaze::GameManager::NotifyGameListUpdate";

    public byte IsFinalUpdate
    {
        get => _isFinalUpdate.Value;
        set => _isFinalUpdate.Value = value;
    }

    public uint ListId
    {
        get => _listId.Value;
        set => _listId.Value = value;
    }

    public IList<uint> RemovedGameList
    {
        get => _removedGameList.Value;
        set => _removedGameList.Value = value;
    }

    public IList<Blaze2SDK.Blaze.GameManager.GameBrowserGameData> UpdatedGames
    {
        get => _updatedGames.Value;
        set => _updatedGames.Value = value;
    }

}

