using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameManager;

public class BannedListResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("BannedMembers", "mBannedMembers", 0x8A1BAD00, TdfType.List, 0, true), // BANM
    ];
    private ITdfMember[] __members;

    private TdfList<long> _bannedMembers = new(__typeInfos[0]);

    public BannedListResponse()
    {
        __members = [
            _bannedMembers,
        ];
    }

    public override Tdf CreateNew() => new BannedListResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "BannedListResponse";
    public override string GetFullClassName() => "Blaze::GameManager::BannedListResponse";

    public IList<long> BannedMembers
    {
        get => _bannedMembers.Value;
        set => _bannedMembers.Value = value;
    }

}

