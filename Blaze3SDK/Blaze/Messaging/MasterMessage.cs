using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Messaging;

public class MasterMessage : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("SlaveMessage", "mSlaveMessage", 0xCEDCE700, TdfType.Struct, 0, true), // SMSG
        new TdfMemberInfo("TargetSlaveIds", "mTargetSlaveIds", 0xD29B6500, TdfType.List, 1, true), // TIME
    ];
    private ITdfMember[] __members;

    private TdfStruct<Blaze3SDK.Blaze.Messaging.SlaveMessage?> _slaveMessage = new(__typeInfos[0]);
    private TdfList<uint> _targetSlaveIds = new(__typeInfos[1]);

    public MasterMessage()
    {
        __members = [
            _slaveMessage,
            _targetSlaveIds,
        ];
    }

    public override Tdf CreateNew() => new MasterMessage();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "MasterMessage";
    public override string GetFullClassName() => "Blaze::Messaging::MasterMessage";

    public Blaze3SDK.Blaze.Messaging.SlaveMessage? SlaveMessage
    {
        get => _slaveMessage.Value;
        set => _slaveMessage.Value = value;
    }

    public IList<uint> TargetSlaveIds
    {
        get => _targetSlaveIds.Value;
        set => _targetSlaveIds.Value = value;
    }

}

