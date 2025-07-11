using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Rsp;

public class UpdateServerMapRotationRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("MapRotation", "mMapRotation", 0xB61C3200, TdfType.Struct, 0, true), // MAPR
        new TdfMemberInfo("ServerId", "mServerId", 0xCE990000, TdfType.UInt32, 1, true), // SID
    ];
    private ITdfMember[] __members;

    private TdfStruct<Blaze3SDK.Blaze.Rsp.MapRotation?> _mapRotation = new(__typeInfos[0]);
    private TdfUInt32 _serverId = new(__typeInfos[1]);

    public UpdateServerMapRotationRequest()
    {
        __members = [
            _mapRotation,
            _serverId,
        ];
    }

    public override Tdf CreateNew() => new UpdateServerMapRotationRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "UpdateServerMapRotationRequest";
    public override string GetFullClassName() => "Blaze::Rsp::UpdateServerMapRotationRequest";

    public Blaze3SDK.Blaze.Rsp.MapRotation? MapRotation
    {
        get => _mapRotation.Value;
        set => _mapRotation.Value = value;
    }

    public uint ServerId
    {
        get => _serverId.Value;
        set => _serverId.Value = value;
    }

}

