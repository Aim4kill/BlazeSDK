using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Arson;

public class GetUEDResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("UserExtendedData", "mUserExtendedData", 0xD6590000, TdfType.Int32, 0, true), // UED
    ];
    private ITdfMember[] __members;

    private TdfInt32 _userExtendedData = new(__typeInfos[0]);

    public GetUEDResponse()
    {
        __members = [
            _userExtendedData,
        ];
    }

    public override Tdf CreateNew() => new GetUEDResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetUEDResponse";
    public override string GetFullClassName() => "Blaze::Arson::GetUEDResponse";

    public int UserExtendedData
    {
        get => _userExtendedData.Value;
        set => _userExtendedData.Value = value;
    }

}

