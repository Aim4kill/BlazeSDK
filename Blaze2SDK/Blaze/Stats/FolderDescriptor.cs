using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Stats;

public class FolderDescriptor : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Description", "mDescription", 0x9AC93300, TdfType.String, 0, true), // FLDS
        new TdfMemberInfo("FolderId", "mFolderId", 0x9ACA6400, TdfType.UInt32, 1, true), // FLID
        new TdfMemberInfo("Name", "mName", 0x9ACBAD00, TdfType.String, 2, true), // FLNM
        new TdfMemberInfo("ShortDesc", "mShortDesc", 0xCE497300, TdfType.String, 3, true), // SDES
    ];
    private ITdfMember[] __members;

    private TdfString _description = new(__typeInfos[0]);
    private TdfUInt32 _folderId = new(__typeInfos[1]);
    private TdfString _name = new(__typeInfos[2]);
    private TdfString _shortDesc = new(__typeInfos[3]);

    public FolderDescriptor()
    {
        __members = [
            _description,
            _folderId,
            _name,
            _shortDesc,
        ];
    }

    public override Tdf CreateNew() => new FolderDescriptor();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "FolderDescriptor";
    public override string GetFullClassName() => "Blaze::Stats::FolderDescriptor";

    public string Description
    {
        get => _description.Value;
        set => _description.Value = value;
    }

    public uint FolderId
    {
        get => _folderId.Value;
        set => _folderId.Value = value;
    }

    public string Name
    {
        get => _name.Value;
        set => _name.Value = value;
    }

    public string ShortDesc
    {
        get => _shortDesc.Value;
        set => _shortDesc.Value = value;
    }

}

