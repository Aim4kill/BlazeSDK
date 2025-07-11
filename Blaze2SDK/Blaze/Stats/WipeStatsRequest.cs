using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Stats;

public class WipeStatsRequest : Tdf
{
    public enum WipeStatsOperation : int
    {
        DELETE_BY_CATEGORY_CONTEXT = 1,
        DELETE_BY_CATEGORY_CONTEXT_ENTITYID = 2,
        DELETE_BY_CONTEXT = 3,
        DELETE_BY_CONTEXT_ENTITYID = 4,
        DELETE_BY_ENTITYID = 5,
    }
    
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("CategoryName", "mCategoryName", 0x8E1D0000, TdfType.String, 0, true), // CAT
        new TdfMemberInfo("ContextId", "mContextId", 0x8E990000, TdfType.UInt32, 1, true), // CID
        new TdfMemberInfo("ContextType", "mContextType", 0x8F4E7000, TdfType.UInt32, 2, true), // CTYP
        new TdfMemberInfo("EntityId", "mEntityId", 0x96990000, TdfType.UInt32, 3, true), // EID
        new TdfMemberInfo("EntityType", "mEntityType", 0x974E7000, TdfType.UInt32, 4, true), // ETYP
        new TdfMemberInfo("Operation", "mOperation", 0xBF097200, TdfType.Enum, 5, true), // OPER
    ];
    private ITdfMember[] __members;

    private TdfString _categoryName = new(__typeInfos[0]);
    private TdfUInt32 _contextId = new(__typeInfos[1]);
    private TdfUInt32 _contextType = new(__typeInfos[2]);
    private TdfUInt32 _entityId = new(__typeInfos[3]);
    private TdfUInt32 _entityType = new(__typeInfos[4]);
    private TdfEnum<Blaze2SDK.Blaze.Stats.WipeStatsRequest.WipeStatsOperation> _operation = new(__typeInfos[5]);

    public WipeStatsRequest()
    {
        __members = [
            _categoryName,
            _contextId,
            _contextType,
            _entityId,
            _entityType,
            _operation,
        ];
    }

    public override Tdf CreateNew() => new WipeStatsRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "WipeStatsRequest";
    public override string GetFullClassName() => "Blaze::Stats::WipeStatsRequest";

    public string CategoryName
    {
        get => _categoryName.Value;
        set => _categoryName.Value = value;
    }

    public uint ContextId
    {
        get => _contextId.Value;
        set => _contextId.Value = value;
    }

    public uint ContextType
    {
        get => _contextType.Value;
        set => _contextType.Value = value;
    }

    public uint EntityId
    {
        get => _entityId.Value;
        set => _entityId.Value = value;
    }

    public uint EntityType
    {
        get => _entityType.Value;
        set => _entityType.Value = value;
    }

    public Blaze2SDK.Blaze.Stats.WipeStatsRequest.WipeStatsOperation Operation
    {
        get => _operation.Value;
        set => _operation.Value = value;
    }

}

