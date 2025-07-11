using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Authentication;

public class FieldValidationError : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Error", "mError", 0x972C8000, TdfType.Enum, 0, true), // ERR
        new TdfMemberInfo("Field", "mField", 0x9AC90000, TdfType.Enum, 1, true), // FLD
    ];
    private ITdfMember[] __members;

    private TdfEnum<Blaze2SDK.Blaze.Authentication.NucleusCause> _error = new(__typeInfos[0]);
    private TdfEnum<Blaze2SDK.Blaze.Authentication.NucleusField> _field = new(__typeInfos[1]);

    public FieldValidationError()
    {
        __members = [
            _error,
            _field,
        ];
    }

    public override Tdf CreateNew() => new FieldValidationError();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "FieldValidationError";
    public override string GetFullClassName() => "Blaze::Authentication::FieldValidationError";

    public Blaze2SDK.Blaze.Authentication.NucleusCause Error
    {
        get => _error.Value;
        set => _error.Value = value;
    }

    public Blaze2SDK.Blaze.Authentication.NucleusField Field
    {
        get => _field.Value;
        set => _field.Value = value;
    }

}

