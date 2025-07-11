using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Rooms;

public class BannedUserList : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("BannedList", "mBannedList", 0x8ACCF400, TdfType.List, 0, true), // BLST
    ];
    private ITdfMember[] __members;

    private TdfList<long> _bannedList = new(__typeInfos[0]);

    public BannedUserList()
    {
        __members = [
            _bannedList,
        ];
    }

    public override Tdf CreateNew() => new BannedUserList();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "BannedUserList";
    public override string GetFullClassName() => "Blaze::Rooms::BannedUserList";

    public IList<long> BannedList
    {
        get => _bannedList.Value;
        set => _bannedList.Value = value;
    }

}

