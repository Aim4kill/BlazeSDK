using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Example;

public class ExampleResponse : Tdf
{
    public enum ExampleResponseEnum : int
    {
        EXAMPLE_ENUM_UNKNOWN = 0,
        EXAMPLE_ENUM_SUCCESS = 1,
        EXAMPLE_ENUM_FAILED = 2,
    }
    
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("RegularEnum", "mRegularEnum", 0x96ED6D00, TdfType.Enum, 0, true), // ENUM
        new TdfMemberInfo("MyList", "mMyList", 0xB29CF400, TdfType.List, 1, true), // LIST
        new TdfMemberInfo("MyMap", "mMyMap", 0xB61C0000, TdfType.Map, 2, true), // MAP
        new TdfMemberInfo("Message", "mMessage", 0xB739C000, TdfType.String, 3, true), // MSG
    ];
    private ITdfMember[] __members;

    private TdfEnum<Blaze2SDK.Blaze.Example.ExampleResponse.ExampleResponseEnum> _regularEnum = new(__typeInfos[0]);
    private TdfList<int> _myList = new(__typeInfos[1]);
    private TdfMap<int, Blaze2SDK.Blaze.Example.ExampleRequest> _myMap = new(__typeInfos[2]);
    private TdfString _message = new(__typeInfos[3]);

    public ExampleResponse()
    {
        __members = [
            _regularEnum,
            _myList,
            _myMap,
            _message,
        ];
    }

    public override Tdf CreateNew() => new ExampleResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ExampleResponse";
    public override string GetFullClassName() => "Blaze::Example::ExampleResponse";

    public Blaze2SDK.Blaze.Example.ExampleResponse.ExampleResponseEnum RegularEnum
    {
        get => _regularEnum.Value;
        set => _regularEnum.Value = value;
    }

    public IList<int> MyList
    {
        get => _myList.Value;
        set => _myList.Value = value;
    }

    public IDictionary<int, Blaze2SDK.Blaze.Example.ExampleRequest> MyMap
    {
        get => _myMap.Value;
        set => _myMap.Value = value;
    }

    public string Message
    {
        get => _message.Value;
        set => _message.Value = value;
    }

}

