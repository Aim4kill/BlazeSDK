using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.GameManager;

public class FindGameStatus : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("NumOfGames", "mNumOfGames", 0x9EED6D00, TdfType.UInt32, 0, true), // GNUM
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _numOfGames = new(__typeInfos[0]);

    public FindGameStatus()
    {
        __members = [
            _numOfGames,
        ];
    }

    public override Tdf CreateNew() => new FindGameStatus();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "FindGameStatus";
    public override string GetFullClassName() => "Blaze::GameManager::FindGameStatus";

    public uint NumOfGames
    {
        get => _numOfGames.Value;
        set => _numOfGames.Value = value;
    }

}

