using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Association;

public class ListInfo : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("BlazeObjId", "mBlazeObjId", 0x8AFA6400, TdfType.ObjectId, 0, true), // BOID
        new TdfMemberInfo("StatusFlags", "mStatusFlags", 0x9AC9F300, TdfType.Enum, 1, true), // FLGS
        new TdfMemberInfo("Id", "mId", 0xB2990000, TdfType.Struct, 2, true), // LID
        new TdfMemberInfo("MaxSize", "mMaxSize", 0xB2DCC000, TdfType.UInt32, 3, true), // LMS
        new TdfMemberInfo("PairId", "mPairId", 0xC32A6400, TdfType.UInt32, 4, true), // PRID
    ];
    private ITdfMember[] __members;

    private TdfObjectId _blazeObjId = new(__typeInfos[0]);
    private TdfEnum<Blaze3SDK.Blaze.Association.ListStatusFlags> _statusFlags = new(__typeInfos[1]);
    private TdfStruct<Blaze3SDK.Blaze.Association.ListIdentification?> _id = new(__typeInfos[2]);
    private TdfUInt32 _maxSize = new(__typeInfos[3]);
    private TdfUInt32 _pairId = new(__typeInfos[4]);

    public ListInfo()
    {
        __members = [
            _blazeObjId,
            _statusFlags,
            _id,
            _maxSize,
            _pairId,
        ];
    }

    public override Tdf CreateNew() => new ListInfo();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ListInfo";
    public override string GetFullClassName() => "Blaze::Association::ListInfo";

    public ObjectId BlazeObjId
    {
        get => _blazeObjId.Value;
        set => _blazeObjId.Value = value;
    }

    public Blaze3SDK.Blaze.Association.ListStatusFlags StatusFlags
    {
        get => _statusFlags.Value;
        set => _statusFlags.Value = value;
    }

    public Blaze3SDK.Blaze.Association.ListIdentification? Id
    {
        get => _id.Value;
        set => _id.Value = value;
    }

    public uint MaxSize
    {
        get => _maxSize.Value;
        set => _maxSize.Value = value;
    }

    public uint PairId
    {
        get => _pairId.Value;
        set => _pairId.Value = value;
    }

}

