using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.DynamicInetFilter;

public class UpdateRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Comment", "mComment", 0x8EFB6D00, TdfType.String, 0, true), // COMM
        new TdfMemberInfo("Group", "mGroup", 0x9F2C0000, TdfType.String, 1, true), // GRP
        new TdfMemberInfo("Owner", "mOwner", 0xBF7BB200, TdfType.String, 2, true), // OWNR
        new TdfMemberInfo("RowId", "mRowId", 0xCA990000, TdfType.UInt32, 3, true), // RID
        new TdfMemberInfo("SubNet", "mSubNet", 0xCEE97400, TdfType.Struct, 4, true), // SNET
    ];
    private ITdfMember[] __members;

    private TdfString _comment = new(__typeInfos[0]);
    private TdfString _group = new(__typeInfos[1]);
    private TdfString _owner = new(__typeInfos[2]);
    private TdfUInt32 _rowId = new(__typeInfos[3]);
    private TdfStruct<Blaze3SDK.Blaze.DynamicInetFilter.CidrBlock?> _subNet = new(__typeInfos[4]);

    public UpdateRequest()
    {
        __members = [
            _comment,
            _group,
            _owner,
            _rowId,
            _subNet,
        ];
    }

    public override Tdf CreateNew() => new UpdateRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "UpdateRequest";
    public override string GetFullClassName() => "Blaze::DynamicInetFilter::UpdateRequest";

    public string Comment
    {
        get => _comment.Value;
        set => _comment.Value = value;
    }

    public string Group
    {
        get => _group.Value;
        set => _group.Value = value;
    }

    public string Owner
    {
        get => _owner.Value;
        set => _owner.Value = value;
    }

    public uint RowId
    {
        get => _rowId.Value;
        set => _rowId.Value = value;
    }

    public Blaze3SDK.Blaze.DynamicInetFilter.CidrBlock? SubNet
    {
        get => _subNet.Value;
        set => _subNet.Value = value;
    }

}

