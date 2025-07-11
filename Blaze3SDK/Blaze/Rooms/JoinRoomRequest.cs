using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Rooms;

public class JoinRoomRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("CategoryId", "mCategoryId", 0x8F4A6400, TdfType.UInt32, 0, true), // CTID
        new TdfMemberInfo("InviterId", "mInviterId", 0xA6EA6400, TdfType.Int64, 1, true), // INID
        new TdfMemberInfo("IsUserInvited", "mIsUserInvited", 0xA6EDB400, TdfType.Bool, 2, true), // INVT
        new TdfMemberInfo("Password", "mPassword", 0xC21CF300, TdfType.String, 3, true), // PASS
        new TdfMemberInfo("PseudoValue", "mPseudoValue", 0xC3686C00, TdfType.String, 4, true), // PVAL
        new TdfMemberInfo("RoomId", "mRoomId", 0xCADA6400, TdfType.UInt32, 5, true), // RMID
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _categoryId = new(__typeInfos[0]);
    private TdfInt64 _inviterId = new(__typeInfos[1]);
    private TdfBool _isUserInvited = new(__typeInfos[2]);
    private TdfString _password = new(__typeInfos[3]);
    private TdfString _pseudoValue = new(__typeInfos[4]);
    private TdfUInt32 _roomId = new(__typeInfos[5]);

    public JoinRoomRequest()
    {
        __members = [
            _categoryId,
            _inviterId,
            _isUserInvited,
            _password,
            _pseudoValue,
            _roomId,
        ];
    }

    public override Tdf CreateNew() => new JoinRoomRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "JoinRoomRequest";
    public override string GetFullClassName() => "Blaze::Rooms::JoinRoomRequest";

    public uint CategoryId
    {
        get => _categoryId.Value;
        set => _categoryId.Value = value;
    }

    public long InviterId
    {
        get => _inviterId.Value;
        set => _inviterId.Value = value;
    }

    public bool IsUserInvited
    {
        get => _isUserInvited.Value;
        set => _isUserInvited.Value = value;
    }

    public string Password
    {
        get => _password.Value;
        set => _password.Value = value;
    }

    public string PseudoValue
    {
        get => _pseudoValue.Value;
        set => _pseudoValue.Value = value;
    }

    public uint RoomId
    {
        get => _roomId.Value;
        set => _roomId.Value = value;
    }

}

