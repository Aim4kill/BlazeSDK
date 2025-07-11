using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze;

public class UserManagerCensusData : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ConnectedPlayerCounts", "mConnectedPlayerCounts", 0x8F08ED00, TdfType.Map, 0, true), // CPCM
    ];
    private ITdfMember[] __members;

    private TdfMap<Blaze3SDK.Blaze.ClientType, uint> _connectedPlayerCounts = new(__typeInfos[0]);

    public UserManagerCensusData()
    {
        __members = [
            _connectedPlayerCounts,
        ];
    }

    public override Tdf CreateNew() => new UserManagerCensusData();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "UserManagerCensusData";
    public override string GetFullClassName() => "Blaze::UserManagerCensusData";

    public IDictionary<Blaze3SDK.Blaze.ClientType, uint> ConnectedPlayerCounts
    {
        get => _connectedPlayerCounts.Value;
        set => _connectedPlayerCounts.Value = value;
    }

}

