using EATDF.Members;
using EATDF.Types;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EATDF.Visitors;

public class XmlEncoder : ITdfVisitor
{
    public XElement TdfRoot { get; }

    public XmlEncoder()
    {
        TdfRoot = new XElement("tdf");
    }

    public void VisitTdf(Tdf value)
    {
        TdfRoot.Name = value.GetClassName().ToLowerInvariant();

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
        //TODO: Figure out the format
        return false;
    }

    public bool VisitBlazeObjectType(TdfObjectType value, Tdf parent)
    {
        //TODO: Figure out the format
        return false;
    }

    public bool VisitBlob(TdfBlob value, Tdf parent)
    {
        //TODO: Figure out the format
        return false;
    }

    public bool VisitBool(TdfBool value, Tdf parent)
    {
        return AddToRoot(value);
    }

    public bool VisitEnum<TEnum>(TdfEnum<TEnum> value, Tdf parent) where TEnum : Enum, new()
    {
        return AddToRoot(value);
    }

    public bool VisitFloat(TdfFloat value, Tdf parent)
    {
        return AddToRoot(value);
    }

    public bool VisitInt16(TdfInt16 value, Tdf parent)
    {
        return AddToRoot(value);
    }

    public bool VisitInt32(TdfInt32 value, Tdf parent)
    {
        return AddToRoot(value);
    }

    public bool VisitInt64(TdfInt64 value, Tdf parent)
    {
        return AddToRoot(value);
    }

    public bool VisitInt8(TdfInt8 value, Tdf parent)
    {
        return AddToRoot(value);
    }

    public bool VisitList<T>(TdfList<T> value, Tdf parent)
    {
        //TODO: Figure out the format
        return false;
    }

    public bool VisitMap<TKey, TValue>(TdfMap<TKey, TValue> value, Tdf parent) where TKey : notnull
    {
        //TODO: Figure out the format
        return false;
    }

    public bool VisitString(TdfString value, Tdf parent)
    {
        return AddToRoot(value);
    }

    public bool VisitStruct<TStruct>(TdfStruct<TStruct> value, Tdf parent) where TStruct : Tdf?, new()
    {
        if (value.Value != null && !value.IsSet())
            return false;

        XmlEncoder memberEncoder = new XmlEncoder();
        memberEncoder.VisitTdf(value.Value);
        memberEncoder.TdfRoot.Name = value.TdfInfo.Name.ToLowerInvariant();
        TdfRoot.Add(memberEncoder.TdfRoot);
        return true;
    }

    public bool VisitTimeValue(TdfTimeValue value, Tdf parent)
    {
        return AddToRoot(value, value.Value.Microseconds);
    }

    public bool VisitUInt16(TdfUInt16 value, Tdf parent)
    {
        return AddToRoot(value);
    }

    public bool VisitUInt32(TdfUInt32 value, Tdf parent)
    {
        return AddToRoot(value);
    }

    public bool VisitUInt64(TdfUInt64 value, Tdf parent)
    {
        return AddToRoot(value);
    }

    public bool VisitUInt8(TdfUInt8 value, Tdf parent)
    {
        return AddToRoot(value);
    }

    public bool VisitUnion<TUnion>(TdfUnion<TUnion> value, Tdf parent) where TUnion : Union, new()
    {
        if (value.Value != null && !value.IsSet())
            return false;

        XElement unionElement = new XElement(value.TdfInfo.Name.ToLowerInvariant());
        unionElement.Add(new XAttribute("member", value.Value.ActiveIndex));

        if (value.Value.GetActiveMember() == null)
        {
            TdfRoot.Add(unionElement);
            return false;
        }

        XmlEncoder unionEncoder = new XmlEncoder();
        unionEncoder.VisitTdf(value.Value);

        XElement? encodedElement = unionEncoder.TdfRoot.Elements().FirstOrDefault();
        if(encodedElement != null)
        {
            encodedElement.Name = "valu";
            unionElement.Add(encodedElement);
            TdfRoot.Add(unionElement);
            return true;
        }

        return false;
    }

    public bool VisitVariable(TdfVariable value, Tdf parent)
    {
        //TODO: Figure out the format
        return false;
    }

    bool AddToRoot(ITdfMember member, object? value)
    {
        if (!member.IsSet())
            return false;

        TdfRoot.Add(new XElement(member.TdfInfo.Name.ToLowerInvariant(), value));
        return true;
    }

    bool AddToRoot(ITdfMember member)
    {
        if (!member.IsSet())
            return false;

        TdfRoot.Add(new XElement(member.TdfInfo.Name.ToLowerInvariant(), member.GetValue()));
        return true;
    }

    public override string ToString()
    {
        return TdfRoot.ToString();
    }
}
