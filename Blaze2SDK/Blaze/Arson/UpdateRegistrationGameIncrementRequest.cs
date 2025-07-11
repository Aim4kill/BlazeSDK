using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Arson;

public class UpdateRegistrationGameIncrementRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Evid", "mEvid", 0x976A6400, TdfType.Int32, 0, true), // EVID
        new TdfMemberInfo("NumGames", "mNumGames", 0xBB5B6700, TdfType.Int32, 1, true), // NUMG
        new TdfMemberInfo("UserId", "mUserId", 0xD6990000, TdfType.UInt32, 2, true), // UID
    ];
    private ITdfMember[] __members;

    private TdfInt32 _evid = new(__typeInfos[0]);
    private TdfInt32 _numGames = new(__typeInfos[1]);
    private TdfUInt32 _userId = new(__typeInfos[2]);

    public UpdateRegistrationGameIncrementRequest()
    {
        __members = [
            _evid,
            _numGames,
            _userId,
        ];
    }

    public override Tdf CreateNew() => new UpdateRegistrationGameIncrementRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "UpdateRegistrationGameIncrementRequest";
    public override string GetFullClassName() => "Blaze::Arson::UpdateRegistrationGameIncrementRequest";

    public int Evid
    {
        get => _evid.Value;
        set => _evid.Value = value;
    }

    public int NumGames
    {
        get => _numGames.Value;
        set => _numGames.Value = value;
    }

    public uint UserId
    {
        get => _userId.Value;
        set => _userId.Value = value;
    }

}

