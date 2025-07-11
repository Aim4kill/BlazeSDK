using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Authentication;

public class ListPersonasResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("List", "mList", 0xC29BA600, TdfType.List, 0, true), // PINF
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze3SDK.Blaze.Authentication.PersonaDetails> _list = new(__typeInfos[0]);

    public ListPersonasResponse()
    {
        __members = [
            _list,
        ];
    }

    public override Tdf CreateNew() => new ListPersonasResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ListPersonasResponse";
    public override string GetFullClassName() => "Blaze::Authentication::ListPersonasResponse";

    public IList<Blaze3SDK.Blaze.Authentication.PersonaDetails> List
    {
        get => _list.Value;
        set => _list.Value = value;
    }

}

