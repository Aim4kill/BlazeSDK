using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Clubs;

public class ClubRecord : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("BlazeId", "mBlazeId", 0x8ACA6400, TdfType.Int64, 0, true), // BLID
        new TdfMemberInfo("LastUpdateTime", "mLastUpdateTime", 0xB3593400, TdfType.UInt32, 1, true), // LUDT
        new TdfMemberInfo("Persona", "mPersona", 0xC25CB300, TdfType.String, 2, true), // PERS
        new TdfMemberInfo("RecordDescription", "mRecordDescription", 0xCA392300, TdfType.String, 3, true), // RCDC
        new TdfMemberInfo("RecordId", "mRecordId", 0xCA3A6400, TdfType.UInt32, 4, true), // RCID
        new TdfMemberInfo("RecordName", "mRecordName", 0xCA3BAD00, TdfType.String, 5, true), // RCNM
        new TdfMemberInfo("RecordStat", "mRecordStat", 0xCF487400, TdfType.String, 6, true), // STAT
        new TdfMemberInfo("RecordStatType", "mRecordStatType", 0xCF4E7000, TdfType.Enum, 7, true), // STYP
    ];
    private ITdfMember[] __members;

    private TdfInt64 _blazeId = new(__typeInfos[0]);
    private TdfUInt32 _lastUpdateTime = new(__typeInfos[1]);
    private TdfString _persona = new(__typeInfos[2]);
    private TdfString _recordDescription = new(__typeInfos[3]);
    private TdfUInt32 _recordId = new(__typeInfos[4]);
    private TdfString _recordName = new(__typeInfos[5]);
    private TdfString _recordStat = new(__typeInfos[6]);
    private TdfEnum<Blaze3SDK.Blaze.Clubs.RecordStatType> _recordStatType = new(__typeInfos[7]);

    public ClubRecord()
    {
        __members = [
            _blazeId,
            _lastUpdateTime,
            _persona,
            _recordDescription,
            _recordId,
            _recordName,
            _recordStat,
            _recordStatType,
        ];
    }

    public override Tdf CreateNew() => new ClubRecord();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ClubRecord";
    public override string GetFullClassName() => "Blaze::Clubs::ClubRecord";

    public long BlazeId
    {
        get => _blazeId.Value;
        set => _blazeId.Value = value;
    }

    public uint LastUpdateTime
    {
        get => _lastUpdateTime.Value;
        set => _lastUpdateTime.Value = value;
    }

    public string Persona
    {
        get => _persona.Value;
        set => _persona.Value = value;
    }

    public string RecordDescription
    {
        get => _recordDescription.Value;
        set => _recordDescription.Value = value;
    }

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

    public string RecordStat
    {
        get => _recordStat.Value;
        set => _recordStat.Value = value;
    }

    public Blaze3SDK.Blaze.Clubs.RecordStatType RecordStatType
    {
        get => _recordStatType.Value;
        set => _recordStatType.Value = value;
    }

}

