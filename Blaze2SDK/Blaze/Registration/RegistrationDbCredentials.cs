using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Registration;

public class RegistrationDbCredentials : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("DbHost", "mDbHost", 0xA2FCF400, TdfType.String, 0, true), // HOST
        new TdfMemberInfo("DbInstanceName", "mDbInstanceName", 0xBA1B6500, TdfType.String, 1, true), // NAME
        new TdfMemberInfo("DbPassword", "mDbPassword", 0xC21CF300, TdfType.String, 2, true), // PASS
        new TdfMemberInfo("DbPort", "mDbPort", 0xC2FCB400, TdfType.UInt32, 3, true), // PORT
        new TdfMemberInfo("DbSchema", "mDbSchema", 0xCE3A2D00, TdfType.String, 4, true), // SCHM
        new TdfMemberInfo("DbUser", "mDbUser", 0xD7397200, TdfType.String, 5, true), // USER
    ];
    private ITdfMember[] __members;

    private TdfString _dbHost = new(__typeInfos[0]);
    private TdfString _dbInstanceName = new(__typeInfos[1]);
    private TdfString _dbPassword = new(__typeInfos[2]);
    private TdfUInt32 _dbPort = new(__typeInfos[3]);
    private TdfString _dbSchema = new(__typeInfos[4]);
    private TdfString _dbUser = new(__typeInfos[5]);

    public RegistrationDbCredentials()
    {
        __members = [
            _dbHost,
            _dbInstanceName,
            _dbPassword,
            _dbPort,
            _dbSchema,
            _dbUser,
        ];
    }

    public override Tdf CreateNew() => new RegistrationDbCredentials();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "RegistrationDbCredentials";
    public override string GetFullClassName() => "Blaze::Registration::RegistrationDbCredentials";

    public string DbHost
    {
        get => _dbHost.Value;
        set => _dbHost.Value = value;
    }

    public string DbInstanceName
    {
        get => _dbInstanceName.Value;
        set => _dbInstanceName.Value = value;
    }

    public string DbPassword
    {
        get => _dbPassword.Value;
        set => _dbPassword.Value = value;
    }

    public uint DbPort
    {
        get => _dbPort.Value;
        set => _dbPort.Value = value;
    }

    public string DbSchema
    {
        get => _dbSchema.Value;
        set => _dbSchema.Value = value;
    }

    public string DbUser
    {
        get => _dbUser.Value;
        set => _dbUser.Value = value;
    }

}

