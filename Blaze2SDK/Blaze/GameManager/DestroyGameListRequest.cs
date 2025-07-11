using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.GameManager;

public class DestroyGameListRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ListId", "mListId", 0x9ECA6400, TdfType.UInt32, 0, true), // GLID
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _listId = new(__typeInfos[0]);

    public DestroyGameListRequest()
    {
        __members = [
            _listId,
        ];
    }

    public override Tdf CreateNew() => new DestroyGameListRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "DestroyGameListRequest";
    public override string GetFullClassName() => "Blaze::GameManager::DestroyGameListRequest";

    public uint ListId
    {
        get => _listId.Value;
        set => _listId.Value = value;
    }

}

