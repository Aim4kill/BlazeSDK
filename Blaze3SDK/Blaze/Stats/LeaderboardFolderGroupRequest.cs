using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Stats;

public class LeaderboardFolderGroupRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("FolderId", "mFolderId", 0x9ACA6400, TdfType.UInt32, 0, true), // FLID
        new TdfMemberInfo("FolderName", "mFolderName", 0xBA1B6500, TdfType.String, 1, true), // NAME
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _folderId = new(__typeInfos[0]);
    private TdfString _folderName = new(__typeInfos[1]);

    public LeaderboardFolderGroupRequest()
    {
        __members = [
            _folderId,
            _folderName,
        ];
    }

    public override Tdf CreateNew() => new LeaderboardFolderGroupRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "LeaderboardFolderGroupRequest";
    public override string GetFullClassName() => "Blaze::Stats::LeaderboardFolderGroupRequest";

    public uint FolderId
    {
        get => _folderId.Value;
        set => _folderId.Value = value;
    }

    public string FolderName
    {
        get => _folderName.Value;
        set => _folderName.Value = value;
    }

}

