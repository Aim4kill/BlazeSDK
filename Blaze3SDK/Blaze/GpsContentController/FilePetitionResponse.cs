using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GpsContentController;

public class FilePetitionResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("PetitionGuid", "mPetitionGuid", 0x9F5A6400, TdfType.String, 0, true), // GUID
    ];
    private ITdfMember[] __members;

    private TdfString _petitionGuid = new(__typeInfos[0]);

    public FilePetitionResponse()
    {
        __members = [
            _petitionGuid,
        ];
    }

    public override Tdf CreateNew() => new FilePetitionResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "FilePetitionResponse";
    public override string GetFullClassName() => "Blaze::GpsContentController::FilePetitionResponse";

    public string PetitionGuid
    {
        get => _petitionGuid.Value;
        set => _petitionGuid.Value = value;
    }

}

