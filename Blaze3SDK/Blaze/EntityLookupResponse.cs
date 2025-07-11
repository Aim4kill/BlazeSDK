using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze;

public class EntityLookupResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("BlazeObjectId", "mBlazeObjectId", 0xBE990000, TdfType.ObjectId, 0, true), // OID
    ];
    private ITdfMember[] __members;

    private TdfObjectId _blazeObjectId = new(__typeInfos[0]);

    public EntityLookupResponse()
    {
        __members = [
            _blazeObjectId,
        ];
    }

    public override Tdf CreateNew() => new EntityLookupResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "EntityLookupResponse";
    public override string GetFullClassName() => "Blaze::EntityLookupResponse";

    public ObjectId BlazeObjectId
    {
        get => _blazeObjectId.Value;
        set => _blazeObjectId.Value = value;
    }

}

