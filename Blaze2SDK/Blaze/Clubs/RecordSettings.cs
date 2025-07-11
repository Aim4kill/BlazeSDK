using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Clubs;

public class RecordSettings : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("RecordId", "mRecordId", 0xCA3A6400, TdfType.UInt32, 0, true), // RCID
        new TdfMemberInfo("RecordName", "mRecordName", 0xCA3BA100, TdfType.String, 1, true), // RCNA
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _recordId = new(__typeInfos[0]);
    private TdfString _recordName = new(__typeInfos[1]);

    public RecordSettings()
    {
        __members = [
            _recordId,
            _recordName,
        ];
    }

    public override Tdf CreateNew() => new RecordSettings();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "RecordSettings";
    public override string GetFullClassName() => "Blaze::Clubs::RecordSettings";

    public uint RecordId
    {
        get => _recordId.Value;
        set => _recordId.Value = value;
    }

    public string RecordName
    {
        get => _recordName.Value;
        set => _recordName.Value = value;
    }

}

