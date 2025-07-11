using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Rsp;

public class CreateServerRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ExpirationDate", "mExpirationDate", 0x97892100, TdfType.TimeValue, 0, true), // EXDA
        new TdfMemberInfo("ExpirationPeriod", "mExpirationPeriod", 0x978C2500, TdfType.UInt32, 1, true), // EXPE
        new TdfMemberInfo("PingSiteAlias", "mPingSiteAlias", 0xC3386C00, TdfType.String, 2, true), // PSAL
        new TdfMemberInfo("UserId", "mUserId", 0xD6990000, TdfType.Int64, 3, true), // UID
    ];
    private ITdfMember[] __members;

    private TdfTimeValue _expirationDate = new(__typeInfos[0]);
    private TdfUInt32 _expirationPeriod = new(__typeInfos[1]);
    private TdfString _pingSiteAlias = new(__typeInfos[2]);
    private TdfInt64 _userId = new(__typeInfos[3]);

    public CreateServerRequest()
    {
        __members = [
            _expirationDate,
            _expirationPeriod,
            _pingSiteAlias,
            _userId,
        ];
    }

    public override Tdf CreateNew() => new CreateServerRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "CreateServerRequest";
    public override string GetFullClassName() => "Blaze::Rsp::CreateServerRequest";

    public TimeValue ExpirationDate
    {
        get => _expirationDate.Value;
        set => _expirationDate.Value = value;
    }

    public uint ExpirationPeriod
    {
        get => _expirationPeriod.Value;
        set => _expirationPeriod.Value = value;
    }

    public string PingSiteAlias
    {
        get => _pingSiteAlias.Value;
        set => _pingSiteAlias.Value = value;
    }

    public long UserId
    {
        get => _userId.Value;
        set => _userId.Value = value;
    }

}

