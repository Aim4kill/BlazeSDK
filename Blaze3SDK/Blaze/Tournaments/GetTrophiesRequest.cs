using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Tournaments;

public class GetTrophiesRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("BlazeId", "mBlazeId", 0x8BAA6400, TdfType.Int64, 0, true), // BZID
        new TdfMemberInfo("NumTrophies", "mNumTrophies", 0xBB5B7400, TdfType.UInt32, 1, true), // NUMT
    ];
    private ITdfMember[] __members;

    private TdfInt64 _blazeId = new(__typeInfos[0]);
    private TdfUInt32 _numTrophies = new(__typeInfos[1]);

    public GetTrophiesRequest()
    {
        __members = [
            _blazeId,
            _numTrophies,
        ];
    }

    public override Tdf CreateNew() => new GetTrophiesRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetTrophiesRequest";
    public override string GetFullClassName() => "Blaze::Tournaments::GetTrophiesRequest";

    public long BlazeId
    {
        get => _blazeId.Value;
        set => _blazeId.Value = value;
    }

    public uint NumTrophies
    {
        get => _numTrophies.Value;
        set => _numTrophies.Value = value;
    }

}

