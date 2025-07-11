using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze;

public class EntityLookupByIdResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("EntityName", "mEntityName", 0xBA1B6500, TdfType.String, 0, true), // NAME
    ];
    private ITdfMember[] __members;

    private TdfString _entityName = new(__typeInfos[0]);

    public EntityLookupByIdResponse()
    {
        __members = [
            _entityName,
        ];
    }

    public override Tdf CreateNew() => new EntityLookupByIdResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "EntityLookupByIdResponse";
    public override string GetFullClassName() => "Blaze::EntityLookupByIdResponse";

    public string EntityName
    {
        get => _entityName.Value;
        set => _entityName.Value = value;
    }

}

