using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Association;

public class ListData : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Id", "mId", 0xA6400000, TdfType.UInt32, 0, true), // ID
        new TdfMemberInfo("MutualAction", "mMutualAction", 0xB75D2100, TdfType.Bool, 1, true), // MUTA
        new TdfMemberInfo("Name", "mName", 0xBA1B6500, TdfType.String, 2, true), // NAME
        new TdfMemberInfo("LoadOfflineUED", "mLoadOfflineUED", 0xBE69AC00, TdfType.Bool, 3, true), // OFFL
        new TdfMemberInfo("PairId", "mPairId", 0xC32A6400, TdfType.UInt32, 4, true), // PRID
        new TdfMemberInfo("Rollover", "mRollover", 0xCAFB2C00, TdfType.Bool, 5, true), // ROLL
        new TdfMemberInfo("Subscribe", "mSubscribe", 0xCE3CA900, TdfType.Bool, 6, true), // SCRI
        new TdfMemberInfo("MaxSize", "mMaxSize", 0xCE9EA500, TdfType.UInt32, 7, true), // SIZE
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _id = new(__typeInfos[0]);
    private TdfBool _mutualAction = new(__typeInfos[1]);
    private TdfString _name = new(__typeInfos[2]);
    private TdfBool _loadOfflineUED = new(__typeInfos[3]);
    private TdfUInt32 _pairId = new(__typeInfos[4]);
    private TdfBool _rollover = new(__typeInfos[5]);
    private TdfBool _subscribe = new(__typeInfos[6]);
    private TdfUInt32 _maxSize = new(__typeInfos[7]);

    public ListData()
    {
        __members = [
            _id,
            _mutualAction,
            _name,
            _loadOfflineUED,
            _pairId,
            _rollover,
            _subscribe,
            _maxSize,
        ];
    }

    public override Tdf CreateNew() => new ListData();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ListData";
    public override string GetFullClassName() => "Blaze::Association::ListData";

    public uint Id
    {
        get => _id.Value;
        set => _id.Value = value;
    }

    public bool MutualAction
    {
        get => _mutualAction.Value;
        set => _mutualAction.Value = value;
    }

    public string Name
    {
        get => _name.Value;
        set => _name.Value = value;
    }

    public bool LoadOfflineUED
    {
        get => _loadOfflineUED.Value;
        set => _loadOfflineUED.Value = value;
    }

    public uint PairId
    {
        get => _pairId.Value;
        set => _pairId.Value = value;
    }

    public bool Rollover
    {
        get => _rollover.Value;
        set => _rollover.Value = value;
    }

    public bool Subscribe
    {
        get => _subscribe.Value;
        set => _subscribe.Value = value;
    }

    public uint MaxSize
    {
        get => _maxSize.Value;
        set => _maxSize.Value = value;
    }

}

