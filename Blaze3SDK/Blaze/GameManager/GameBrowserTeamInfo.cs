using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameManager;

public class GameBrowserTeamInfo : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("TeamId", "mTeamId", 0xD2990000, TdfType.UInt16, 0, true), // TID
        new TdfMemberInfo("TeamSize", "mTeamSize", 0xD33EA500, TdfType.UInt16, 1, true), // TSZE
    ];
    private ITdfMember[] __members;

    private TdfUInt16 _teamId = new(__typeInfos[0]);
    private TdfUInt16 _teamSize = new(__typeInfos[1]);

    public GameBrowserTeamInfo()
    {
        __members = [
            _teamId,
            _teamSize,
        ];
    }

    public override Tdf CreateNew() => new GameBrowserTeamInfo();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GameBrowserTeamInfo";
    public override string GetFullClassName() => "Blaze::GameManager::GameBrowserTeamInfo";

    public ushort TeamId
    {
        get => _teamId.Value;
        set => _teamId.Value = value;
    }

    public ushort TeamSize
    {
        get => _teamSize.Value;
        set => _teamSize.Value = value;
    }

}

