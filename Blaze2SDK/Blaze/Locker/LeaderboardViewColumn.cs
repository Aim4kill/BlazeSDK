using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Locker;

public class LeaderboardViewColumn : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Display", "mDisplay", 0x929CF000, TdfType.Int32, 0, true), // DISP
        new TdfMemberInfo("Format", "mFormat", 0x9B2B7400, TdfType.String, 1, true), // FRMT
        new TdfMemberInfo("LongDesc", "mLongDesc", 0xB24CE300, TdfType.String, 2, true), // LDSC
        new TdfMemberInfo("Name", "mName", 0xBA1B6500, TdfType.String, 3, true), // NAME
        new TdfMemberInfo("ShortDesc", "mShortDesc", 0xCE4CE300, TdfType.String, 4, true), // SDSC
        new TdfMemberInfo("Type", "mType", 0xD39C2500, TdfType.String, 5, true), // TYPE
    ];
    private ITdfMember[] __members;

    private TdfInt32 _display = new(__typeInfos[0]);
    private TdfString _format = new(__typeInfos[1]);
    private TdfString _longDesc = new(__typeInfos[2]);
    private TdfString _name = new(__typeInfos[3]);
    private TdfString _shortDesc = new(__typeInfos[4]);
    private TdfString _type = new(__typeInfos[5]);

    public LeaderboardViewColumn()
    {
        __members = [
            _display,
            _format,
            _longDesc,
            _name,
            _shortDesc,
            _type,
        ];
    }

    public override Tdf CreateNew() => new LeaderboardViewColumn();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "LeaderboardViewColumn";
    public override string GetFullClassName() => "Blaze::Locker::LeaderboardViewColumn";

    public int Display
    {
        get => _display.Value;
        set => _display.Value = value;
    }

    public string Format
    {
        get => _format.Value;
        set => _format.Value = value;
    }

    public string LongDesc
    {
        get => _longDesc.Value;
        set => _longDesc.Value = value;
    }

    public string Name
    {
        get => _name.Value;
        set => _name.Value = value;
    }

    public string ShortDesc
    {
        get => _shortDesc.Value;
        set => _shortDesc.Value = value;
    }

    public string Type
    {
        get => _type.Value;
        set => _type.Value = value;
    }

}

