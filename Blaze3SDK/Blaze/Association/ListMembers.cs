using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Association;

public class ListMembers : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Info", "mInfo", 0xA6E9AF00, TdfType.Struct, 0, true), // INFO
        new TdfMemberInfo("ListMemberInfoVector", "mListMemberInfoVector", 0xB65B6C00, TdfType.List, 1, true), // MEML
        new TdfMemberInfo("Offset", "mOffset", 0xBE6CA300, TdfType.UInt32, 2, true), // OFRC
        new TdfMemberInfo("TotalCount", "mTotalCount", 0xD2F8F400, TdfType.UInt32, 3, true), // TOCT
    ];
    private ITdfMember[] __members;

    private TdfStruct<Blaze3SDK.Blaze.Association.ListInfo?> _info = new(__typeInfos[0]);
    private TdfList<Blaze3SDK.Blaze.Association.ListMemberInfo> _listMemberInfoVector = new(__typeInfos[1]);
    private TdfUInt32 _offset = new(__typeInfos[2]);
    private TdfUInt32 _totalCount = new(__typeInfos[3]);

    public ListMembers()
    {
        __members = [
            _info,
            _listMemberInfoVector,
            _offset,
            _totalCount,
        ];
    }

    public override Tdf CreateNew() => new ListMembers();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ListMembers";
    public override string GetFullClassName() => "Blaze::Association::ListMembers";

    public Blaze3SDK.Blaze.Association.ListInfo? Info
    {
        get => _info.Value;
        set => _info.Value = value;
    }

    public IList<Blaze3SDK.Blaze.Association.ListMemberInfo> ListMemberInfoVector
    {
        get => _listMemberInfoVector.Value;
        set => _listMemberInfoVector.Value = value;
    }

    public uint Offset
    {
        get => _offset.Value;
        set => _offset.Value = value;
    }

    public uint TotalCount
    {
        get => _totalCount.Value;
        set => _totalCount.Value = value;
    }

}

