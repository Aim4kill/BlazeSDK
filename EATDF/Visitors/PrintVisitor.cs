using EATDF.Members;
using EATDF.Printer;
using EATDF.Types;

namespace EATDF.Visitors;

public class PrintVisitor : ITdfVisitor
{
    TabbedStringBuilder sb = new();

    public void VisitTdf(Tdf value)
    {
        sb.AppendLine($"{value.GetClassName()} = {{");
        sb.AddTab();

        foreach (ITdfMember member in value.AllMembers())
            member.Visit(this, value);

        sb.RemoveTab();
        sb.AppendWithTab("}");
    }

    public bool VisitBlob(TdfBlob value, Tdf parent)
    {
        if (value.Value == null)
        {
            sb.AppendLine($"{getFieldName(value)} = (null)");
            return true;
        }

        sb.AppendLine($"{getFieldName(value)} = {StringFormatter.FormatBytes(value.Value)}");
        return true;
    }

    public bool VisitBool(TdfBool value, Tdf parent)
    {
        sb.AppendLine($"{getFieldName(value)} = {StringFormatter.FormatBool(value.Value)}");
        return true;
    }

    public bool VisitFloat(TdfFloat value, Tdf parent)
    {
        sb.AppendLine($"{getFieldName(value)} = {StringFormatter.FormatFloat(value.Value)}");
        return true;
    }

    public bool VisitInt16(TdfInt16 value, Tdf parent)
    {
        sb.AppendLine($"{getFieldName(value)} = {StringFormatter.FormatInt16(value.Value)}");
        return true;
    }

    public bool VisitInt32(TdfInt32 value, Tdf parent)
    {
        sb.AppendLine($"{getFieldName(value)} = {StringFormatter.FormatInt32(value.Value)}");
        return true;
    }

    public bool VisitInt64(TdfInt64 value, Tdf parent)
    {
        sb.AppendLine($"{getFieldName(value)} = {StringFormatter.FormatInt64(value.Value)}");
        return true;
    }

    public bool VisitInt8(TdfInt8 value, Tdf parent)
    {
        sb.AppendLine($"{getFieldName(value)} = {StringFormatter.FormatInt8(value.Value)}");
        return true;
    }

    public bool VisitList<T>(TdfList<T> value, Tdf parent)
    {
        sb.AppendLine($"{getFieldName(value)} = {StringFormatter.FormatList(value.Value)}");
        return true;
    }

    public bool VisitMap<TKey, TValue>(TdfMap<TKey, TValue> value, Tdf parent) where TKey : notnull
    {
        sb.AppendLine($"{getFieldName(value)} = {StringFormatter.FormatMap(value.Value)}");
        return true;
    }

    public bool VisitString(TdfString value, Tdf parent)
    {
        sb.AppendLine($"{getFieldName(value)} = {StringFormatter.FormatString(value.Value)}");
        return true;
    }

    public bool VisitStruct<TStruct>(TdfStruct<TStruct> value, Tdf parent) where TStruct : Tdf?, new()
    {
        if (value.Value == null)
        {
            sb.AppendLine($"{getFieldName(value)} = (null)");
            return true;
        }

        sb.AppendLine($"{getFieldName(value)} = {{");
        sb.AddTab();

        Tdf tdf = value.Value;

        foreach (ITdfMember member in tdf.AllMembers())
            member.Visit(this, tdf);

        sb.RemoveTab();
        sb.AppendLine("}");

        return true;
    }

    public bool VisitUInt16(TdfUInt16 value, Tdf parent)
    {
        sb.AppendLine($"{getFieldName(value)} = {StringFormatter.FormatUInt16(value.Value)}");
        return true;
    }

    public bool VisitUInt32(TdfUInt32 value, Tdf parent)
    {
        sb.AppendLine($"{getFieldName(value)} = {StringFormatter.FormatUInt32(value.Value)}");
        return true;
    }

    public bool VisitUInt64(TdfUInt64 value, Tdf parent)
    {
        sb.AppendLine($"{getFieldName(value)} = {StringFormatter.FormatUInt64(value.Value)}");
        return true;
    }

    public bool VisitUInt8(TdfUInt8 value, Tdf parent)
    {
        sb.AppendLine($"{getFieldName(value)} = {StringFormatter.FormatUInt8(value.Value)}");
        return true;
    }

    public bool VisitVariable(TdfVariable value, Tdf parent)
    {
        sb.AppendLine($"{getFieldName(value)} = {StringFormatter.FormatVariable(value.Value)}");
        return true;
    }

    string getFieldName(ITdfMember value)
    {
        return $"{value.TdfInfo.Name}({value.TdfInfo.TagString})";
    }

    public bool VisitBlazeObjectType(TdfObjectType value, Tdf parent)
    {
        sb.AppendLine($"{getFieldName(value)} = {StringFormatter.FormatBlazeObjectType(value.Value)}");
        return true;
    }

    public bool VisitBlazeObjectId(TdfObjectId value, Tdf parent)
    {
        sb.AppendLine($"{getFieldName(value)} = {StringFormatter.FormatBlazeObjectId(value.Value)}");
        return true;
    }

    public bool VisitTimeValue(TdfTimeValue value, Tdf parent)
    {
        sb.AppendLine($"{getFieldName(value)} = {StringFormatter.FormatTimeValue(value.Value)}");
        return true;
    }

    public bool VisitEnum<TEnum>(TdfEnum<TEnum> value, Tdf parent) where TEnum : Enum, new()
    {
        sb.AppendLine($"{getFieldName(value)} = {StringFormatter.FormatEnum(value.Value)}");
        return true;
    }

    public bool VisitUnion<TUnion>(TdfUnion<TUnion> tdfUnion, Tdf parent) where TUnion : Union, new()
    {
        sb.AppendLine($"{getFieldName(tdfUnion)} (union: {tdfUnion.Value.ActiveIndex}) = {{");
        sb.AddTab();

        Tdf tdf = tdfUnion.Value;

        foreach (ITdfMember member in tdf.AllMembers())
            member.Visit(this, tdf);

        sb.RemoveTab();
        sb.AppendLine("}");

        return true;
    }

    public override string ToString()
    {
        return sb.ToString();
    }


}
