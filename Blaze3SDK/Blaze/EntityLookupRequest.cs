using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze;

public class EntityLookupRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("EntityName", "mEntityName", 0xBA1B6500, TdfType.String, 0, true), // NAME
        new TdfMemberInfo("EntityTypeName", "mEntityTypeName", 0xD39C2500, TdfType.String, 1, true), // TYPE
    ];
    private ITdfMember[] __members;

    private TdfString _entityName = new(__typeInfos[0]);
    private TdfString _entityTypeName = new(__typeInfos[1]);

    public EntityLookupRequest()
    {
        __members = [
            _entityName,
            _entityTypeName,
        ];
    }

    public override Tdf CreateNew() => new EntityLookupRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "EntityLookupRequest";
    public override string GetFullClassName() => "Blaze::EntityLookupRequest";

    public string EntityName
    {
        get => _entityName.Value;
        set => _entityName.Value = value;
    }

    public string EntityTypeName
    {
        get => _entityTypeName.Value;
        set => _entityTypeName.Value = value;
    }

}

