using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.GameManager;

public class NotifyGameReportingIdChange : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("gameId", "gameId", 0x9E990000, TdfType.UInt32, 0, true), // GID
        new TdfMemberInfo("gameReportingId", "gameReportingId", 0x9F2A6400, TdfType.UInt32, 1, true), // GRID
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _gameId = new(__typeInfos[0]);
    private TdfUInt32 _gameReportingId = new(__typeInfos[1]);

    public NotifyGameReportingIdChange()
    {
        __members = [
            _gameId,
            _gameReportingId,
        ];
    }

    public override Tdf CreateNew() => new NotifyGameReportingIdChange();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "NotifyGameReportingIdChange";
    public override string GetFullClassName() => "Blaze::GameManager::NotifyGameReportingIdChange";

    public uint gameId
    {
        get => _gameId.Value;
        set => _gameId.Value = value;
    }

    public uint gameReportingId
    {
        get => _gameReportingId.Value;
        set => _gameReportingId.Value = value;
    }

}

