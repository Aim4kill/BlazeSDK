using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.League;

public class PositionPref : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Preferences", "mPreferences", 0xCA4C2600, TdfType.List, 0, true), // RDPF
    ];
    private ITdfMember[] __members;

    private TdfList<sbyte> _preferences = new(__typeInfos[0]);

    public PositionPref()
    {
        __members = [
            _preferences,
        ];
    }

    public override Tdf CreateNew() => new PositionPref();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "PositionPref";
    public override string GetFullClassName() => "Blaze::League::PositionPref";

    public IList<sbyte> Preferences
    {
        get => _preferences.Value;
        set => _preferences.Value = value;
    }

}

