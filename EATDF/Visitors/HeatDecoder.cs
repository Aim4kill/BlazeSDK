using EATDF.Heat;
using EATDF.Internal;
using EATDF.Members;
using EATDF.Types;
using System.Data;
using System.Reflection.Metadata.Ecma335;

namespace EATDF.Visitors;

public class HeatDecoder : ITdfVisitor
{
    HeatReader reader;
    public bool StreamValid => reader.StreamValid;

    public HeatDecoder(Stream stream)
    {
        reader = new HeatReader(this, stream);
    }

    public HeatDecoder(byte[] data) : this(new MemoryStream(data))
    {

    }

    public void VisitTdf(Tdf value)
    {
        IEnumerator<ITdfMember> enumerator = value.AllMembers().GetEnumerator();

        if(enumerator.MoveNext())
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

        //Read remaining fields (if there are any)
        while (reader.HasData(HeatReader.HeaderSize))
        {
            if (!reader.TrySkipNextElement(value))
                break;
        }

    }

    public bool VisitBlazeObjectId(TdfObjectId value, Tdf parent)
    {
        // Heat does not support BlazeObjectId
        return false;
    }

    public bool VisitBlazeObjectType(TdfObjectType value, Tdf parent)
    {
        // Heat does not support BlazeObjectType
        return false;
    }

    public bool VisitBlob(TdfBlob value, Tdf parent)
    {
        if (!getHeader(parent, value, HeatType.Blob, out byte sizeHint))
            return false;

        if (!reader.TryReadBlob(out byte[] val, sizeHint))
            return false;

        value.Value = val;
        return true;
    }

    public bool VisitBool(TdfBool value, Tdf parent)
    {
        if (!getHeader(parent, value, HeatType.Int8, out byte sizeHint))
            return false;

        if (!reader.TryReadBool(out bool val, sizeHint))
            return false;

        value.Value = val;
        return true;
    }

    public bool VisitFloat(TdfFloat value, Tdf parent)
    {
        // Heat does not support floats
        return false;
    }

    public bool VisitInt16(TdfInt16 value, Tdf parent)
    {
        if (!getHeader(parent, value, HeatType.Int16, out byte sizeHint))
            return false;

        if (!reader.TryReadInt16(out short val, sizeHint))
            return false;

        value.Value = val;
        return true;
    }

    public bool VisitInt32(TdfInt32 value, Tdf parent)
    {
        if (!getHeader(parent, value, HeatType.Int32, out byte sizeHint))
            return false;

        if (!reader.TryReadInt32(out int val, sizeHint))
            return false;

        value.Value = val;
        return true;
    }

    public bool VisitInt64(TdfInt64 value, Tdf parent)
    {
        if (!getHeader(parent, value, HeatType.Int64, out byte sizeHint))
            return false;

        if (!reader.TryReadInt64(out long val, sizeHint))
            return false;

        value.Value = val;
        return true;
    }

    public bool VisitInt8(TdfInt8 value, Tdf parent)
    {
        if (!getHeader(parent, value, HeatType.Int8, out byte sizeHint))
            return false;

        if (!reader.TryReadInt8(out sbyte val, sizeHint))
            return false;

        value.Value = val;
        return true;
    }

    public bool VisitList<T>(TdfList<T> value, Tdf parent)
    {
        RestorePoint rp = reader.CreateRestorePoint();

        if (!getHeader(parent, value, HeatType.Array, out byte sizeHint))
            return false;

        if (reader.TryReadList(out IList<T> list, sizeHint))
        {
            value.Value = list;
            return true;
        }

        // One of 2 things happened:
        // 1. The list has a different item type than expected
        // 2. Stream corrupted

        // Restoring the reader to the previous state if stream is not corrupted
        if (StreamValid)
            reader.RestoreTo(rp);

        return false;
    }

    public bool VisitMap<TKey, TValue>(TdfMap<TKey, TValue> value, Tdf parent) where TKey : notnull
    {
        RestorePoint rp = reader.CreateRestorePoint();

        if (!getHeader(parent, value, HeatType.Map, out byte sizeHint))
            return false;

        if (reader.TryReadMap(out IDictionary<TKey, TValue> map, sizeHint))
        {
            value.Value = map;
            return true;
        }

        // One of 2 things happened:
        // 1. The map has a different key or value type than expected
        // 2. Stream corrupted

        // Restoring the reader to the previous state if stream is not corrupted
        if (StreamValid)
            reader.RestoreTo(rp);

        return false;
    }

