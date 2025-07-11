namespace EATDF.Heat;

internal struct HeatMemberHeader
{
    public static readonly HeatMemberHeader Invalid = new HeatMemberHeader { Tag = 0, Type = HeatType.Struct, SizeHint = 0 };

    public required uint Tag { get; init; }
    public required HeatType Type { get; init; }
    public required byte SizeHint { get; init; }
}
