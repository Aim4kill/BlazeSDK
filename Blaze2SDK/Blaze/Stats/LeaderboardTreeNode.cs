using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Stats;

public class LeaderboardTreeNode : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Next2Last", "mNext2Last", 0x8E892500, TdfType.UInt32, 0, true), // CHDE
        new TdfMemberInfo("FirstChild", "mFirstChild", 0x8E893300, TdfType.UInt32, 1, true), // CHDS
        new TdfMemberInfo("LastNode", "mLastNode", 0xB21CF400, TdfType.Bool, 2, true), // LAST
        new TdfMemberInfo("NodeName", "mNodeName", 0xBA1B6500, TdfType.String, 3, true), // NAME
        new TdfMemberInfo("NodeId", "mNodeId", 0xBA4A6400, TdfType.UInt32, 4, true), // NDID
        new TdfMemberInfo("RootName", "mRootName", 0xCB4BAD00, TdfType.String, 5, true), // RTNM
        new TdfMemberInfo("ShortDesc", "mShortDesc", 0xCE497300, TdfType.String, 6, true), // SDES
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _next2Last = new(__typeInfos[0]);
    private TdfUInt32 _firstChild = new(__typeInfos[1]);
    private TdfBool _lastNode = new(__typeInfos[2]);
    private TdfString _nodeName = new(__typeInfos[3]);
    private TdfUInt32 _nodeId = new(__typeInfos[4]);
    private TdfString _rootName = new(__typeInfos[5]);
    private TdfString _shortDesc = new(__typeInfos[6]);

    public LeaderboardTreeNode()
    {
        __members = [
            _next2Last,
            _firstChild,
            _lastNode,
            _nodeName,
            _nodeId,
            _rootName,
            _shortDesc,
        ];
    }

    public override Tdf CreateNew() => new LeaderboardTreeNode();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "LeaderboardTreeNode";
    public override string GetFullClassName() => "Blaze::Stats::LeaderboardTreeNode";

    public uint Next2Last
    {
        get => _next2Last.Value;
        set => _next2Last.Value = value;
    }

    public uint FirstChild
    {
        get => _firstChild.Value;
        set => _firstChild.Value = value;
    }

    public bool LastNode
    {
        get => _lastNode.Value;
        set => _lastNode.Value = value;
    }

    public string NodeName
    {
        get => _nodeName.Value;
        set => _nodeName.Value = value;
    }

    public uint NodeId
    {
        get => _nodeId.Value;
        set => _nodeId.Value = value;
    }

    public string RootName
    {
        get => _rootName.Value;
        set => _rootName.Value = value;
    }

    public string ShortDesc
    {
        get => _shortDesc.Value;
        set => _shortDesc.Value = value;
    }

}

