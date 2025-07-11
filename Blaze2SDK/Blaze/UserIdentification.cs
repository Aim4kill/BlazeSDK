using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze;

public class UserIdentification : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("AccountId", "mAccountId", 0x86990000, TdfType.Int64, 0, true), // AID
        new TdfMemberInfo("AccountLocale", "mAccountLocale", 0x86CBE300, TdfType.UInt32, 1, true), // ALOC
        new TdfMemberInfo("ExternalBlob", "mExternalBlob", 0x9788A200, TdfType.Blob, 2, true), // EXBB
        new TdfMemberInfo("ExternalId", "mExternalId", 0x978A6400, TdfType.UInt64, 3, true), // EXID
        new TdfMemberInfo("BlazeId", "mBlazeId", 0xA6400000, TdfType.UInt32, 4, true), // ID
        new TdfMemberInfo("Name", "mName", 0xBA1B6500, TdfType.String, 5, true), // NAME
        new TdfMemberInfo("IsOnline", "mIsOnline", 0xBEEB2E00, TdfType.Bool, 6, true), // ONLN
        new TdfMemberInfo("PersonaId", "mPersonaId", 0xC2990000, TdfType.String, 7, true), // PID
    ];
    private ITdfMember[] __members;

    private TdfInt64 _accountId = new(__typeInfos[0]);
    private TdfUInt32 _accountLocale = new(__typeInfos[1]);
    private TdfBlob _externalBlob = new(__typeInfos[2]);
    private TdfUInt64 _externalId = new(__typeInfos[3]);
    private TdfUInt32 _blazeId = new(__typeInfos[4]);
    private TdfString _name = new(__typeInfos[5]);
    private TdfBool _isOnline = new(__typeInfos[6]);
    private TdfString _personaId = new(__typeInfos[7]);

    public UserIdentification()
    {
        __members = [
            _accountId,
            _accountLocale,
            _externalBlob,
            _externalId,
            _blazeId,
            _name,
            _isOnline,
            _personaId,
        ];
    }

    public override Tdf CreateNew() => new UserIdentification();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "UserIdentification";
    public override string GetFullClassName() => "Blaze::UserIdentification";

    public long AccountId
    {
        get => _accountId.Value;
        set => _accountId.Value = value;
    }

    public uint AccountLocale
    {
        get => _accountLocale.Value;
        set => _accountLocale.Value = value;
    }

    public byte[] ExternalBlob
    {
        get => _externalBlob.Value;
        set => _externalBlob.Value = value;
    }

    public ulong ExternalId
    {
        get => _externalId.Value;
        set => _externalId.Value = value;
    }

    public uint BlazeId
    {
        get => _blazeId.Value;
        set => _blazeId.Value = value;
    }

    public string Name
    {
        get => _name.Value;
        set => _name.Value = value;
    }

    public bool IsOnline
    {
        get => _isOnline.Value;
        set => _isOnline.Value = value;
    }

    public string PersonaId
    {
        get => _personaId.Value;
        set => _personaId.Value = value;
    }

}

