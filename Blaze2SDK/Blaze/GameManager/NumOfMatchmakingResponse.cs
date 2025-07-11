using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.GameManager;

public class NumOfMatchmakingResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("NumOfMatchmakingSessions", "mNumOfMatchmakingSessions", 0xBAFB6D00, TdfType.UInt32, 0, true), // NOMM
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _numOfMatchmakingSessions = new(__typeInfos[0]);

    public NumOfMatchmakingResponse()
    {
        __members = [
            _numOfMatchmakingSessions,
        ];
    }

    public override Tdf CreateNew() => new NumOfMatchmakingResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "NumOfMatchmakingResponse";
    public override string GetFullClassName() => "Blaze::GameManager::NumOfMatchmakingResponse";

    public uint NumOfMatchmakingSessions
    {
        get => _numOfMatchmakingSessions.Value;
        set => _numOfMatchmakingSessions.Value = value;
    }

}

