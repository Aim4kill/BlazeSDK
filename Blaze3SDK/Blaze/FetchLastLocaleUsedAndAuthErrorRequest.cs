using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze;

public class FetchLastLocaleUsedAndAuthErrorRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("UserId", "mUserId", 0xA6400000, TdfType.Int64, 0, true), // ID
    ];
    private ITdfMember[] __members;

    private TdfInt64 _userId = new(__typeInfos[0]);

    public FetchLastLocaleUsedAndAuthErrorRequest()
    {
        __members = [
            _userId,
        ];
    }

    public override Tdf CreateNew() => new FetchLastLocaleUsedAndAuthErrorRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "FetchLastLocaleUsedAndAuthErrorRequest";
    public override string GetFullClassName() => "Blaze::FetchLastLocaleUsedAndAuthErrorRequest";

    public long UserId
    {
        get => _userId.Value;
        set => _userId.Value = value;
    }

}

