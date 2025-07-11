using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Util;

public class GetUserOptionsRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("UserId", "mUserId", 0xD6990000, TdfType.Int64, 0, true), // UID
    ];
    private ITdfMember[] __members;

    private TdfInt64 _userId = new(__typeInfos[0]);

    public GetUserOptionsRequest()
    {
        __members = [
            _userId,
        ];
    }

    public override Tdf CreateNew() => new GetUserOptionsRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetUserOptionsRequest";
    public override string GetFullClassName() => "Blaze::Util::GetUserOptionsRequest";

    public long UserId
    {
        get => _userId.Value;
        set => _userId.Value = value;
    }

}

