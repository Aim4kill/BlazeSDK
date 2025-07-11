using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Association;

public class ListMemberId : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("BlazeId", "mBlazeId", 0x8ACA6400, TdfType.Int64, 0, true), // BLID
        new TdfMemberInfo("PersonaName", "mPersonaName", 0xC2E86D00, TdfType.String, 1, true), // PNAM
        new TdfMemberInfo("ExternalId", "mExternalId", 0xE3296600, TdfType.UInt64, 2, true), // XREF
        new TdfMemberInfo("ExternalSystemId", "mExternalSystemId", 0xE34E7000, TdfType.Enum, 3, true), // XTYP
    ];
    private ITdfMember[] __members;

    private TdfInt64 _blazeId = new(__typeInfos[0]);
    private TdfString _personaName = new(__typeInfos[1]);
    private TdfUInt64 _externalId = new(__typeInfos[2]);
    private TdfEnum<Blaze3SDK.Blaze.ExternalSystemId> _externalSystemId = new(__typeInfos[3]);

    public ListMemberId()
    {
        __members = [
            _blazeId,
            _personaName,
            _externalId,
            _externalSystemId,
        ];
    }

    public override Tdf CreateNew() => new ListMemberId();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ListMemberId";
    public override string GetFullClassName() => "Blaze::Association::ListMemberId";

    public long BlazeId
    {
        get => _blazeId.Value;
        set => _blazeId.Value = value;
    }

    public string PersonaName
    {
        get => _personaName.Value;
        set => _personaName.Value = value;
    }

    public ulong ExternalId
    {
        get => _externalId.Value;
        set => _externalId.Value = value;
    }

    public Blaze3SDK.Blaze.ExternalSystemId ExternalSystemId
    {
        get => _externalSystemId.Value;
        set => _externalSystemId.Value = value;
    }

}

