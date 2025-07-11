using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Clubs;

public class SendPetitionRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ClubId", "mClubId", 0x8ECA6400, TdfType.UInt32, 0, true), // CLID
        new TdfMemberInfo("Password", "mPassword", 0xC33DE400, TdfType.String, 1, true), // PSWD
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _clubId = new(__typeInfos[0]);
    private TdfString _password = new(__typeInfos[1]);

    public SendPetitionRequest()
    {
        __members = [
            _clubId,
            _password,
        ];
    }

    public override Tdf CreateNew() => new SendPetitionRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "SendPetitionRequest";
    public override string GetFullClassName() => "Blaze::Clubs::SendPetitionRequest";

    public uint ClubId
    {
        get => _clubId.Value;
        set => _clubId.Value = value;
    }

    public string Password
    {
        get => _password.Value;
        set => _password.Value = value;
    }

}

