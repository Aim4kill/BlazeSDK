using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Util;

public class UserStringList : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("TextList", "mTextList", 0xD74E3400, TdfType.List, 0, true), // UTXT
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze3SDK.Blaze.Util.UserText> _textList = new(__typeInfos[0]);

    public UserStringList()
    {
        __members = [
            _textList,
        ];
    }

    public override Tdf CreateNew() => new UserStringList();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "UserStringList";
    public override string GetFullClassName() => "Blaze::Util::UserStringList";

    public IList<Blaze3SDK.Blaze.Util.UserText> TextList
    {
        get => _textList.Value;
        set => _textList.Value = value;
    }

}

