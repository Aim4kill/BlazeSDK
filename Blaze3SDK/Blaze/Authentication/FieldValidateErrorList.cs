using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Authentication;

public class FieldValidateErrorList : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("List", "mList", 0xB29CF400, TdfType.List, 0, true), // LIST
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze3SDK.Blaze.Authentication.FieldValidationError> _list = new(__typeInfos[0]);

    public FieldValidateErrorList()
    {
        __members = [
            _list,
        ];
    }

    public override Tdf CreateNew() => new FieldValidateErrorList();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "FieldValidateErrorList";
    public override string GetFullClassName() => "Blaze::Authentication::FieldValidateErrorList";

    public IList<Blaze3SDK.Blaze.Authentication.FieldValidationError> List
    {
        get => _list.Value;
        set => _list.Value = value;
    }

}

