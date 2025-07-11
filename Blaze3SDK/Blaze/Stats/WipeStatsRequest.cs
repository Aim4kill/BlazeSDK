using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Stats;

public class WipeStatsRequest : Tdf
{
    public enum WipeStatsOperation : int
    {
        DELETE_BY_CATEGORY_KEYSCOPE_USERSET = 1,
        DELETE_BY_CATEGORY_KEYSCOPE_ENTITYID = 2,
        DELETE_BY_KEYSCOPE_USERSET = 3,
        DELETE_BY_KEYSCOPE_ENTITYID = 4,
        DELETE_BY_ENTITYID = 5,
        DELETE_BY_CATEGORY = 6,
    }
    
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("CategoryName", "mCategoryName", 0x8E1D0000, TdfType.String, 0, true), // CAT
        new TdfMemberInfo("EntityId", "mEntityId", 0x96990000, TdfType.Int64, 1, true), // EID
        new TdfMemberInfo("EntityObjectId", "mEntityObjectId", 0x974E7000, TdfType.ObjectId, 2, true), // ETYP
        new TdfMemberInfo("KeyScopeNameValueMap", "mKeyScopeNameValueMap", 0xAF3D6D00, TdfType.Map, 3, true), // KSUM
        new TdfMemberInfo("Operation", "mOperation", 0xBF097200, TdfType.Enum, 4, true), // OPER
    ];
    private ITdfMember[] __members;

    private TdfString _categoryName = new(__typeInfos[0]);
    private TdfInt64 _entityId = new(__typeInfos[1]);
    private TdfObjectId _entityObjectId = new(__typeInfos[2]);
    private TdfMap<string, long> _keyScopeNameValueMap = new(__typeInfos[3]);
    private TdfEnum<Blaze3SDK.Blaze.Stats.WipeStatsRequest.WipeStatsOperation> _operation = new(__typeInfos[4]);

    public WipeStatsRequest()
    {
        __members = [
            _categoryName,
            _entityId,
            _entityObjectId,
            _keyScopeNameValueMap,
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

    public long EntityId
    {
        get => _entityId.Value;
        set => _entityId.Value = value;
    }

    public ObjectId EntityObjectId
    {
        get => _entityObjectId.Value;
        set => _entityObjectId.Value = value;
    }

    public IDictionary<string, long> KeyScopeNameValueMap
    {
        get => _keyScopeNameValueMap.Value;
        set => _keyScopeNameValueMap.Value = value;
    }

    public Blaze3SDK.Blaze.Stats.WipeStatsRequest.WipeStatsOperation Operation
    {
        get => _operation.Value;
        set => _operation.Value = value;
    }

}

