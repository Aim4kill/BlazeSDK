namespace EATDF.Heat2;

internal struct Heat2MemberHeader
{
    public static readonly Heat2MemberHeader Invalid = new Heat2MemberHeader { Tag = 0, Type = Heat2Type.Struct};

    public required uint Tag { get; init; }
    public required Heat2Type Type { get; init; }
}
