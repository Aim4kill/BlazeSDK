using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Association;

public class ListMemberInfo : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("TimeAdded", "mTimeAdded", 0xB61D3300, TdfType.Int64, 0, true), // MATS
        new TdfMemberInfo("UserData", "mUserData", 0xB75A6600, TdfType.Struct, 1, true), // MUIF
    ];
    private ITdfMember[] __members;

    private TdfInt64 _timeAdded = new(__typeInfos[0]);
    private TdfStruct<Blaze2SDK.Blaze.UserData?> _userData = new(__typeInfos[1]);

    public ListMemberInfo()
    {
        __members = [
            _timeAdded,
            _userData,
        ];
    }

    public override Tdf CreateNew() => new ListMemberInfo();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ListMemberInfo";
    public override string GetFullClassName() => "Blaze::Association::ListMemberInfo";

    public long TimeAdded
    {
        get => _timeAdded.Value;
        set => _timeAdded.Value = value;
    }

    public Blaze2SDK.Blaze.UserData? UserData
    {
        get => _userData.Value;
        set => _userData.Value = value;
    }

}

