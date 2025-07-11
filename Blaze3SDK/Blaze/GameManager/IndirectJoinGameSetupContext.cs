using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameManager;

public class IndirectJoinGameSetupContext : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("UserGroupId", "mUserGroupId", 0x9F2A6400, TdfType.ObjectId, 0, true), // GRID
        new TdfMemberInfo("RequiresClientVersionCheck", "mRequiresClientVersionCheck", 0xCB0DA300, TdfType.Bool, 1, true), // RPVC
    ];
    private ITdfMember[] __members;

    private TdfObjectId _userGroupId = new(__typeInfos[0]);
    private TdfBool _requiresClientVersionCheck = new(__typeInfos[1]);

    public IndirectJoinGameSetupContext()
    {
        __members = [
            _userGroupId,
            _requiresClientVersionCheck,
        ];
    }

    public override Tdf CreateNew() => new IndirectJoinGameSetupContext();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "IndirectJoinGameSetupContext";
    public override string GetFullClassName() => "Blaze::GameManager::IndirectJoinGameSetupContext";

    public ObjectId UserGroupId
    {
        get => _userGroupId.Value;
        set => _userGroupId.Value = value;
    }

    public bool RequiresClientVersionCheck
    {
        get => _requiresClientVersionCheck.Value;
        set => _requiresClientVersionCheck.Value = value;
    }

}

