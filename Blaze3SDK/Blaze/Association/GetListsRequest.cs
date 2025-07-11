using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Association;

public class GetListsRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ListInfoVector", "mListInfoVector", 0x86CCF400, TdfType.List, 0, true), // ALST
        new TdfMemberInfo("MaxResultCount", "mMaxResultCount", 0xB78CA300, TdfType.UInt32, 1, true), // MXRC
        new TdfMemberInfo("Offset", "mOffset", 0xBE6CA300, TdfType.UInt32, 2, true), // OFRC
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze3SDK.Blaze.Association.ListInfo> _listInfoVector = new(__typeInfos[0]);
    private TdfUInt32 _maxResultCount = new(__typeInfos[1]);
    private TdfUInt32 _offset = new(__typeInfos[2]);

    public GetListsRequest()
    {
        __members = [
            _listInfoVector,
            _maxResultCount,
            _offset,
        ];
    }

    public override Tdf CreateNew() => new GetListsRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetListsRequest";
    public override string GetFullClassName() => "Blaze::Association::GetListsRequest";

    public IList<Blaze3SDK.Blaze.Association.ListInfo> ListInfoVector
    {
        get => _listInfoVector.Value;
        set => _listInfoVector.Value = value;
    }

    public uint MaxResultCount
    {
        get => _maxResultCount.Value;
        set => _maxResultCount.Value = value;
    }

    public uint Offset
    {
        get => _offset.Value;
        set => _offset.Value = value;
    }

}

