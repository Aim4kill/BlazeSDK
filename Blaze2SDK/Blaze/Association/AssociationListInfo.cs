using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Association;

public class AssociationListInfo : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ListMemberInfoVector", "mListMemberInfoVector", 0x86CB6C00, TdfType.List, 0, true), // ALML
        new TdfMemberInfo("BlazeObjId", "mBlazeObjId", 0x8AFA6400, TdfType.UInt64, 1, true), // BOID
        new TdfMemberInfo("Id", "mId", 0xB2990000, TdfType.UInt32, 2, true), // LID
        new TdfMemberInfo("MaxSize", "mMaxSize", 0xB2DCC000, TdfType.UInt32, 3, true), // LMS
        new TdfMemberInfo("Name", "mName", 0xB2EB4000, TdfType.String, 4, true), // LNM
        new TdfMemberInfo("Rollover", "mRollover", 0xCA6B2700, TdfType.Bool, 5, true), // RFLG
        new TdfMemberInfo("Subscprition", "mSubscprition", 0xCE6B2700, TdfType.Bool, 6, true), // SFLG
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze2SDK.Blaze.Association.ListMemberInfo> _listMemberInfoVector = new(__typeInfos[0]);
    private TdfUInt64 _blazeObjId = new(__typeInfos[1]);
    private TdfUInt32 _id = new(__typeInfos[2]);
    private TdfUInt32 _maxSize = new(__typeInfos[3]);
    private TdfString _name = new(__typeInfos[4]);
    private TdfBool _rollover = new(__typeInfos[5]);
    private TdfBool _subscprition = new(__typeInfos[6]);

    public AssociationListInfo()
    {
        __members = [
            _listMemberInfoVector,
            _blazeObjId,
            _id,
            _maxSize,
            _name,
            _rollover,
            _subscprition,
        ];
    }

    public override Tdf CreateNew() => new AssociationListInfo();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "AssociationListInfo";
    public override string GetFullClassName() => "Blaze::Association::AssociationListInfo";

    public IList<Blaze2SDK.Blaze.Association.ListMemberInfo> ListMemberInfoVector
    {
        get => _listMemberInfoVector.Value;
        set => _listMemberInfoVector.Value = value;
    }

    public ulong BlazeObjId
    {
        get => _blazeObjId.Value;
        set => _blazeObjId.Value = value;
    }

    public uint Id
    {
        get => _id.Value;
        set => _id.Value = value;
    }

    public uint MaxSize
    {
        get => _maxSize.Value;
        set => _maxSize.Value = value;
    }

    public string Name
    {
        get => _name.Value;
        set => _name.Value = value;
    }

    public bool Rollover
    {
        get => _rollover.Value;
        set => _rollover.Value = value;
    }

    public bool Subscprition
    {
        get => _subscprition.Value;
        set => _subscprition.Value = value;
    }

}

