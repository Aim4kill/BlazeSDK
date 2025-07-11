using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze;

public class EntitiesLookupByIdsRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("EntityIds", "mEntityIds", 0x96990000, TdfType.List, 0, true), // EID
        new TdfMemberInfo("BlazeObjectType", "mBlazeObjectType", 0xD39C2500, TdfType.ObjectType, 1, true), // TYPE
    ];
    private ITdfMember[] __members;

    private TdfList<long> _entityIds = new(__typeInfos[0]);
    private TdfObjectType _blazeObjectType = new(__typeInfos[1]);

    public EntitiesLookupByIdsRequest()
    {
        __members = [
            _entityIds,
            _blazeObjectType,
        ];
    }

    public override Tdf CreateNew() => new EntitiesLookupByIdsRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "EntitiesLookupByIdsRequest";
    public override string GetFullClassName() => "Blaze::EntitiesLookupByIdsRequest";

    public IList<long> EntityIds
    {
        get => _entityIds.Value;
        set => _entityIds.Value = value;
    }

    public ObjectType BlazeObjectType
    {
        get => _blazeObjectType.Value;
        set => _blazeObjectType.Value = value;
    }

}

