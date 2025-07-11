using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze;

public class EntityLookupByIdRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("EntityId", "mEntityId", 0x96990000, TdfType.Int64, 0, true), // EID
        new TdfMemberInfo("BlazeObjectType", "mBlazeObjectType", 0xD39C2500, TdfType.ObjectType, 1, true), // TYPE
    ];
    private ITdfMember[] __members;

    private TdfInt64 _entityId = new(__typeInfos[0]);
    private TdfObjectType _blazeObjectType = new(__typeInfos[1]);

    public EntityLookupByIdRequest()
    {
        __members = [
            _entityId,
            _blazeObjectType,
        ];
    }

    public override Tdf CreateNew() => new EntityLookupByIdRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "EntityLookupByIdRequest";
    public override string GetFullClassName() => "Blaze::EntityLookupByIdRequest";

    public long EntityId
    {
        get => _entityId.Value;
        set => _entityId.Value = value;
    }

    public ObjectType BlazeObjectType
    {
        get => _blazeObjectType.Value;
        set => _blazeObjectType.Value = value;
    }

}

