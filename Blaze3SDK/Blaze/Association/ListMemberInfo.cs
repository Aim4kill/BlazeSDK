using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Association;

public class ListMemberInfo : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ListMemberId", "mListMemberId", 0xB2DA6400, TdfType.Struct, 0, true), // LMID
        new TdfMemberInfo("TimeAdded", "mTimeAdded", 0xD29B6500, TdfType.Int64, 1, true), // TIME
    ];
    private ITdfMember[] __members;

    private TdfStruct<Blaze3SDK.Blaze.Association.ListMemberId?> _listMemberId = new(__typeInfos[0]);
    private TdfInt64 _timeAdded = new(__typeInfos[1]);

    public ListMemberInfo()
    {
        __members = [
            _listMemberId,
            _timeAdded,
        ];
    }

    public override Tdf CreateNew() => new ListMemberInfo();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ListMemberInfo";
    public override string GetFullClassName() => "Blaze::Association::ListMemberInfo";

    public Blaze3SDK.Blaze.Association.ListMemberId? ListMemberId
    {
        get => _listMemberId.Value;
        set => _listMemberId.Value = value;
    }

    public long TimeAdded
    {
        get => _timeAdded.Value;
        set => _timeAdded.Value = value;
    }

}

