using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Stats;

public class GetLeaderboardTreeRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("FolderName", "mFolderName", 0xBA1B6500, TdfType.String, 0, true), // NAME
    ];
    private ITdfMember[] __members;

    private TdfString _folderName = new(__typeInfos[0]);

    public GetLeaderboardTreeRequest()
    {
        __members = [
            _folderName,
        ];
    }

    public override Tdf CreateNew() => new GetLeaderboardTreeRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetLeaderboardTreeRequest";
    public override string GetFullClassName() => "Blaze::Stats::GetLeaderboardTreeRequest";

    public string FolderName
    {
        get => _folderName.Value;
        set => _folderName.Value = value;
    }

}

