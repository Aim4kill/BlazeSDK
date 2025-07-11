using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Locker;

public class ContentDeleteBroadcast : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("CacheDeletes", "mCacheDeletes", 0x925B2500, TdfType.List, 0, true), // DELE
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze2SDK.Blaze.Locker.CacheDelete> _cacheDeletes = new(__typeInfos[0]);

    public ContentDeleteBroadcast()
    {
        __members = [
            _cacheDeletes,
        ];
    }

    public override Tdf CreateNew() => new ContentDeleteBroadcast();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ContentDeleteBroadcast";
    public override string GetFullClassName() => "Blaze::Locker::ContentDeleteBroadcast";

    public IList<Blaze2SDK.Blaze.Locker.CacheDelete> CacheDeletes
    {
        get => _cacheDeletes.Value;
        set => _cacheDeletes.Value = value;
    }

}

