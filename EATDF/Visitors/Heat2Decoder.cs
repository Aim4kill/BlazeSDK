using EATDF.Heat;
using EATDF.Heat2;
using EATDF.Internal;
using EATDF.Members;
using EATDF.Serialization;
using EATDF.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EATDF.Visitors;

public class Heat2Decoder : ITdfVisitor
{
    Heat2Reader reader;
    public ITdfRegistry Registry { get; }
    public bool StreamValid => reader.StreamValid;

    public Heat2Decoder(Stream stream)
    {
        reader = new Heat2Reader(this, stream);
        Registry = new TdfRegistry();
    }

    public Heat2Decoder(byte[] data) : this(new MemoryStream(data))
    {
    }

    public Heat2Decoder(Stream stream, ITdfRegistry registry)
    {
        reader = new Heat2Reader(this, stream);
        Registry = registry;
    }

    public Heat2Decoder(byte[] data, ITdfRegistry registry) : this(new MemoryStream(data), registry)
    {
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


        //Read remaining fields (if there are any)
        while (reader.HasData(Heat2Reader.HeaderSize))
        {
            if (!reader.TrySkipNextElement(value))
                break;
        }

    }

    public bool VisitBlazeObjectId(TdfObjectId value, Tdf parent)
    {
        if (!getHeader(parent, value, Heat2Type.BlazeObjectId))
            return false;

        if (!reader.TryReadObjectId(out ObjectId val))
            return false;

        value.Value = val;
        return true;
    }

    public bool VisitBlazeObjectType(TdfObjectType value, Tdf parent)
    {
        if (!getHeader(parent, value, Heat2Type.BlazeObjectType))
            return false;

        if (!reader.TryReadObjectType(out ObjectType val))
            return false;

        value.Value = val;
        return true;
    }

    public bool VisitBlob(TdfBlob value, Tdf parent)
    {
        if (!getHeader(parent, value, Heat2Type.Binary))
            return false;

        if(!reader.TryReadBlob(out byte[] val))
            return false;

        value.Value = val;
        return true;
    }

    public bool VisitBool(TdfBool value, Tdf parent)
    {
        if (!getHeader(parent, value, Heat2Type.Integer))
            return false;

        if (!reader.TryReadBool(out bool val))
            return false;

        value.Value = val;
        return true;
    }

    public bool VisitEnum<TEnum>(TdfEnum<TEnum> value, Tdf parent) where TEnum : Enum, new()
    {
        if (!getHeader(parent, value, Heat2Type.Integer))
            return false;

        if (!reader.TryReadEnum(out TEnum val))
            return false;

        value.Value = val;
        return true;
    }

    public bool VisitFloat(TdfFloat value, Tdf parent)
    {
        if (!getHeader(parent, value, Heat2Type.Float))
            return false;

        if (!reader.TryReadFloat(out float val))
            return false;

        value.Value = val;
        return true;
    }

    public bool VisitInt16(TdfInt16 value, Tdf parent)
    {
        if(!getHeader(parent, value, Heat2Type.Integer))
            return false;

        if (!reader.TryReadInt16(out short val))
            return false;

        value.Value = val;
        return true;
    }

    public bool VisitInt32(TdfInt32 value, Tdf parent)
    {
        if (!getHeader(parent, value, Heat2Type.Integer))
            return false;

        if (!reader.TryReadInt32(out int val))
            return false;

        value.Value = val;
        return true;
    }

    public bool VisitInt64(TdfInt64 value, Tdf parent)
    {
        if (!getHeader(parent, value, Heat2Type.Integer))
            return false;

        if (!reader.TryReadInt64(out long val))
            return false;

        value.Value = val;
        return true;
    }

    public bool VisitInt8(TdfInt8 value, Tdf parent)
    {
        if (!getHeader(parent, value, Heat2Type.Integer))
            return false;

        if (!reader.TryReadInt8(out sbyte val))
            return false;

        value.Value = val;
        return true;
    }

    public bool VisitList<T>(TdfList<T> value, Tdf parent)
    {
        if (!getHeader(parent, value, Heat2Type.List))
            return false;

        if (!reader.TryReadList(out IList<T> val))
            return false;

        value.Value = val;
        return true;
    }

    public bool VisitMap<TKey, TValue>(TdfMap<TKey, TValue> value, Tdf parent) where TKey : notnull
    {
        if (!getHeader(parent, value, Heat2Type.Map))
            return false;

        if (!reader.TryReadMap(out IDictionary<TKey, TValue> val))
            return false;

        value.Value = val;
        return true;
    }

    public bool VisitString(TdfString value, Tdf parent)
    {
        if(!getHeader(parent, value, Heat2Type.String))
            return false;

        if (!reader.TryReadString(out string str))
            return false;

        value.Value = str;
        return true;
    }

    public bool VisitStruct<TStruct>(TdfStruct<TStruct> value, Tdf parent) where TStruct : Tdf?, new()
    {
        if (!getHeader(parent, value, Heat2Type.Struct))
            return false;

        if (!reader.TryReadStruct(out TStruct? val))
            return false;

        value.Value = val;
        return true;
    }

    public bool VisitTimeValue(TdfTimeValue value, Tdf parent)
    {
        if (!getHeader(parent, value, Heat2Type.Integer))
            return false;

        if (!reader.TryReadTimeValue(out TimeValue val))
            return false;

        value.Value = val;
        return true;
    }

    public bool VisitUInt16(TdfUInt16 value, Tdf parent)
    {
        if (!getHeader(parent, value, Heat2Type.Integer))
            return false;

        if (!reader.TryReadUInt16(out ushort val))
            return false;

        value.Value = val;
        return true;
    }

    public bool VisitUInt32(TdfUInt32 value, Tdf parent)
    {
        if (!getHeader(parent, value, Heat2Type.Integer))
            return false;

        if (!reader.TryReadUInt32(out uint val))
            return false;

        value.Value = val;
        return true;
    }

    public bool VisitUInt64(TdfUInt64 value, Tdf parent)
    {
        if (!getHeader(parent, value, Heat2Type.Integer))
            return false;

        if (!reader.TryReadUInt64(out ulong val))
            return false;

        value.Value = val;
        return true;
    }

    public bool VisitUInt8(TdfUInt8 value, Tdf parent)
    {
        if (!getHeader(parent, value, Heat2Type.Integer))
            return false;

        if (!reader.TryReadUInt8(out byte val))
            return false;

        value.Value = val;
        return true;
    }

    public bool VisitUnion<TUnion>(TdfUnion<TUnion> value, Tdf parent) where TUnion : Union, new()
    {
        if (!getHeader(parent, value, Heat2Type.Union))
            return false;

        if (!reader.TryReadUnion(out TUnion val))
            return false;

        value.Value = val;
        return true;
    }

    public bool VisitVariable(TdfVariable value, Tdf parent)
    {
        if (!getHeader(parent, value, Heat2Type.Variable))
            return false;

        if (!reader.TryReadVariable(out object? val))
            return false;

        value.Value = val;
        return true;
    }

    bool getHeader(Tdf parent, ITdfMember member, Heat2Type type)
    {
        // Check if decoding has already failed
        if (!StreamValid)
            return false;

        while (reader.HasData(Heat2Reader.HeaderSize))
        {
            RestorePoint rp = reader.CreateRestorePoint();

            if (!reader.TryReadHeat2MemberHeader(out Heat2MemberHeader header))
                return false;
            
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

        return false;
    }
}
