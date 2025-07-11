using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze;

public class EntitiesLookupByIdsResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("EntityNames", "mEntityNames", 0xBA1B6500, TdfType.List, 0, true), // NAME
    ];
    private ITdfMember[] __members;

    private TdfList<string> _entityNames = new(__typeInfos[0]);

    public EntitiesLookupByIdsResponse()
    {
        __members = [
            _entityNames,
        ];
    }

    public override Tdf CreateNew() => new EntitiesLookupByIdsResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "EntitiesLookupByIdsResponse";
    public override string GetFullClassName() => "Blaze::EntitiesLookupByIdsResponse";

    public IList<string> EntityNames
    {
        get => _entityNames.Value;
        set => _entityNames.Value = value;
    }

}

