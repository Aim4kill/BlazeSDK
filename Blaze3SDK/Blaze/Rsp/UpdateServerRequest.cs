using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Rsp;

public class UpdateServerRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ExpirationDate", "mExpirationDate", 0x97892100, TdfType.TimeValue, 0, true), // EXDA
        new TdfMemberInfo("ExpirationPeriod", "mExpirationPeriod", 0x978C2500, TdfType.UInt32, 1, true), // EXPE
        new TdfMemberInfo("ServerId", "mServerId", 0xCE990000, TdfType.UInt32, 2, true), // SID
    ];
    private ITdfMember[] __members;

    private TdfTimeValue _expirationDate = new(__typeInfos[0]);
    private TdfUInt32 _expirationPeriod = new(__typeInfos[1]);
    private TdfUInt32 _serverId = new(__typeInfos[2]);

    public UpdateServerRequest()
    {
        __members = [
            _expirationDate,
            _expirationPeriod,
            _serverId,
        ];
    }

    public override Tdf CreateNew() => new UpdateServerRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "UpdateServerRequest";
    public override string GetFullClassName() => "Blaze::Rsp::UpdateServerRequest";

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

    public uint ServerId
    {
        get => _serverId.Value;
        set => _serverId.Value = value;
    }

}

