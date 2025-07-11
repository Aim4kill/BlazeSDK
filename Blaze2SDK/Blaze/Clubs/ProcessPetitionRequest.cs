using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Clubs;

public class ProcessPetitionRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("PetitionId", "mPetitionId", 0xA6EA6400, TdfType.UInt32, 0, true), // INID
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _petitionId = new(__typeInfos[0]);

    public ProcessPetitionRequest()
    {
        __members = [
            _petitionId,
        ];
    }

    public override Tdf CreateNew() => new ProcessPetitionRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ProcessPetitionRequest";
    public override string GetFullClassName() => "Blaze::Clubs::ProcessPetitionRequest";

    public uint PetitionId
    {
        get => _petitionId.Value;
        set => _petitionId.Value = value;
    }

}

