using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Playgroups;

public class JoinPlaygroupRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Id", "mId", 0xC27A6400, TdfType.UInt32, 0, true), // PGID
        new TdfMemberInfo("NetworkAddress", "mNetworkAddress", 0xC2E97400, TdfType.Union, 1, true), // PNET
        new TdfMemberInfo("UniqueKey", "mUniqueKey", 0xD6B97900, TdfType.String, 2, true), // UKEY
        new TdfMemberInfo("User", "mUser", 0xD7397200, TdfType.Struct, 3, true), // USER
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _id = new(__typeInfos[0]);
    private TdfUnion<Blaze2SDK.Blaze.NetworkAddress> _networkAddress = new(__typeInfos[1]);
    private TdfString _uniqueKey = new(__typeInfos[2]);
    private TdfStruct<Blaze2SDK.Blaze.UserIdentification?> _user = new(__typeInfos[3]);

    public JoinPlaygroupRequest()
    {
        __members = [
            _id,
            _networkAddress,
            _uniqueKey,
            _user,
        ];
    }

    public override Tdf CreateNew() => new JoinPlaygroupRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "JoinPlaygroupRequest";
    public override string GetFullClassName() => "Blaze::Playgroups::JoinPlaygroupRequest";

    public uint Id
    {
        get => _id.Value;
        set => _id.Value = value;
    }

    public Blaze2SDK.Blaze.NetworkAddress NetworkAddress
    {
        get => _networkAddress.Value;
        set => _networkAddress.Value = value;
    }

    public string UniqueKey
    {
        get => _uniqueKey.Value;
        set => _uniqueKey.Value = value;
    }

    public Blaze2SDK.Blaze.UserIdentification? User
    {
        get => _user.Value;
        set => _user.Value = value;
    }

}

