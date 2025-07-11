using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Locker;

public class Tag : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("mtag", "mtag", 0xD219C000, TdfType.String, 0, true), // TAG
        new TdfMemberInfo("TagId", "mTagId", 0xD27A6400, TdfType.Int32, 1, true), // TGID
    ];
    private ITdfMember[] __members;

    private TdfString _mtag = new(__typeInfos[0]);
    private TdfInt32 _tagId = new(__typeInfos[1]);

    public Tag()
    {
        __members = [
            _mtag,
            _tagId,
        ];
    }

    public override Tdf CreateNew() => new Tag();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "Tag";
    public override string GetFullClassName() => "Blaze::Locker::Tag";

    public string mtag
    {
        get => _mtag.Value;
        set => _mtag.Value = value;
    }

    public int TagId
    {
        get => _tagId.Value;
        set => _tagId.Value = value;
    }

}

