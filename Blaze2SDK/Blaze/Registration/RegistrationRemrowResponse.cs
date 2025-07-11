using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Registration;

public class RegistrationRemrowResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("IsDeleted", "mIsDeleted", 0x925AC000, TdfType.UInt8, 0, true), // DEK
    ];
    private ITdfMember[] __members;

    private TdfUInt8 _isDeleted = new(__typeInfos[0]);

    public RegistrationRemrowResponse()
    {
        __members = [
            _isDeleted,
        ];
    }

    public override Tdf CreateNew() => new RegistrationRemrowResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "RegistrationRemrowResponse";
    public override string GetFullClassName() => "Blaze::Registration::RegistrationRemrowResponse";

    public byte IsDeleted
    {
        get => _isDeleted.Value;
        set => _isDeleted.Value = value;
    }

}

