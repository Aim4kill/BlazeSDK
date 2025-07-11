using EATDF.Heat;
using EATDF.Heat2;
using EATDF.Members;
using EATDF.Serialization;
using EATDF.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EATDF.Visitors;

internal class Heat2Encoder : ITdfVisitor
{
    Heat2Writer writer;
    public ITdfRegistry Registry { get; }
    public Heat2Encoder(Stream stream)
    {
        writer = new Heat2Writer(this, stream);
        Registry = new TdfRegistry();
    }

    public Heat2Encoder(Stream stream, ITdfRegistry registry)
    {
        writer = new Heat2Writer(this, stream);
        Registry = registry;
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
        if (!putHeader(value, Heat2Type.BlazeObjectId))
            return false;

        writer.WriteObjectId(value.Value);
        return true;
    }

    public bool VisitBlazeObjectType(TdfObjectType value, Tdf parent)
    {
        if (!putHeader(value, Heat2Type.BlazeObjectType))
            return false;

        writer.WriteObjectType(value.Value);
        return true;
    }

    public bool VisitBlob(TdfBlob value, Tdf parent)
    {
        if (!putHeader(value, Heat2Type.Binary))
            return false;

        writer.WriteBlob(value.Value);
        return true;
    }

    public bool VisitBool(TdfBool value, Tdf parent)
    {
        if (!putHeader(value, Heat2Type.Integer))
            return false;

        writer.WriteBool(value.Value);
        return true;
    }

    public bool VisitEnum<TEnum>(TdfEnum<TEnum> value, Tdf parent) where TEnum : Enum, new()
    {
        if (!putHeader(value, Heat2Type.Integer))
            return false;

        writer.WriteEnum(value.Value);
        return true;
    }

    public bool VisitFloat(TdfFloat value, Tdf parent)
    {
        if (!putHeader(value, Heat2Type.Float))
            return false;

        writer.WriteFloat(value.Value);
        return true;
    }

    public bool VisitInt16(TdfInt16 value, Tdf parent)
    {
        if (!putHeader(value, Heat2Type.Integer))
            return false;

        writer.WriteInt16(value.Value);
        return true;
    }

    public bool VisitInt32(TdfInt32 value, Tdf parent)
    {
        if (!putHeader(value, Heat2Type.Integer))
            return false;

        writer.WriteInt32(value.Value);
        return true;
    }

    public bool VisitInt64(TdfInt64 value, Tdf parent)
    {
        if (!putHeader(value, Heat2Type.Integer))
            return false;

        writer.WriteInt64(value.Value);
        return true;
    }

    public bool VisitInt8(TdfInt8 value, Tdf parent)
    {
        if (!putHeader(value, Heat2Type.Integer))
            return false;

        writer.WriteInt8(value.Value);
        return true;
    }

    public bool VisitList<T>(TdfList<T> value, Tdf parent)
    {
        if (!putHeader(value, Heat2Type.List))
            return false;

        writer.WriteList(value.Value);
        return true;
    }

    public bool VisitMap<TKey, TValue>(TdfMap<TKey, TValue> value, Tdf parent) where TKey : notnull
    {
        if (!putHeader(value, Heat2Type.Map))
            return false;

        writer.WriteMap(value.Value);
        return true;
    }

    public bool VisitString(TdfString value, Tdf parent)
    {
        if (!putHeader(value, Heat2Type.String))
            return false;

        writer.WriteString(value.Value);
        return true;
    }

    public bool VisitStruct<TStruct>(TdfStruct<TStruct> value, Tdf parent) where TStruct : Tdf?, new()
    {
        if (!putHeader(value, Heat2Type.Struct))
            return false;

        writer.WriteStruct(value.Value);
        return true;
    }

    public bool VisitTimeValue(TdfTimeValue value, Tdf parent)
    {
        if (!putHeader(value, Heat2Type.Integer))
            return false;

        writer.WriteTimeValue(value.Value);
        return true;
    }

    public bool VisitUInt16(TdfUInt16 value, Tdf parent)
    {
        if (!putHeader(value, Heat2Type.Integer))
            return false;

        writer.WriteUInt16(value.Value);
        return true;
    }

    public bool VisitUInt32(TdfUInt32 value, Tdf parent)
    {
        if (!putHeader(value, Heat2Type.Integer))
            return false;

        writer.WriteUInt32(value.Value);
        return true;
    }

    public bool VisitUInt64(TdfUInt64 value, Tdf parent)
    {
        if (!putHeader(value, Heat2Type.Integer))
            return false;

        writer.WriteUInt64(value.Value);
        return true;
    }

    public bool VisitUInt8(TdfUInt8 value, Tdf parent)
    {
        if (!putHeader(value, Heat2Type.Integer))
            return false;

        writer.WriteUInt8(value.Value);
        return true;
    }

    public bool VisitUnion<TUnion>(TdfUnion<TUnion> value, Tdf parent) where TUnion : Union, new()
    {
        if (!putHeader(value, Heat2Type.Union))
            return false;

        writer.WriteUnion(value.Value);
        return true;
    }

    public bool VisitVariable(TdfVariable value, Tdf parent)
    {
        if (!putHeader(value, Heat2Type.Variable))
            return false;

        writer.WriteVariable(value.Value);
        return true;
    }

    bool putHeader(ITdfMember member, Heat2Type type)
    {
        // Not set means this value was not set at all after tdf was created, we should not encode it
        if (!member.IsSet())
            return false;
        
        writer.WriteHeader(member.TdfInfo.Tag, type);
        return true;
    }
}
