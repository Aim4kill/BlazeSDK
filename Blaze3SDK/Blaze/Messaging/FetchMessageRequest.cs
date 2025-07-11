using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Messaging;

public class FetchMessageRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Flags", "mFlags", 0x9AC86700, TdfType.Enum, 0, true), // FLAG
        new TdfMemberInfo("MessageId", "mMessageId", 0xB67A6400, TdfType.UInt32, 1, true), // MGID
        new TdfMemberInfo("PageIndex", "mPageIndex", 0xC2993800, TdfType.UInt32, 2, true), // PIDX
        new TdfMemberInfo("PageSize", "mPageSize", 0xC33A7A00, TdfType.UInt32, 3, true), // PSIZ
        new TdfMemberInfo("StatusMask", "mStatusMask", 0xCEDCEB00, TdfType.UInt32, 4, true), // SMSK
        new TdfMemberInfo("OrderBy", "mOrderBy", 0xCEFCB400, TdfType.Enum, 5, true), // SORT
        new TdfMemberInfo("Source", "mSource", 0xCF28E500, TdfType.ObjectId, 6, true), // SRCE
        new TdfMemberInfo("Status", "mStatus", 0xCF487400, TdfType.UInt32, 7, true), // STAT
        new TdfMemberInfo("Target", "mTarget", 0xD21CA700, TdfType.ObjectId, 8, true), // TARG
        new TdfMemberInfo("Type", "mType", 0xD39C2500, TdfType.UInt32, 9, true), // TYPE
        new TdfMemberInfo("TypeList", "mTypeList", 0xD39C2C00, TdfType.List, 10, true), // TYPL
    ];
    private ITdfMember[] __members;

    private TdfEnum<Blaze3SDK.Blaze.Messaging.MatchFlags> _flags = new(__typeInfos[0]);
    private TdfUInt32 _messageId = new(__typeInfos[1]);
    private TdfUInt32 _pageIndex = new(__typeInfos[2]);
    private TdfUInt32 _pageSize = new(__typeInfos[3]);
    private TdfUInt32 _statusMask = new(__typeInfos[4]);
    private TdfEnum<Blaze3SDK.Blaze.Messaging.MessageOrder> _orderBy = new(__typeInfos[5]);
    private TdfObjectId _source = new(__typeInfos[6]);
    private TdfUInt32 _status = new(__typeInfos[7]);
    private TdfObjectId _target = new(__typeInfos[8]);
    private TdfUInt32 _type = new(__typeInfos[9]);
    private TdfList<uint> _typeList = new(__typeInfos[10]);

    public FetchMessageRequest()
    {
        __members = [
            _flags,
            _messageId,
            _pageIndex,
            _pageSize,
            _statusMask,
            _orderBy,
            _source,
            _status,
            _target,
            _type,
            _typeList,
        ];
    }

    public override Tdf CreateNew() => new FetchMessageRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "FetchMessageRequest";
    public override string GetFullClassName() => "Blaze::Messaging::FetchMessageRequest";

    public Blaze3SDK.Blaze.Messaging.MatchFlags Flags
    {
        get => _flags.Value;
        set => _flags.Value = value;
    }

    public uint MessageId
    {
        get => _messageId.Value;
        set => _messageId.Value = value;
    }

    public uint PageIndex
    {
        get => _pageIndex.Value;
        set => _pageIndex.Value = value;
    }

    public uint PageSize
    {
        get => _pageSize.Value;
        set => _pageSize.Value = value;
    }

    public uint StatusMask
    {
        get => _statusMask.Value;
        set => _statusMask.Value = value;
    }

    public Blaze3SDK.Blaze.Messaging.MessageOrder OrderBy
    {
        get => _orderBy.Value;
        set => _orderBy.Value = value;
    }

    public ObjectId Source
    {
        get => _source.Value;
        set => _source.Value = value;
    }

    public uint Status
    {
        get => _status.Value;
        set => _status.Value = value;
    }

    public ObjectId Target
    {
        get => _target.Value;
        set => _target.Value = value;
    }

    public uint Type
    {
        get => _type.Value;
        set => _type.Value = value;
    }

    public IList<uint> TypeList
    {
        get => _typeList.Value;
        set => _typeList.Value = value;
    }

}

