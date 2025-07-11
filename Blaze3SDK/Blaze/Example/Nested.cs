using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Example;

public class Nested : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("StringMap", "mStringMap", 0xBADC2100, TdfType.Map, 0, true), // NMPA
        new TdfMemberInfo("Num", "mNum", 0xBB5B4000, TdfType.Int32, 1, true), // NUM
        new TdfMemberInfo("Text", "mText", 0xD25E3400, TdfType.String, 2, true), // TEXT
    ];
    private ITdfMember[] __members;

    private TdfMap<string, string> _stringMap = new(__typeInfos[0]);
    private TdfInt32 _num = new(__typeInfos[1]);
    private TdfString _text = new(__typeInfos[2]);

    public Nested()
    {
        __members = [
            _stringMap,
            _num,
            _text,
        ];
    }

    public override Tdf CreateNew() => new Nested();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "Nested";
    public override string GetFullClassName() => "Blaze::Example::Nested";

    public IDictionary<string, string> StringMap
    {
        get => _stringMap.Value;
        set => _stringMap.Value = value;
    }

    public int Num
    {
        get => _num.Value;
        set => _num.Value = value;
    }

    public string Text
    {
        get => _text.Value;
        set => _text.Value = value;
    }

}

