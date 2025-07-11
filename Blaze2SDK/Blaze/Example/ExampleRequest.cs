using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Example;

public class ExampleRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("NestedMap", "mNestedMap", 0xBAD87000, TdfType.Map, 0, true), // NMAP
        new TdfMemberInfo("Num", "mNum", 0xBB5B4000, TdfType.Int32, 1, true), // NUM
        new TdfMemberInfo("StringMap", "mStringMap", 0xCED87000, TdfType.Map, 2, true), // SMAP
        new TdfMemberInfo("Text", "mText", 0xD25E3400, TdfType.String, 3, true), // TEXT
    ];
    private ITdfMember[] __members;

    private TdfMap<string, Blaze2SDK.Blaze.Example.Nested> _nestedMap = new(__typeInfos[0]);
    private TdfInt32 _num = new(__typeInfos[1]);
    private TdfMap<string, string> _stringMap = new(__typeInfos[2]);
    private TdfString _text = new(__typeInfos[3]);

    public ExampleRequest()
    {
        __members = [
            _nestedMap,
            _num,
            _stringMap,
            _text,
        ];
    }

    public override Tdf CreateNew() => new ExampleRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ExampleRequest";
    public override string GetFullClassName() => "Blaze::Example::ExampleRequest";

    public IDictionary<string, Blaze2SDK.Blaze.Example.Nested> NestedMap
    {
        get => _nestedMap.Value;
        set => _nestedMap.Value = value;
    }

    public int Num
    {
        get => _num.Value;
        set => _num.Value = value;
    }

    public IDictionary<string, string> StringMap
    {
        get => _stringMap.Value;
        set => _stringMap.Value = value;
    }

    public string Text
    {
        get => _text.Value;
        set => _text.Value = value;
    }

}

