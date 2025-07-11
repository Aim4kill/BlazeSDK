using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Stats;

public class KeyScopedStatValues : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("GroupName", "mGroupName", 0x9F2BAD00, TdfType.String, 0, true), // GRNM
        new TdfMemberInfo("KeyString", "mKeyString", 0xAE5E4000, TdfType.String, 1, true), // KEY
        new TdfMemberInfo("Last", "mLast", 0xB21CF400, TdfType.Bool, 2, true), // LAST
        new TdfMemberInfo("StatValues", "mStatValues", 0xCF4CC000, TdfType.Struct, 3, true), // STS
        new TdfMemberInfo("ViewId", "mViewId", 0xDA990000, TdfType.UInt32, 4, true), // VID
    ];
    private ITdfMember[] __members;

    private TdfString _groupName = new(__typeInfos[0]);
    private TdfString _keyString = new(__typeInfos[1]);
    private TdfBool _last = new(__typeInfos[2]);
    private TdfStruct<Blaze2SDK.Blaze.Stats.StatValues?> _statValues = new(__typeInfos[3]);
    private TdfUInt32 _viewId = new(__typeInfos[4]);

    public KeyScopedStatValues()
    {
        __members = [
            _groupName,
            _keyString,
            _last,
            _statValues,
            _viewId,
        ];
    }

    public override Tdf CreateNew() => new KeyScopedStatValues();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "KeyScopedStatValues";
    public override string GetFullClassName() => "Blaze::Stats::KeyScopedStatValues";

    public string GroupName
    {
        get => _groupName.Value;
        set => _groupName.Value = value;
    }

    public string KeyString
    {
        get => _keyString.Value;
        set => _keyString.Value = value;
    }

    public bool Last
    {
        get => _last.Value;
        set => _last.Value = value;
    }

    public Blaze2SDK.Blaze.Stats.StatValues? StatValues
    {
        get => _statValues.Value;
        set => _statValues.Value = value;
    }

    public uint ViewId
    {
        get => _viewId.Value;
        set => _viewId.Value = value;
    }

}

