using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Association;

public class ListMemberId : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("BlazeId", "mBlazeId", 0x8ACA6400, TdfType.UInt32, 0, true), // BLID
        new TdfMemberInfo("ExternalMemId", "mExternalMemId", 0x974A6400, TdfType.Struct, 1, true), // ETID
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _blazeId = new(__typeInfos[0]);
    private TdfStruct<Blaze2SDK.Blaze.Association.ExternalMemberId?> _externalMemId = new(__typeInfos[1]);

    public ListMemberId()
    {
        __members = [
            _blazeId,
            _externalMemId,
        ];
    }

    public override Tdf CreateNew() => new ListMemberId();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ListMemberId";
    public override string GetFullClassName() => "Blaze::Association::ListMemberId";

    public uint BlazeId
    {
        get => _blazeId.Value;
        set => _blazeId.Value = value;
    }

    public Blaze2SDK.Blaze.Association.ExternalMemberId? ExternalMemId
    {
        get => _externalMemId.Value;
        set => _externalMemId.Value = value;
    }

}

