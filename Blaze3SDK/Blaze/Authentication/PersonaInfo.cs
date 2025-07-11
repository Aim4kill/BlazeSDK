using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Authentication;

public class PersonaInfo : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("DisplayName", "mDisplayName", 0x933BAD00, TdfType.String, 0, true), // DSNM
        new TdfMemberInfo("DateCreated", "mDateCreated", 0x9348F200, TdfType.String, 1, true), // DTCR
        new TdfMemberInfo("LastAuthenticated", "mLastAuthenticated", 0xB2193400, TdfType.UInt32, 2, true), // LADT
        new TdfMemberInfo("NameSpaceName", "mNameSpaceName", 0xBB3BAD00, TdfType.String, 3, true), // NSNM
        new TdfMemberInfo("PersonaId", "mPersonaId", 0xC2990000, TdfType.Int64, 4, true), // PID
        new TdfMemberInfo("Status", "mStatus", 0xCF487300, TdfType.Enum, 5, true), // STAS
        new TdfMemberInfo("StatusReasonCode", "mStatusReasonCode", 0xCF4CA300, TdfType.Enum, 6, true), // STRC
    ];
    private ITdfMember[] __members;

    private TdfString _displayName = new(__typeInfos[0]);
    private TdfString _dateCreated = new(__typeInfos[1]);
    private TdfUInt32 _lastAuthenticated = new(__typeInfos[2]);
    private TdfString _nameSpaceName = new(__typeInfos[3]);
    private TdfInt64 _personaId = new(__typeInfos[4]);
    private TdfEnum<Blaze3SDK.Blaze.Authentication.PersonaStatus> _status = new(__typeInfos[5]);
    private TdfEnum<Blaze3SDK.Blaze.Authentication.StatusReason> _statusReasonCode = new(__typeInfos[6]);

    public PersonaInfo()
    {
        __members = [
            _displayName,
            _dateCreated,
            _lastAuthenticated,
            _nameSpaceName,
            _personaId,
            _status,
            _statusReasonCode,
        ];
    }

    public override Tdf CreateNew() => new PersonaInfo();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "PersonaInfo";
    public override string GetFullClassName() => "Blaze::Authentication::PersonaInfo";

    public string DisplayName
    {
        get => _displayName.Value;
        set => _displayName.Value = value;
    }

    public string DateCreated
    {
        get => _dateCreated.Value;
        set => _dateCreated.Value = value;
    }

    public uint LastAuthenticated
    {
        get => _lastAuthenticated.Value;
        set => _lastAuthenticated.Value = value;
    }

    public string NameSpaceName
    {
        get => _nameSpaceName.Value;
        set => _nameSpaceName.Value = value;
    }

    public long PersonaId
    {
        get => _personaId.Value;
        set => _personaId.Value = value;
    }

    public Blaze3SDK.Blaze.Authentication.PersonaStatus Status
    {
        get => _status.Value;
        set => _status.Value = value;
    }

    public Blaze3SDK.Blaze.Authentication.StatusReason StatusReasonCode
    {
        get => _statusReasonCode.Value;
        set => _statusReasonCode.Value = value;
    }

}

