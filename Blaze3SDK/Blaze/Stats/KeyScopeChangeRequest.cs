using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Stats;

public class KeyScopeChangeRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("EntityId", "mEntityId", 0x96990000, TdfType.Int64, 0, true), // EID
        new TdfMemberInfo("EntityType", "mEntityType", 0x974C0000, TdfType.ObjectType, 1, true), // ETP
        new TdfMemberInfo("KeyScopeName", "mKeyScopeName", 0xAF3BAD00, TdfType.String, 2, true), // KSNM
        new TdfMemberInfo("NewKeyScopeValue", "mNewKeyScopeValue", 0xAF3BB600, TdfType.Int64, 3, true), // KSNV
        new TdfMemberInfo("OldKeyScopeValue", "mOldKeyScopeValue", 0xAF3BF600, TdfType.Int64, 4, true), // KSOV
    ];
    private ITdfMember[] __members;

    private TdfInt64 _entityId = new(__typeInfos[0]);
    private TdfObjectType _entityType = new(__typeInfos[1]);
    private TdfString _keyScopeName = new(__typeInfos[2]);
    private TdfInt64 _newKeyScopeValue = new(__typeInfos[3]);
    private TdfInt64 _oldKeyScopeValue = new(__typeInfos[4]);

    public KeyScopeChangeRequest()
    {
        __members = [
            _entityId,
            _entityType,
            _keyScopeName,
            _newKeyScopeValue,
            _oldKeyScopeValue,
        ];
    }

    public override Tdf CreateNew() => new KeyScopeChangeRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "KeyScopeChangeRequest";
    public override string GetFullClassName() => "Blaze::Stats::KeyScopeChangeRequest";

    public long EntityId
    {
        get => _entityId.Value;
        set => _entityId.Value = value;
    }

    public ObjectType EntityType
    {
        get => _entityType.Value;
        set => _entityType.Value = value;
    }

    public string KeyScopeName
    {
        get => _keyScopeName.Value;
        set => _keyScopeName.Value = value;
    }

    public long NewKeyScopeValue
    {
        get => _newKeyScopeValue.Value;
        set => _newKeyScopeValue.Value = value;
    }

    public long OldKeyScopeValue
    {
        get => _oldKeyScopeValue.Value;
        set => _oldKeyScopeValue.Value = value;
    }

}

