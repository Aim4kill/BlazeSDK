using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Rsp;

public class CreateServerResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ServerId", "mServerId", 0xCE990000, TdfType.UInt32, 0, true), // SID
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _serverId = new(__typeInfos[0]);

    public CreateServerResponse()
    {
        __members = [
            _serverId,
        ];
    }

    public override Tdf CreateNew() => new CreateServerResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "CreateServerResponse";
    public override string GetFullClassName() => "Blaze::Rsp::CreateServerResponse";

    public uint ServerId
    {
        get => _serverId.Value;
        set => _serverId.Value = value;
    }

}

