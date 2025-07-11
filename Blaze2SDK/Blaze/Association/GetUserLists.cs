using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Association;

public class GetUserLists : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ListSettingVector", "mListSettingVector", 0x86CCF400, TdfType.List, 0, true), // ALST
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze2SDK.Blaze.Association.ListSetting> _listSettingVector = new(__typeInfos[0]);

    public GetUserLists()
    {
        __members = [
            _listSettingVector,
        ];
    }

    public override Tdf CreateNew() => new GetUserLists();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetUserLists";
    public override string GetFullClassName() => "Blaze::Association::GetUserLists";

    public IList<Blaze2SDK.Blaze.Association.ListSetting> ListSettingVector
    {
        get => _listSettingVector.Value;
        set => _listSettingVector.Value = value;
    }

}

