using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Arson;

public class UpdateUEDRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ComponentName", "mComponentName", 0x8EE86D00, TdfType.String, 0, true), // CNAM
        new TdfMemberInfo("UserExtendedData", "mUserExtendedData", 0xD6590000, TdfType.Int32, 1, true), // UED
        new TdfMemberInfo("UserExtendedDataId", "mUserExtendedDataId", 0xD6592B00, TdfType.UInt16, 2, true), // UEDK
        new TdfMemberInfo("UserExtendedDataName", "mUserExtendedDataName", 0xD6592E00, TdfType.String, 3, true), // UEDN
    ];
    private ITdfMember[] __members;

    private TdfString _componentName = new(__typeInfos[0]);
    private TdfInt32 _userExtendedData = new(__typeInfos[1]);
    private TdfUInt16 _userExtendedDataId = new(__typeInfos[2]);
    private TdfString _userExtendedDataName = new(__typeInfos[3]);

    public UpdateUEDRequest()
    {
        __members = [
            _componentName,
            _userExtendedData,
            _userExtendedDataId,
            _userExtendedDataName,
        ];
    }

    public override Tdf CreateNew() => new UpdateUEDRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "UpdateUEDRequest";
    public override string GetFullClassName() => "Blaze::Arson::UpdateUEDRequest";

    public string ComponentName
    {
        get => _componentName.Value;
        set => _componentName.Value = value;
    }

    public int UserExtendedData
    {
        get => _userExtendedData.Value;
        set => _userExtendedData.Value = value;
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

