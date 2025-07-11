using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Example;

public class ExampleError : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Message", "mMessage", 0xB739C000, TdfType.String, 0, true), // MSG
    ];
    private ITdfMember[] __members;

    private TdfString _message = new(__typeInfos[0]);

    public ExampleError()
    {
        __members = [
            _message,
        ];
    }

    public override Tdf CreateNew() => new ExampleError();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ExampleError";
    public override string GetFullClassName() => "Blaze::Example::ExampleError";

    public string Message
    {
        get => _message.Value;
        set => _message.Value = value;
    }

}