    public bool VisitString(TdfString value, Tdf parent)
    {
        if (!getHeader(parent, value, HeatType.String, out byte sizeHint))
            return false;

        if (!reader.TryReadString(out string val, sizeHint))
            return false;

        value.Value = val;
        return true;
    }

    public bool VisitStruct<TStruct>(TdfStruct<TStruct> value, Tdf parent) where TStruct : Tdf?, new()
    {
        if (!getHeader(parent, value, HeatType.Struct, out byte sizeHint))
            return false;

        if (!reader.TryReadStruct(out TStruct? val, sizeHint))
            return false;

        value.Value = val;
        return true;
    }

    public bool VisitTimeValue(TdfTimeValue value, Tdf parent)
    {
        // Heat does not support TimeValue
        return false;
    }

    public bool VisitUInt16(TdfUInt16 value, Tdf parent)
    {
        if (!getHeader(parent, value, HeatType.UInt16, out byte sizeHint))
            return false;

        if (!reader.TryReadUInt16(out ushort val, sizeHint))
            return false;

        value.Value = val;
        return true;
    }

    public bool VisitUInt32(TdfUInt32 value, Tdf parent)
    {
        if (!getHeader(parent, value, HeatType.UInt32, out byte sizeHint))
            return false;

        if (!reader.TryReadUInt32(out uint val, sizeHint))
            return false;

        value.Value = val;
        return true;
    }

    public bool VisitUInt64(TdfUInt64 value, Tdf parent)
    {
        if (!getHeader(parent, value, HeatType.UInt64, out byte sizeHint))
            return false;

        if (!reader.TryReadUInt64(out ulong val, sizeHint))
            return false;

        value.Value = val;
        return true;
    }

    public bool VisitUInt8(TdfUInt8 value, Tdf parent)
    {
        if (!getHeader(parent, value, HeatType.UInt8, out byte sizeHint))
            return false;

        if (!reader.TryReadUInt8(out byte val, sizeHint))
            return false;

        value.Value = val;
        return true;
    }

    public bool VisitVariable(TdfVariable value, Tdf parent)
    {
        // Heat does not support Variable
        return false;
    }

    public bool VisitUnion<TUnion>(TdfUnion<TUnion> value, Tdf parent) where TUnion : Union, new()
    {
        if (!getHeader(parent, value, HeatType.Union, out byte sizeHint))
            return false;

        if (!reader.TryReadUnion(out TUnion val, sizeHint))
            return false;

        value.Value = val;
        return true;
    }

    public bool VisitEnum<TEnum>(TdfEnum<TEnum> value, Tdf parent) where TEnum : Enum, new()
    {
        HeatType? wantedHeatType = HeatUtil.ToHeatType(value.UnderlyingType);

        if (wantedHeatType == null)
            return false;

        if (!getHeader(parent, value, wantedHeatType.Value, out byte sizeHint))
            return false;

        if (!reader.TryReadEnum(out TEnum val, sizeHint))
            return false;

        value.Value = val;
        return true;
    }

    bool getHeader(Tdf parent, ITdfMember member, HeatType type, out byte sizeHint)
    {
        // Check if decoding has already failed
        if (!StreamValid)
        {
            sizeHint = 0;
            return false;
        }
            

        while (reader.HasData(HeatReader.HeaderSize))
        {
            RestorePoint rp = reader.CreateRestorePoint();

            if (!reader.TryReadHeatMemberHeader(out HeatMemberHeader header))
            {
                sizeHint = 0;
                return false;
            }

            sizeHint = header.SizeHint;
            uint tag = member.TdfInfo.Tag;

            // Check if we found the correct tag
            if (header.Tag == tag)
            {
                // Check if type is the same
                if (header.Type == type)
                    return true;

                reader.RestoreTo(rp);
                return false;
            }

            reader.RestoreTo(rp);

            //  Tag does not exist, we have already started reading the next member tag, we need to seek back
            if (header.Tag > tag)
                return false;

            // Unknown tag, skip it
            if (!reader.TrySkipNextElement(parent))
                return false;
        }

        sizeHint = 0;
        return false;
    }
}
