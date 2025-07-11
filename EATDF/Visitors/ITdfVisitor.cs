using EATDF.Members;
using EATDF.Types;

namespace EATDF.Visitors;

public interface ITdfVisitor
{
    /// <summary>
    /// Main method for visiting Tdf objects and their children
    /// </summary>
    /// <param name="value">The tdf object</param>
    void VisitTdf(Tdf value);
    bool VisitBlob(TdfBlob value, Tdf parent);
    bool VisitBool(TdfBool value, Tdf parent);
    bool VisitFloat(TdfFloat value, Tdf parent);
    bool VisitInt8(TdfInt8 value, Tdf parent);
    bool VisitInt16(TdfInt16 value, Tdf parent);
    bool VisitInt32(TdfInt32 value, Tdf parent);
    bool VisitInt64(TdfInt64 value, Tdf parent);
    bool VisitList<T>(TdfList<T> value, Tdf parent);
    bool VisitMap<TKey, TValue>(TdfMap<TKey, TValue> value, Tdf parent) where TKey : notnull;
    bool VisitString(TdfString value, Tdf parent);
    bool VisitStruct<TStruct>(TdfStruct<TStruct> value, Tdf parent) where TStruct : Tdf?, new();
    bool VisitUInt8(TdfUInt8 value, Tdf parent);
    bool VisitUInt16(TdfUInt16 value, Tdf parent);
    bool VisitUInt32(TdfUInt32 value, Tdf parent);
    bool VisitUInt64(TdfUInt64 value, Tdf parent);
    bool VisitEnum<TEnum>(TdfEnum<TEnum> value, Tdf parent) where TEnum : Enum, new();
    bool VisitVariable(TdfVariable value, Tdf parent);
    bool VisitBlazeObjectType(TdfObjectType value, Tdf parent);
    bool VisitBlazeObjectId(TdfObjectId value, Tdf parent);
    bool VisitTimeValue(TdfTimeValue value, Tdf parent);
    bool VisitUnion<TUnion>(TdfUnion<TUnion> value, Tdf parent) where TUnion : Union, new();
}
