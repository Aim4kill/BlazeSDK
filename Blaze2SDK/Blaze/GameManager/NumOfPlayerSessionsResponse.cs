using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.GameManager;

public class NumOfPlayerSessionsResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("NumOfPlayerSessions", "mNumOfPlayerSessions", 0xBAFB6D00, TdfType.UInt32, 0, true), // NOMM
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _numOfPlayerSessions = new(__typeInfos[0]);

    public NumOfPlayerSessionsResponse()
    {
        __members = [
            _numOfPlayerSessions,
        ];
    }

    public override Tdf CreateNew() => new NumOfPlayerSessionsResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "NumOfPlayerSessionsResponse";
    public override string GetFullClassName() => "Blaze::GameManager::NumOfPlayerSessionsResponse";

    public uint NumOfPlayerSessions
    {
        get => _numOfPlayerSessions.Value;
        set => _numOfPlayerSessions.Value = value;
    }

}

