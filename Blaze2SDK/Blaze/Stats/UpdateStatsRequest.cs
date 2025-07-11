using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Stats;

public class UpdateStatsRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("StatUpdates", "mStatUpdates", 0xD7093400, TdfType.List, 0, true), // UPDT
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze2SDK.Blaze.Stats.StatRowUpdate> _statUpdates = new(__typeInfos[0]);

    public UpdateStatsRequest()
    {
        __members = [
            _statUpdates,
        ];
    }

    public override Tdf CreateNew() => new UpdateStatsRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "UpdateStatsRequest";
    public override string GetFullClassName() => "Blaze::Stats::UpdateStatsRequest";

    public IList<Blaze2SDK.Blaze.Stats.StatRowUpdate> StatUpdates
    {
        get => _statUpdates.Value;
        set => _statUpdates.Value = value;
    }

}

