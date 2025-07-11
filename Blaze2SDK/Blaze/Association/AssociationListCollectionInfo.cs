using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Association;

public class AssociationListCollectionInfo : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("AssociationListInfoByNameMap", "mAssociationListInfoByNameMap", 0x86CB7000, TdfType.Map, 0, true), // ALMP
    ];
    private ITdfMember[] __members;

    private TdfMap<string, Blaze2SDK.Blaze.Association.AssociationListInfo> _associationListInfoByNameMap = new(__typeInfos[0]);

    public AssociationListCollectionInfo()
    {
        __members = [
            _associationListInfoByNameMap,
        ];
    }

    public override Tdf CreateNew() => new AssociationListCollectionInfo();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "AssociationListCollectionInfo";
    public override string GetFullClassName() => "Blaze::Association::AssociationListCollectionInfo";

    public IDictionary<string, Blaze2SDK.Blaze.Association.AssociationListInfo> AssociationListInfoByNameMap
    {
        get => _associationListInfoByNameMap.Value;
        set => _associationListInfoByNameMap.Value = value;
    }

}

