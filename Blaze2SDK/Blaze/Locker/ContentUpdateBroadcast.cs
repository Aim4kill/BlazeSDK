using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Locker;

public class ContentUpdateBroadcast : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("CacheUpdates", "mCacheUpdates", 0xD7093400, TdfType.List, 0, true), // UPDT
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze2SDK.Blaze.Locker.CacheRowUpdate> _cacheUpdates = new(__typeInfos[0]);

    public ContentUpdateBroadcast()
    {
        __members = [
            _cacheUpdates,
        ];
    }

    public override Tdf CreateNew() => new ContentUpdateBroadcast();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ContentUpdateBroadcast";
    public override string GetFullClassName() => "Blaze::Locker::ContentUpdateBroadcast";

    public IList<Blaze2SDK.Blaze.Locker.CacheRowUpdate> CacheUpdates
    {
        get => _cacheUpdates.Value;
        set => _cacheUpdates.Value = value;
    }

}

