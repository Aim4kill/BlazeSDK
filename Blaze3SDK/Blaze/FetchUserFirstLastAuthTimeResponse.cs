using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze;

public class FetchUserFirstLastAuthTimeResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("UserFirstAuthTime", "mUserFirstAuthTime", 0xD6687400, TdfType.Int64, 0, true), // UFAT
        new TdfMemberInfo("UserLastAuthTime", "mUserLastAuthTime", 0xD6C87400, TdfType.Int64, 1, true), // ULAT
    ];
    private ITdfMember[] __members;

    private TdfInt64 _userFirstAuthTime = new(__typeInfos[0]);
    private TdfInt64 _userLastAuthTime = new(__typeInfos[1]);

    public FetchUserFirstLastAuthTimeResponse()
    {
        __members = [
            _userFirstAuthTime,
            _userLastAuthTime,
        ];
    }

    public override Tdf CreateNew() => new FetchUserFirstLastAuthTimeResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "FetchUserFirstLastAuthTimeResponse";
    public override string GetFullClassName() => "Blaze::FetchUserFirstLastAuthTimeResponse";

    public long UserFirstAuthTime
    {
        get => _userFirstAuthTime.Value;
        set => _userFirstAuthTime.Value = value;
    }

    public long UserLastAuthTime
    {
        get => _userLastAuthTime.Value;
        set => _userLastAuthTime.Value = value;
    }

}

