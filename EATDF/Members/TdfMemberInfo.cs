using System;
using System.Text;

namespace EATDF.Members;

public class TdfMemberInfo
{
    /// <summary>
    /// The name of C# class member that this info is associated with.
    /// </summary>
    public string Name { get; }

    /// <summary>
    /// The original TDF member name (usually starts with 'm').
    /// </summary>
    public string TdfMemberName { get; }

    /// <summary>
    /// Tag string representation (uppercase).
    /// </summary>
    public string TagString { get; }

    /// <summary>
    /// TDF Tag.
    /// </summary>
    public uint Tag { get; }

    /// <summary>
    /// TDF Type.
    /// </summary>
    public TdfType Type { get; }

    /// <summary>
    /// The index of the member in the TDF structure. Indexes are determined by sorting by the tag (ascending).
    /// </summary>
    public int MemberIndex { get; }

    /// <summary>
    /// Returns true if the tag is used only once in the TDF structure.
    /// </summary>
    public bool IsUnique { get; }

    public TdfMemberInfo(string name, string tdfMemberName, uint tag, TdfType type, int memberIndex, bool isUnique)
    {
        Name = name;
        TdfMemberName = tdfMemberName;
        TagString = ToTagStr(tag);
        Tag = tag;
        Type = type;
        MemberIndex = memberIndex;
        IsUnique = isUnique;
    }

    public TdfMemberInfo(uint tag, TdfType type)
    {
        TagString = ToTagStr(tag);
        Name = TagString;
        TdfMemberName = TagString;
        Tag = tag;
        Type = type;
        MemberIndex = -1;
        IsUnique = true;
    }

    static string ToTagStr(uint tag)
    {
        Span<byte> buf = stackalloc byte[4];
        int len = 4;

        uint val = tag & 0x3F00;
        if (val != 0)
            buf[3] = (byte)(((tag >> 8) & 0x3F) + 32);
        else
        {
            buf[3] = 0;
            len = 3;
        }

        val = (tag >> 14) & 0x3F;
        if (val != 0)
            buf[2] = (byte)(val + 32);
        else
        {
            buf[2] = 0;
            len = 2;
        }

        val = (tag >> 20) & 0x3F;
        if (val != 0)
            buf[1] = (byte)(val + 32);
        else
        {
            buf[1] = 0;
            len = 1;
        }

        val = tag >> 26;
        if (val != 0)
            buf[0] = (byte)(val + 32);
        else
        {
            buf[0] = 0;
            len = 0;
        }

        return Encoding.ASCII.GetString(buf.Slice(0, len));
    }
}
