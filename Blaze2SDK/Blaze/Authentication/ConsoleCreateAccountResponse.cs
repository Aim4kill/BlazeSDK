using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Authentication;

public class ConsoleCreateAccountResponse : Tdf
{
    public enum CreateResult : int
    {
        CREATED = 0,
        ASSOCIATED = 1,
        ACTIVATED = 2,
    }
    
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("CreateResult", "mCreateResult", 0xCB3B3400, TdfType.Enum, 0, true), // RSLT
        new TdfMemberInfo("SessionInfo", "mSessionInfo", 0xCE5CF300, TdfType.Struct, 1, true), // SESS
    ];
    private ITdfMember[] __members;

    private TdfEnum<Blaze2SDK.Blaze.Authentication.ConsoleCreateAccountResponse.CreateResult> _createResult = new(__typeInfos[0]);
    private TdfStruct<Blaze2SDK.Blaze.Authentication.SessionInfo?> _sessionInfo = new(__typeInfos[1]);

    public ConsoleCreateAccountResponse()
    {
        __members = [
            _createResult,
            _sessionInfo,
        ];
    }

    public override Tdf CreateNew() => new ConsoleCreateAccountResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ConsoleCreateAccountResponse";
    public override string GetFullClassName() => "Blaze::Authentication::ConsoleCreateAccountResponse";

    public Blaze2SDK.Blaze.Authentication.ConsoleCreateAccountResponse.CreateResult mCreateResult
    {
        get => _createResult.Value;
        set => _createResult.Value = value;
    }

    public Blaze2SDK.Blaze.Authentication.SessionInfo? SessionInfo
    {
        get => _sessionInfo.Value;
        set => _sessionInfo.Value = value;
    }

}

