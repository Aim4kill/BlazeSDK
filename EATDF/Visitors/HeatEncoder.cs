using EATDF.Heat;
using EATDF.Members;
using EATDF.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EATDF.Visitors;

public class HeatEncoder : ITdfVisitor
{
    HeatWriter writer;

    public HeatEncoder(Stream stream)
    {
        writer = new HeatWriter(this, stream);
    }

    public void VisitTdf(Tdf value)
    {
        IEnumerator<ITdfMember> enumerator = value.AllMembers().GetEnumerator();

        if (enumerator.MoveNext())
        {
            do
            {
                ITdfMember member = enumerator.Current;
                bool visited = member.Visit(this, value);

                if (visited && !member.TdfInfo.IsUnique)
                {
                    // Skip all other members with the same tag (field id)
                    while (enumerator.MoveNext())
                    {
                        ITdfMember next = enumerator.Current;
                        if (next.TdfInfo.Tag != member.TdfInfo.Tag)
                            break;
                    }
                }
            }
            while (enumerator.MoveNext());
        }
    }

    public bool VisitBlazeObjectId(TdfObjectId value, Tdf parent)
    {
        // Heat does not support BlazeObjectIds
        return false;
    }

    public bool VisitBlazeObjectType(TdfObjectType value, Tdf parent)
    {
        // Heat does not support BlazeObjectTypes
        return false;
    }

    public bool VisitBlob(TdfBlob value, Tdf parent)
    {
        if (!putHeader(value, HeatType.Blob, value.Value.Length, out byte encodedSizeHint))
            return false;

        writer.WriteBlob(value.Value, encodedSizeHint);
        return true;
    }

    public bool VisitBool(TdfBool value, Tdf parent)
    {
        if (!putHeader(value, HeatType.Int8, sizeof(sbyte), out byte encodedSizeHint))
            return false;

        writer.WriteBool(value.Value, encodedSizeHint);
        return true;
    }

    public bool VisitEnum<TEnum>(TdfEnum<TEnum> value, Tdf parent) where TEnum : Enum, new()
    {
        HeatType? wantedHeatType = HeatUtil.ToHeatType(value.UnderlyingType);
        if (wantedHeatType == null)
            return false;

        HeatType enumHeatType = wantedHeatType.Value;
        byte sizeHint = HeatUtil.GetDefaultTypeSize(enumHeatType);

        if (!putHeader(value, enumHeatType, sizeHint, out byte encodedSizeHint))
            return false;

        writer.WriteEnum(value.Value, encodedSizeHint);
        return true;
    }

    public bool VisitFloat(TdfFloat value, Tdf parent)
    {
        //Heat does not support floats
        return false;
    }

    public bool VisitInt16(TdfInt16 value, Tdf parent)
    {
        if (!putHeader(value, HeatType.Int16, sizeof(short), out byte encodedSizeHint))
            return false;

        writer.WriteInt16(value.Value, encodedSizeHint);
        return true;
    }

    public bool VisitInt32(TdfInt32 value, Tdf parent)
    {
        if (!putHeader(value, HeatType.Int32, sizeof(int), out byte encodedSizeHint))
            return false;

        writer.WriteInt32(value.Value, encodedSizeHint);
        return true;
    }

    public bool VisitInt64(TdfInt64 value, Tdf parent)
    {
        if (!putHeader(value, HeatType.Int64, sizeof(long), out byte encodedSizeHint))
            return false;

        writer.WriteInt64(value.Value, encodedSizeHint);
        return true;
    }

    public bool VisitInt8(TdfInt8 value, Tdf parent)
    {
        if (!putHeader(value, HeatType.Int8, sizeof(sbyte), out byte encodedSizeHint))
            return false;

        writer.WriteInt8(value.Value, encodedSizeHint);
        return true;
    }

    public bool VisitList<T>(TdfList<T> value, Tdf parent)
    {
        if (value.Value == null)
            return false;

        if (!putHeader(value, HeatType.Array, 1, out byte encodedSizeHint))
            return false;

        writer.WriteList(value.Value, encodedSizeHint);
        return true;
    }

    public bool VisitMap<TKey, TValue>(TdfMap<TKey, TValue> value, Tdf parent) where TKey : notnull
    {
        if (value.Value == null)
            return false;

        if (!putHeader(value, HeatType.Map, value.Value.Count, out byte encodedSizeHint))
            return false;

        writer.WriteMap(value.Value, encodedSizeHint);
        return true;
    }

    public bool VisitString(TdfString value, Tdf parent)
    {
        if (value.Value == null)
            return false;

        int stringLen = Encoding.UTF8.GetByteCount(value.Value) + 1; // +1 for null terminator
        if (!putHeader(value, HeatType.String, stringLen, out byte encodedSizeHint))
            return false;

        writer.WriteString(value.Value, encodedSizeHint);
        return true;
    }

    public bool VisitStruct<TStruct>(TdfStruct<TStruct> value, Tdf parent) where TStruct : Tdf?, new()
    {
        if(value.Value == null)
            return false;

        if (!putHeader(value, HeatType.Struct, 0, out byte encodedSizeHint))
            return false;

        writer.WriteStruct(value.Value, encodedSizeHint);
        return true;
    }

    public bool VisitTimeValue(TdfTimeValue value, Tdf parent)
    {
        // Heat does not support TimeValues
        return false;
    }

    public bool VisitUInt16(TdfUInt16 value, Tdf parent)
    {
        if (!putHeader(value, HeatType.UInt16, sizeof(ushort), out byte encodedSizeHint))
            return false;

        writer.WriteUInt16(value.Value, encodedSizeHint);
        return true;
    }

    public bool VisitUInt32(TdfUInt32 value, Tdf parent)
    {
        if (!putHeader(value, HeatType.UInt32, sizeof(uint), out byte encodedSizeHint))
            return false;

        writer.WriteUInt32(value.Value, encodedSizeHint);
        return true;
    }

    public bool VisitUInt64(TdfUInt64 value, Tdf parent)
    {
        if (!putHeader(value, HeatType.UInt64, sizeof(ulong), out byte encodedSizeHint))
            return false;

        writer.WriteUInt64(value.Value, encodedSizeHint);
        return true;
    }

    public bool VisitUInt8(TdfUInt8 value, Tdf parent)
    {
        if (!putHeader(value, HeatType.UInt8, sizeof(byte), out byte encodedSizeHint))
            return false;

        writer.WriteUInt8(value.Value, encodedSizeHint);
        return true;
    }

    public bool VisitUnion<TUnion>(TdfUnion<TUnion> value, Tdf parent) where TUnion : Union, new()
    {
        if (value.Value == null)
            return false;

        if (!putHeader(value, HeatType.Union, 0, out byte encodedSizeHint))
            return false;

        writer.WriteUnion(value.Value, encodedSizeHint);
        return true;
    }

    public bool VisitVariable(TdfVariable value, Tdf parent)
    {
        // Heat does not support Variables
        return false;
    }

    bool putHeader(ITdfMember member, HeatType type, int typeSize, out byte encodedSizeHint)
    {
        // Not set means this value was not set at all after tdf was created, we should not encode it
        if (!member.IsSet())
        {
            encodedSizeHint = 0;
            return false;
        }

        writer.WriteHeader(member.TdfInfo.Tag, type, typeSize, out encodedSizeHint);
        return true;
    }
}
