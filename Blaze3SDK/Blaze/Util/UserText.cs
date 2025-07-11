using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Util;

public class UserText : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Text", "mText", 0xD74E3400, TdfType.String, 0, true), // UTXT
    ];
    private ITdfMember[] __members;

    private TdfString _text = new(__typeInfos[0]);

    public UserText()
    {
        __members = [
            _text,
        ];
    }

    public override Tdf CreateNew() => new UserText();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "UserText";
    public override string GetFullClassName() => "Blaze::Util::UserText";

    public string Text
    {
        get => _text.Value;
        set => _text.Value = value;
    }

}

