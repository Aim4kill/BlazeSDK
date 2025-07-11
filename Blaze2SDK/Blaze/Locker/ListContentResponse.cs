using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Locker;

public class ListContentResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ContentInfo", "mContentInfo", 0xB2BCB300, TdfType.List, 0, true), // LKRS
        new TdfMemberInfo("SizeAllowed", "mSizeAllowed", 0xB73A7A00, TdfType.Int32, 1, true), // MSIZ
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze2SDK.Blaze.Locker.ContentInfo> _contentInfo = new(__typeInfos[0]);
    private TdfInt32 _sizeAllowed = new(__typeInfos[1]);

    public ListContentResponse()
    {
        __members = [
            _contentInfo,
            _sizeAllowed,
        ];
    }

    public override Tdf CreateNew() => new ListContentResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ListContentResponse";
    public override string GetFullClassName() => "Blaze::Locker::ListContentResponse";

    public IList<Blaze2SDK.Blaze.Locker.ContentInfo> ContentInfo
    {
        get => _contentInfo.Value;
        set => _contentInfo.Value = value;
    }

    public int SizeAllowed
    {
        get => _sizeAllowed.Value;
        set => _sizeAllowed.Value = value;
    }

}

