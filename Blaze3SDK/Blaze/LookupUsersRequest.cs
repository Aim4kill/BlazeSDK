using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze;

public class LookupUsersRequest : Tdf
{
    public enum LookupType : int
    {
        BLAZE_ID = 0,
        PERSONA_NAME = 1,
        EXTERNAL_ID = 2,
        ACCOUNT_ID = 3,
    }
    
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("LookupType", "mLookupType", 0xB34E7000, TdfType.Enum, 0, true), // LTYP
        new TdfMemberInfo("UserIdentificationList", "mUserIdentificationList", 0xD6CCF400, TdfType.List, 1, true), // ULST
    ];
    private ITdfMember[] __members;

    private TdfEnum<Blaze3SDK.Blaze.LookupUsersRequest.LookupType> _lookupType = new(__typeInfos[0]);
    private TdfList<Blaze3SDK.Blaze.UserIdentification> _userIdentificationList = new(__typeInfos[1]);

    public LookupUsersRequest()
    {
        __members = [
            _lookupType,
            _userIdentificationList,
        ];
    }

    public override Tdf CreateNew() => new LookupUsersRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "LookupUsersRequest";
    public override string GetFullClassName() => "Blaze::LookupUsersRequest";

    public Blaze3SDK.Blaze.LookupUsersRequest.LookupType mLookupType
    {
        get => _lookupType.Value;
        set => _lookupType.Value = value;
    }

    public IList<Blaze3SDK.Blaze.UserIdentification> UserIdentificationList
    {
        get => _userIdentificationList.Value;
        set => _userIdentificationList.Value = value;
    }

}

