using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Registration;

public class RegistrationCheckResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("IsBanned", "mIsBanned", 0x8A1B8000, TdfType.UInt8, 0, true), // BAN
    ];
    private ITdfMember[] __members;

    private TdfUInt8 _isBanned = new(__typeInfos[0]);

    public RegistrationCheckResponse()
    {
        __members = [
            _isBanned,
        ];
    }

    public override Tdf CreateNew() => new RegistrationCheckResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "RegistrationCheckResponse";
    public override string GetFullClassName() => "Blaze::Registration::RegistrationCheckResponse";

    public byte IsBanned
    {
        get => _isBanned.Value;
        set => _isBanned.Value = value;
    }

}

