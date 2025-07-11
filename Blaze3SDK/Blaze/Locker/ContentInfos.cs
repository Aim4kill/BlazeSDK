using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Locker;

public class ContentInfos : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ContentInfoList", "mContentInfoList", 0xB2BCB300, TdfType.List, 0, true), // LKRS
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze3SDK.Blaze.Locker.ContentInfo> _contentInfoList = new(__typeInfos[0]);

    public ContentInfos()
    {
        __members = [
            _contentInfoList,
        ];
    }

    public override Tdf CreateNew() => new ContentInfos();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ContentInfos";
    public override string GetFullClassName() => "Blaze::Locker::ContentInfos";

    public IList<Blaze3SDK.Blaze.Locker.ContentInfo> ContentInfoList
    {
        get => _contentInfoList.Value;
        set => _contentInfoList.Value = value;
    }

}

