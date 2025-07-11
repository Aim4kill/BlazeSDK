using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Arson;

public class GetUEDRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ComponentName", "mComponentName", 0x8EE86D00, TdfType.String, 0, true), // CNAM
        new TdfMemberInfo("UserExtendedDataId", "mUserExtendedDataId", 0xD6592B00, TdfType.UInt16, 1, true), // UEDK
        new TdfMemberInfo("UserExtendedDataName", "mUserExtendedDataName", 0xD6592E00, TdfType.String, 2, true), // UEDN
    ];
    private ITdfMember[] __members;

    private TdfString _componentName = new(__typeInfos[0]);
    private TdfUInt16 _userExtendedDataId = new(__typeInfos[1]);
    private TdfString _userExtendedDataName = new(__typeInfos[2]);

    public GetUEDRequest()
    {
        __members = [
            _componentName,
            _userExtendedDataId,
            _userExtendedDataName,
        ];
    }

    public override Tdf CreateNew() => new GetUEDRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetUEDRequest";
    public override string GetFullClassName() => "Blaze::Arson::GetUEDRequest";

    public string ComponentName
    {
        get => _componentName.Value;
        set => _componentName.Value = value;
    }

    public ushort UserExtendedDataId
    {
        get => _userExtendedDataId.Value;
        set => _userExtendedDataId.Value = value;
    }

    public string UserExtendedDataName
    {
        get => _userExtendedDataName.Value;
        set => _userExtendedDataName.Value = value;
    }

}

